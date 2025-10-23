
namespace MscrmTools.EnvironmentProcessesComparer
{
    partial class MyPluginControl
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tslFilter = new System.Windows.Forms.ToolStripLabel();
            this.tstbFilter = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.chkShowOnlyDifference = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkShowBusinessProcessFlows = new System.Windows.Forms.CheckBox();
            this.chkShowActions = new System.Windows.Forms.CheckBox();
            this.chkShowModernFlows = new System.Windows.Forms.CheckBox();
            this.chkShowWorkflows = new System.Windows.Forms.CheckBox();
            this.chkShowBusinessRules = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.lvProcesses = new System.Windows.Forms.ListView();
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chEntity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chEnvironmentState = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tsddbLoad = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmiAllProcesses = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiProcessesFromSolution = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbAddFromOtherEnvs = new System.Windows.Forms.ToolStripButton();
            this.tsbExportToExcel = new System.Windows.Forms.ToolStripButton();
            this.tsMain.SuspendLayout();
            this.pnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsMain
            // 
            this.tsMain.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsddbLoad,
            this.tsbAddFromOtherEnvs,
            this.toolStripSeparator1,
            this.tslFilter,
            this.tstbFilter,
            this.toolStripSeparator2,
            this.tsbExportToExcel});
            this.tsMain.Location = new System.Drawing.Point(0, 0);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(1418, 39);
            this.tsMain.TabIndex = 4;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // tslFilter
            // 
            this.tslFilter.Name = "tslFilter";
            this.tslFilter.Size = new System.Drawing.Size(42, 36);
            this.tslFilter.Text = "Filter";
            // 
            // tstbFilter
            // 
            this.tstbFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tstbFilter.Name = "tstbFilter";
            this.tstbFilter.Size = new System.Drawing.Size(267, 39);
            this.tstbFilter.TextChanged += new System.EventHandler(this.filterCriteriaChanged);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // pnlFilter
            // 
            this.pnlFilter.Controls.Add(this.chkShowOnlyDifference);
            this.pnlFilter.Controls.Add(this.label2);
            this.pnlFilter.Controls.Add(this.chkShowBusinessProcessFlows);
            this.pnlFilter.Controls.Add(this.chkShowActions);
            this.pnlFilter.Controls.Add(this.chkShowModernFlows);
            this.pnlFilter.Controls.Add(this.chkShowWorkflows);
            this.pnlFilter.Controls.Add(this.chkShowBusinessRules);
            this.pnlFilter.Controls.Add(this.label1);
            this.pnlFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilter.Location = new System.Drawing.Point(0, 39);
            this.pnlFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new System.Drawing.Size(1418, 53);
            this.pnlFilter.TabIndex = 6;
            // 
            // chkShowOnlyDifference
            // 
            this.chkShowOnlyDifference.AutoSize = true;
            this.chkShowOnlyDifference.Dock = System.Windows.Forms.DockStyle.Left;
            this.chkShowOnlyDifference.Enabled = false;
            this.chkShowOnlyDifference.Location = new System.Drawing.Point(595, 0);
            this.chkShowOnlyDifference.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkShowOnlyDifference.Name = "chkShowOnlyDifference";
            this.chkShowOnlyDifference.Size = new System.Drawing.Size(249, 53);
            this.chkShowOnlyDifference.TabIndex = 12;
            this.chkShowOnlyDifference.Text = "Show only process with different state";
            this.chkShowOnlyDifference.UseVisualStyleBackColor = true;
            this.chkShowOnlyDifference.Click += new System.EventHandler(this.filterCriteriaChanged);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Location = new System.Drawing.Point(583, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 53);
            this.label2.TabIndex = 11;
            this.label2.Text = "| ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkShowBusinessProcessFlows
            // 
            this.chkShowBusinessProcessFlows.AutoSize = true;
            this.chkShowBusinessProcessFlows.Checked = true;
            this.chkShowBusinessProcessFlows.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowBusinessProcessFlows.Dock = System.Windows.Forms.DockStyle.Left;
            this.chkShowBusinessProcessFlows.Location = new System.Drawing.Point(408, 0);
            this.chkShowBusinessProcessFlows.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkShowBusinessProcessFlows.Name = "chkShowBusinessProcessFlows";
            this.chkShowBusinessProcessFlows.Size = new System.Drawing.Size(175, 53);
            this.chkShowBusinessProcessFlows.TabIndex = 10;
            this.chkShowBusinessProcessFlows.Text = "Business Process Flows";
            this.chkShowBusinessProcessFlows.UseVisualStyleBackColor = true;
            this.chkShowBusinessProcessFlows.Click += new System.EventHandler(this.filterCriteriaChanged);
            // 
            // chkShowActions
            // 
            this.chkShowActions.AutoSize = true;
            this.chkShowActions.Checked = true;
            this.chkShowActions.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowActions.Dock = System.Windows.Forms.DockStyle.Left;
            this.chkShowActions.Location = new System.Drawing.Point(335, 0);
            this.chkShowActions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkShowActions.Name = "chkShowActions";
            this.chkShowActions.Size = new System.Drawing.Size(73, 53);
            this.chkShowActions.TabIndex = 9;
            this.chkShowActions.Text = "Actions";
            this.chkShowActions.UseVisualStyleBackColor = true;
            this.chkShowActions.Click += new System.EventHandler(this.filterCriteriaChanged);
            // 
            // chkShowModernFlows
            // 
            this.chkShowModernFlows.AutoSize = true;
            this.chkShowModernFlows.Checked = true;
            this.chkShowModernFlows.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowModernFlows.Dock = System.Windows.Forms.DockStyle.Left;
            this.chkShowModernFlows.Location = new System.Drawing.Point(271, 0);
            this.chkShowModernFlows.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkShowModernFlows.Name = "chkShowModernFlows";
            this.chkShowModernFlows.Size = new System.Drawing.Size(64, 53);
            this.chkShowModernFlows.TabIndex = 8;
            this.chkShowModernFlows.Text = "Flows";
            this.chkShowModernFlows.UseVisualStyleBackColor = true;
            this.chkShowModernFlows.Click += new System.EventHandler(this.filterCriteriaChanged);
            // 
            // chkShowWorkflows
            // 
            this.chkShowWorkflows.AutoSize = true;
            this.chkShowWorkflows.Checked = true;
            this.chkShowWorkflows.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowWorkflows.Dock = System.Windows.Forms.DockStyle.Left;
            this.chkShowWorkflows.Location = new System.Drawing.Point(180, 0);
            this.chkShowWorkflows.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkShowWorkflows.Name = "chkShowWorkflows";
            this.chkShowWorkflows.Size = new System.Drawing.Size(91, 53);
            this.chkShowWorkflows.TabIndex = 7;
            this.chkShowWorkflows.Text = "Workflows";
            this.chkShowWorkflows.UseVisualStyleBackColor = true;
            this.chkShowWorkflows.Click += new System.EventHandler(this.filterCriteriaChanged);
            // 
            // chkShowBusinessRules
            // 
            this.chkShowBusinessRules.AutoSize = true;
            this.chkShowBusinessRules.Checked = true;
            this.chkShowBusinessRules.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowBusinessRules.Dock = System.Windows.Forms.DockStyle.Left;
            this.chkShowBusinessRules.Location = new System.Drawing.Point(58, 0);
            this.chkShowBusinessRules.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkShowBusinessRules.Name = "chkShowBusinessRules";
            this.chkShowBusinessRules.Size = new System.Drawing.Size(122, 53);
            this.chkShowBusinessRules.TabIndex = 6;
            this.chkShowBusinessRules.Text = "Business Rules";
            this.chkShowBusinessRules.UseVisualStyleBackColor = true;
            this.chkShowBusinessRules.Click += new System.EventHandler(this.filterCriteriaChanged);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 53);
            this.label1.TabIndex = 5;
            this.label1.Text = "Type : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // scMain
            // 
            this.scMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.scMain.Location = new System.Drawing.Point(0, 92);
            this.scMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.scMain.Name = "scMain";
            // 
            // scMain.Panel1
            // 
            this.scMain.Panel1.Controls.Add(this.lvProcesses);
            this.scMain.Panel2Collapsed = true;
            this.scMain.Size = new System.Drawing.Size(1418, 598);
            this.scMain.SplitterDistance = 900;
            this.scMain.TabIndex = 8;
            // 
            // lvProcesses
            // 
            this.lvProcesses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.chEntity,
            this.chEnvironmentState});
            this.lvProcesses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvProcesses.FullRowSelect = true;
            this.lvProcesses.HideSelection = false;
            this.lvProcesses.Location = new System.Drawing.Point(0, 0);
            this.lvProcesses.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvProcesses.MultiSelect = false;
            this.lvProcesses.Name = "lvProcesses";
            this.lvProcesses.OwnerDraw = true;
            this.lvProcesses.Size = new System.Drawing.Size(1418, 598);
            this.lvProcesses.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvProcesses.TabIndex = 9;
            this.lvProcesses.UseCompatibleStateImageBehavior = false;
            this.lvProcesses.View = System.Windows.Forms.View.Details;
            this.lvProcesses.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.lvProcesses_DrawColumnHeader);
            this.lvProcesses.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.lvProcesses_DrawSubItem);
            this.lvProcesses.SelectedIndexChanged += new System.EventHandler(this.lvProcesses_SelectedIndexChanged);
            // 
            // chName
            // 
            this.chName.Text = "Name";
            this.chName.Width = 300;
            // 
            // chEntity
            // 
            this.chEntity.Text = "Entity";
            this.chEntity.Width = 100;
            // 
            // chEnvironmentState
            // 
            this.chEnvironmentState.Text = "State";
            this.chEnvironmentState.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chEnvironmentState.Width = 100;
            // 
            // tsddbLoad
            // 
            this.tsddbLoad.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAllProcesses,
            this.tsmiProcessesFromSolution});
            this.tsddbLoad.Image = global::MscrmTools.EnvironmentProcessesComparer.Properties.Resources.Dataverse_32x32;
            this.tsddbLoad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddbLoad.Name = "tsddbLoad";
            this.tsddbLoad.Size = new System.Drawing.Size(155, 36);
            this.tsddbLoad.Text = "Load Processes";
            this.tsddbLoad.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tsddbLoad_DropDownItemClicked);
            // 
            // tsmiAllProcesses
            // 
            this.tsmiAllProcesses.Image = global::MscrmTools.EnvironmentProcessesComparer.Properties.Resources.Dataverse_32x32;
            this.tsmiAllProcesses.Name = "tsmiAllProcesses";
            this.tsmiAllProcesses.Size = new System.Drawing.Size(276, 38);
            this.tsmiAllProcesses.Text = "All Processes";
            // 
            // tsmiProcessesFromSolution
            // 
            this.tsmiProcessesFromSolution.Image = global::MscrmTools.EnvironmentProcessesComparer.Properties.Resources.Dataverse_32x32;
            this.tsmiProcessesFromSolution.Name = "tsmiProcessesFromSolution";
            this.tsmiProcessesFromSolution.Size = new System.Drawing.Size(276, 38);
            this.tsmiProcessesFromSolution.Text = "Processes from solution(s)";
            // 
            // tsbAddFromOtherEnvs
            // 
            this.tsbAddFromOtherEnvs.Enabled = false;
            this.tsbAddFromOtherEnvs.Image = global::MscrmTools.EnvironmentProcessesComparer.Properties.Resources.Dataverse_32x32;
            this.tsbAddFromOtherEnvs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddFromOtherEnvs.Name = "tsbAddFromOtherEnvs";
            this.tsbAddFromOtherEnvs.Size = new System.Drawing.Size(318, 36);
            this.tsbAddFromOtherEnvs.Text = "Add Processes from another environment";
            this.tsbAddFromOtherEnvs.Click += new System.EventHandler(this.tsbAddFromOtherEnvs_Click);
            // 
            // tsbExportToExcel
            // 
            this.tsbExportToExcel.Image = global::MscrmTools.EnvironmentProcessesComparer.Properties.Resources.excel1;
            this.tsbExportToExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExportToExcel.Name = "tsbExportToExcel";
            this.tsbExportToExcel.Size = new System.Drawing.Size(146, 36);
            this.tsbExportToExcel.Text = "Export To Excel";
            this.tsbExportToExcel.Click += new System.EventHandler(this.tsbExportToExcel_Click);
            // 
            // MyPluginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.scMain);
            this.Controls.Add(this.pnlFilter);
            this.Controls.Add(this.tsMain);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MyPluginControl";
            this.Size = new System.Drawing.Size(1418, 690);
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            this.scMain.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip tsMain;
        private System.Windows.Forms.ToolStripButton tsbAddFromOtherEnvs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel tslFilter;
        private System.Windows.Forms.ToolStripTextBox tstbFilter;
        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.CheckBox chkShowOnlyDifference;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkShowBusinessProcessFlows;
        private System.Windows.Forms.CheckBox chkShowActions;
        private System.Windows.Forms.CheckBox chkShowModernFlows;
        private System.Windows.Forms.CheckBox chkShowWorkflows;
        private System.Windows.Forms.CheckBox chkShowBusinessRules;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripDropDownButton tsddbLoad;
        private System.Windows.Forms.ToolStripMenuItem tsmiAllProcesses;
        private System.Windows.Forms.ToolStripMenuItem tsmiProcessesFromSolution;
        private System.Windows.Forms.SplitContainer scMain;
        private System.Windows.Forms.ListView lvProcesses;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chEntity;
        private System.Windows.Forms.ColumnHeader chEnvironmentState;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbExportToExcel;
    }
}
