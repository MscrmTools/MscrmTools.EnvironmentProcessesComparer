using McTools.Xrm.Connection;
using Microsoft.Xrm.Sdk;
using MscrmTools.EnvironmentProcessesComparer.AppCode;
using MscrmTools.EnvironmentProcessesComparer.Forms;
using MscrmTools.EnvironmentProcessesComparer.UserControls;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using XrmToolBox.Extensibility;
using XrmToolBox.Extensibility.Interfaces;

namespace MscrmTools.EnvironmentProcessesComparer
{
    public partial class MyPluginControl : MultipleConnectionsPluginControlBase, IPayPalPlugin, IGitHubPlugin
    {
        private List<ProcessInfo> _processInfos;

        private Thread filterThread;
        private List<Entity> solutions = new List<Entity>();

        public MyPluginControl()
        {
            InitializeComponent();
        }

        public string DonationDescription => "Donation for Environment Processes Comparer";

        public string EmailAccount => "tanguy92@hotmail.com";

        public string RepositoryName => "MscrmTools";

        public string UserName => "MscrmTools.EnvironmentProcessesComparer";

        /// <summary>
        /// This event occurs when the connection has been updated in XrmToolBox
        /// </summary>
        public override void UpdateConnection(IOrganizationService newService, ConnectionDetail detail, string actionName, object parameter)
        {
            base.UpdateConnection(newService, detail, actionName, parameter);

            if (actionName != "AdditionalOrganization")
            {
                lvProcesses.Columns[2].Text = detail.ConnectionName;
                ClearContent();
            }
        }

        protected override void ConnectionDetailsUpdated(NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == NotifyCollectionChangedAction.Add)
            {
                foreach (ConnectionDetail cd in e.NewItems)
                {
                    int index = lvProcesses.Columns.Count - 1;

                    lvProcesses.Columns.Add(new ColumnHeader { Text = cd.ConnectionName, Width = 100, Tag = cd });

                    LoadProcessesForAdditional(cd, index);
                }

                chkShowOnlyDifference.Enabled = true;
            }
        }

        private void ClearContent()
        {
            lvProcesses.Items.Clear();
            AdditionalConnectionDetails.Clear();
            for (var i = lvProcesses.Columns.Count - 1; i >= 3; i--)
            {
                lvProcesses.Columns.RemoveAt(i);
            }

            scMain.Panel2Collapsed = true;
        }

        private void Ctrl_OnStateChangeRequested(object sender, StateChangeEventArgs e)
        {
            WorkAsync(new WorkAsyncInfo
            {
                Message = "Updating state...",
                Work = (bw, evt) =>
                {
                    var toUpdate = new Entity(e.record.LogicalName)
                    {
                        Id = e.record.Id
                    };

                    e.record["statecode"] = new OptionSetValue(e.State == 1 ? 1 : 0);
                    e.record["statuscode"] = new OptionSetValue(e.State == 1 ? 2 : 1);
                    toUpdate["statecode"] = e.record["statecode"];
                    toUpdate["statuscode"] = e.record["statuscode"];
                    e.ConnectionDetail.GetCrmServiceClient().Update(toUpdate);
                },
                PostWorkCallBack = (evt) =>
                {
                    if (evt.Error != null)
                    {
                        MessageBox.Show(this, $@"Error while updating process state: {evt.Error.Message}", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    ((ProcessStateControl)sender).SetInvertedState();

                    var selectedItem = lvProcesses.SelectedItems.Cast<ListViewItem>().FirstOrDefault();
                    if (selectedItem == null) return;

                    selectedItem.SubItems[e.SubItemIndex].Text = e.State == 1 ? "True" : "False";

                    lvProcesses.RedrawItems(selectedItem.Index, selectedItem.Index, false);
                }
            });
        }

        private void DisplayProcesses(object term = null)
        {
            Invoke(new Action(() =>
            {
                lvProcesses.Items.Clear();
                lvProcesses.Items.AddRange(_processInfos.Where(p =>
                term == null || p.Item.Text.ToLower().IndexOf(term.ToString().ToLower()) >= 0)
                .Where(p => chkShowActions.Checked && p.CategoryCode == 3
                    || chkShowBusinessProcessFlows.Checked && p.CategoryCode == 4
                    || chkShowBusinessRules.Checked && p.CategoryCode == 2
                    || chkShowModernFlows.Checked && p.CategoryCode == 5
                    || chkShowWorkflows.Checked && p.CategoryCode == 0
                )
                .Where(p => !chkShowOnlyDifference.Checked || chkShowOnlyDifference.Checked && p.HasDifference)
                .Select(pi => pi.Item)
                .ToArray());

                foreach (ListViewItem item in lvProcesses.Items)
                {
                    var grp = ((ProcessInfo)item.Tag).Category;

                    if (lvProcesses.Groups[grp] == null)
                    {
                        lvProcesses.Groups.Add(grp, grp);
                    }

                    item.Group = lvProcesses.Groups[grp];
                }
            }));
        }

        private void filterCriteriaChanged(object sender, EventArgs e)
        {
            filterThread?.Abort();
            filterThread = new Thread(DisplayProcesses);
            filterThread.Start(tstbFilter.Text);
        }

        private void LoadProcesses(bool fromSolution = false)
        {
            if (fromSolution)
            {
                var dialog = new SolutionPicker(Service);

                if (dialog.ShowDialog(this) == DialogResult.Cancel) return;
                solutions = dialog.SelectedSolutions;
            }

            ClearContent();

            WorkAsync(new WorkAsyncInfo
            {
                Message = "Loading processes...",
                Work = (bw, e) =>
                {
                    var pManager = new ProcessManager(Service);
                    _processInfos = pManager.LoadProcesses(solutions).Select(p => new ProcessInfo(p, ConnectionDetail, 1)).ToList();
                },
                PostWorkCallBack = e =>
                {
                    if (e.Error != null)
                    {
                        MessageBox.Show(this, $@"Error while loading processes: {e.Error.Message}", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    foreach (var pi in _processInfos)
                    {
                        var grp = pi.Category;

                        if (lvProcesses.Groups[grp] == null)
                        {
                            lvProcesses.Groups.Add(grp, grp);
                        }

                        pi.Item.Group = lvProcesses.Groups[grp];
                    }

                    DisplayProcesses();
                }
            });
        }

        private void LoadProcessesForAdditional(ConnectionDetail detail, int index)
        {
            WorkAsync(new WorkAsyncInfo
            {
                Message = "Loading processes...",
                Work = (bw, e) =>
                {
                    var pManager = new ProcessManager(detail.GetCrmServiceClient());
                    e.Result = pManager.LoadProcesses(solutions).Select(p => new ProcessInfo(p, detail, index)).ToList();
                },
                PostWorkCallBack = e =>
                {
                    if (e.Error != null)
                    {
                        MessageBox.Show(this, $@"Error while loading processes: {e.Error.Message}", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    var newItems = new List<ListViewItem>();

                    foreach (var pi in (List<ProcessInfo>)e.Result)
                    {
                        var existingPi = _processInfos.FirstOrDefault(p => p.Id.Equals(pi.Id));
                        if (existingPi != null)
                        {
                            if (existingPi.Item.SubItems.Count < index + 2)
                            {
                                existingPi.Item.SubItems.Add(new ListViewItem.ListViewSubItem());
                            }
                            existingPi.Item.SubItems[index + 1].Text = pi.IsEnabled.ToString();
                            existingPi.AddProcess(detail, pi);
                        }
                        else
                        {
                            var grp = pi.Category;

                            if (lvProcesses.Groups[grp] == null)
                            {
                                lvProcesses.Groups.Add(grp, grp);
                            }

                            pi.Item.Group = lvProcesses.Groups[grp];

                            newItems.Add(pi.Item);
                            _processInfos.Add(pi);
                        }
                    }

                    if (newItems.Count > 0)
                    {
                        lvProcesses.Items.AddRange(newItems.ToArray());
                    }

                    foreach (ListViewItem item in lvProcesses.Items.Cast<ListViewItem>().Where(i => i.SubItems.Count != lvProcesses.Columns.Count))
                    {
                        while (item.SubItems.Count != lvProcesses.Columns.Count)
                        {
                            item.SubItems.Add(new ListViewItem.ListViewSubItem());
                        }
                    }
                }
            });
        }

        private void lvProcesses_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            lvProcesses.Sorting = lvProcesses.Sorting == SortOrder.Ascending ? SortOrder.Descending : SortOrder.Ascending;
            lvProcesses.ListViewItemSorter = new ListViewItemComparer(e.Column, lvProcesses.Sorting);
        }

        private void lvProcesses_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void lvProcesses_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            if (e.ColumnIndex < 2)
            {
                e.DrawDefault = true;
                return;
            }

            if (e.Item.SubItems.Count > 2)
            {
                if (e.Item.Selected)
                {
                    e.Graphics.FillRectangle(SystemBrushes.Highlight, e.Bounds);
                }

                var content = e.SubItem.Text ?? "";
                switch (content)
                {
                    case "True":
                        content = "Enabled";
                        break;

                    case "False":
                        content = "Disabled";
                        break;

                    default:
                        content = string.Empty;
                        break;
                }

                e.Graphics.FillRectangle(new SolidBrush(content.Length == 0 ? Color.FromArgb(248, 215, 218) : Color.FromArgb(209, 231, 221)), e.Bounds);

                var size = e.Graphics.MeasureString(content, e.Item.ListView.Font, e.Bounds.Size, StringFormat.GenericDefault, out int _, out int _);

                e.Graphics.DrawString(content, e.Item.ListView.Font, new SolidBrush(content == "Enabled" ? Color.FromArgb(15, 81, 50) : Color.FromArgb(132, 32, 41)), e.Bounds.X + (e.Bounds.Width - size.Width) / 2, e.Bounds.Y);
            }
            else
            {
                e.DrawDefault = true;
            }
        }

        private void lvProcesses_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = lvProcesses.SelectedItems.Cast<ListViewItem>().FirstOrDefault();
            if (selectedItem == null) return;

            var record = ((ProcessInfo)selectedItem.Tag).Record;

            scMain.Panel2.Controls.Clear();

            var list = new List<Control>();

            list.Add(new System.Windows.Forms.Label
            {
                Text = record.GetAttributeValue<string>("name"),
                AutoSize = false,
                Dock = DockStyle.Top,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font(lvProcesses.Font, FontStyle.Bold)
            });

            for (int i = 2; i < selectedItem.SubItems.Count; i++)
            {
                var envName = lvProcesses.Columns[i].Text;
                var cd = AdditionalConnectionDetails.FirstOrDefault(c => c.ConnectionName == envName) ?? ConnectionDetail;

                if (!((ProcessInfo)selectedItem.Tag).Statuses.ContainsKey(cd)) continue;

                var suRecord = ((ProcessInfo)selectedItem.Tag).Statuses[cd];
                var ctrl = new ProcessStateControl(suRecord, cd, i) { Dock = DockStyle.Top, Height = 70 };
                ctrl.OnStateChangeRequested += Ctrl_OnStateChangeRequested;
                list.Add(ctrl);
            }

            list.Reverse();

            scMain.Panel2.Controls.AddRange(list.ToArray());
            scMain.Panel2Collapsed = false;
        }

        private void tsbAddFromOtherEnvs_Click(object sender, EventArgs e)
        {
            AddAdditionalOrganization();
        }

        private void tsddbLoad_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem == tsmiAllProcesses)
            {
                ExecuteMethod(LoadProcesses, false);
            }
            else
            {
                ExecuteMethod(LoadProcesses, true);
            }
        }
    }
}