using McTools.Xrm.Connection;
using Microsoft.Xrm.Sdk;
using MscrmTools.EnvironmentProcessesComparer.AppCode;
using System;
using System.Windows.Forms;

namespace MscrmTools.EnvironmentProcessesComparer.UserControls
{
    public partial class ProcessStateControl : UserControl
    {
        private readonly ConnectionDetail _detail;

        private readonly int _index;

        private readonly Entity _record;

        public ProcessStateControl(Entity record, ConnectionDetail detail, int index)
        {
            _record = record;
            _detail = detail;
            _index = index;

            InitializeComponent();

            lblEnv.Text = detail.ConnectionName;
            SetButton();
        }

        public event EventHandler<StateChangeEventArgs> OnStateChangeRequested;

        internal void SetInvertedState()
        {
            SetButton();
        }

        private void btnChangeState_Click(object sender, EventArgs e)
        {
            OnStateChangeRequested?.Invoke(this, new StateChangeEventArgs
            {
                record = _record,
                ConnectionDetail = _detail,
                State = _record.GetAttributeValue<OptionSetValue>("statecode").Value == 0 ? 1 : 0,
                SubItemIndex = _index
            });
        }

        private void SetButton()
        {
            btnChangeState.Text = _record.GetAttributeValue<OptionSetValue>("statecode").Value == 0 ? "Enable" : "Disable";
        }
    }
}