using McTools.Xrm.Connection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace MscrmTools.EnvironmentProcessesComparer.Forms
{
    public partial class BulkUpdateSettings : Form
    {
        private List<ConnectionDetail> connections;

        public BulkUpdateSettings(ConnectionDetail current, List<ConnectionDetail> additionalConnections)
        {
            InitializeComponent();

            connections = new List<ConnectionDetail>();
            connections.Add(current);
            connections.AddRange(additionalConnections);

            cbbSource.Items.AddRange(connections.ToArray());
            cbbSource.SelectedIndex = 0;

            chkUpdateTargetEnv.Items.AddRange(connections.ToArray());

            if (additionalConnections.Count == 0)
            {
                tabControlMain.TabPages.Remove(tabPage2);
            }
        }

        public bool IsUpdateAcrossEnvs => tabControlMain.SelectedTab == tabPage2;
        public bool OnlyCheckedProcesses => radioButton1.Checked;
        public bool SetToEnabled => rdbUpdateStateEnabled.Checked;
        public ConnectionDetail Source => (ConnectionDetail)cbbSource.SelectedItem;
        public List<ConnectionDetail> Targets => chkUpdateTargetEnv.CheckedItems.Cast<ConnectionDetail>().ToList();
        public List<ConnectionDetail> TargetsAcrossEnvs => chkListTarget.CheckedItems.Cast<ConnectionDetail>().ToList();

        private void cbbSource_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbSource.SelectedItem != null)
            {
                var selected = (ConnectionDetail)cbbSource.SelectedItem;

                chkListTarget.Items.Clear();
                chkListTarget.Items.AddRange(connections.Where(c => c != selected).ToArray());
            }
        }
    }
}