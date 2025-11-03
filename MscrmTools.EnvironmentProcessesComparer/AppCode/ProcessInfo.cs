using McTools.Xrm.Connection;
using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MscrmTools.EnvironmentProcessesComparer.AppCode
{
    public class ProcessInfo
    {
        private readonly Entity _process;
        private readonly Dictionary<ConnectionDetail, Entity> _statuses;
        private ListViewItem _item;

        public ProcessInfo(Entity process, ConnectionDetail detail, int index)
        {
            _process = process;
            _statuses = new Dictionary<ConnectionDetail, Entity>();
            _statuses.Add(detail, process);

            _item = new ListViewItem(process.GetAttributeValue<string>("name"))
            {
                Tag = this,
                SubItems =
                {
                    new ListViewItem.ListViewSubItem(){Text=_process.GetAttributeValue<string>("primaryentity") }
                }
            };

            if (_item.SubItems.Count < index + 2)
            {
                for (var i = _item.SubItems.Count; i < index + 2; i++)
                {
                    _item.SubItems.Add(new ListViewItem.ListViewSubItem());
                }
            }

            _item.SubItems[index + 1].Text = IsEnabled.ToString();
        }

        public string Category => _process.FormattedValues.Contains("category") ? _process.FormattedValues["category"] : "unknown";
        public int CategoryCode => _process.GetAttributeValue<OptionSetValue>("category")?.Value ?? -1;
        public bool HasDifference => !(_statuses.Values.All(s => s.GetAttributeValue<OptionSetValue>("statecode").Value == 0) || _statuses.Values.All(s => s.GetAttributeValue<OptionSetValue>("statecode").Value == 1)) || _statuses.Count < _item.SubItems.Count - 2;
        public Guid Id => _process.Id;
        public bool IsEnabled => _process.GetAttributeValue<OptionSetValue>("statecode").Value == 1;
        public ListViewItem Item => _item;
        public string Name => _process.GetAttributeValue<string>("name");
        public Entity Record => _process;

        public Dictionary<ConnectionDetail, Entity> Statuses => _statuses;

        public void AddProcess(ConnectionDetail detail, ProcessInfo pi)
        {
            _statuses.Add(detail, pi.Record);
        }

        internal void UpdateListViewItem()
        {
            for(int i=2; i<Item.ListView.Columns.Count;i++)
            {
                var cd = (ConnectionDetail)Item.ListView.Columns[i].Tag;

                Item.SubItems[i].Text = Statuses[cd].GetAttributeValue<OptionSetValue>("statecode").Value == 1 ? "True" : "False";
            }
        }
    }
}