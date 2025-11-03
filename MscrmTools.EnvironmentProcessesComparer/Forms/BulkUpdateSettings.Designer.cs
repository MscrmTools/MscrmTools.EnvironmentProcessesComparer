namespace MscrmTools.EnvironmentProcessesComparer.Forms
{
    partial class BulkUpdateSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.BtnOk = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdbUpdateStateDisabled = new System.Windows.Forms.RadioButton();
            this.rdbUpdateStateEnabled = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkUpdateTargetEnv = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pnlSettings = new System.Windows.Forms.Panel();
            this.lblSettings = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rdbAll = new System.Windows.Forms.RadioButton();
            this.pnlTarget = new System.Windows.Forms.Panel();
            this.chkListTarget = new System.Windows.Forms.CheckedListBox();
            this.lblTarget = new System.Windows.Forms.Label();
            this.pnlSource = new System.Windows.Forms.Panel();
            this.cbbSource = new System.Windows.Forms.ComboBox();
            this.lblSource = new System.Windows.Forms.Label();
            this.pnlBottom.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.pnlSettings.SuspendLayout();
            this.pnlTarget.SuspendLayout();
            this.pnlSource.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(611, 54);
            this.pnlTop.TabIndex = 0;
            this.pnlTop.Visible = false;
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.BtnOk);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 399);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Padding = new System.Windows.Forms.Padding(10);
            this.pnlBottom.Size = new System.Drawing.Size(611, 54);
            this.pnlBottom.TabIndex = 1;
            // 
            // BtnOk
            // 
            this.BtnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnOk.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnOk.Location = new System.Drawing.Point(481, 10);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(120, 34);
            this.BtnOk.TabIndex = 0;
            this.BtnOk.Text = "OK";
            this.BtnOk.UseVisualStyleBackColor = true;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.tabControlMain);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 54);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(10);
            this.pnlMain.Size = new System.Drawing.Size(611, 345);
            this.pnlMain.TabIndex = 2;
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPage1);
            this.tabControlMain.Controls.Add(this.tabPage2);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(10, 10);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(591, 325);
            this.tabControlMain.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(583, 296);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Update processes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rdbUpdateStateDisabled);
            this.panel2.Controls.Add(this.rdbUpdateStateEnabled);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 101);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(577, 98);
            this.panel2.TabIndex = 4;
            // 
            // rdbUpdateStateDisabled
            // 
            this.rdbUpdateStateDisabled.Dock = System.Windows.Forms.DockStyle.Top;
            this.rdbUpdateStateDisabled.Location = new System.Drawing.Point(124, 41);
            this.rdbUpdateStateDisabled.Name = "rdbUpdateStateDisabled";
            this.rdbUpdateStateDisabled.Size = new System.Drawing.Size(453, 41);
            this.rdbUpdateStateDisabled.TabIndex = 2;
            this.rdbUpdateStateDisabled.Text = "Disabled";
            this.rdbUpdateStateDisabled.UseVisualStyleBackColor = true;
            // 
            // rdbUpdateStateEnabled
            // 
            this.rdbUpdateStateEnabled.Checked = true;
            this.rdbUpdateStateEnabled.Dock = System.Windows.Forms.DockStyle.Top;
            this.rdbUpdateStateEnabled.Location = new System.Drawing.Point(124, 0);
            this.rdbUpdateStateEnabled.Name = "rdbUpdateStateEnabled";
            this.rdbUpdateStateEnabled.Size = new System.Drawing.Size(453, 41);
            this.rdbUpdateStateEnabled.TabIndex = 1;
            this.rdbUpdateStateEnabled.TabStop = true;
            this.rdbUpdateStateEnabled.Text = "Enabled";
            this.rdbUpdateStateEnabled.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 98);
            this.label2.TabIndex = 0;
            this.label2.Text = "State";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkUpdateTargetEnv);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(577, 98);
            this.panel1.TabIndex = 3;
            // 
            // chkUpdateTargetEnv
            // 
            this.chkUpdateTargetEnv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkUpdateTargetEnv.FormattingEnabled = true;
            this.chkUpdateTargetEnv.Location = new System.Drawing.Point(124, 0);
            this.chkUpdateTargetEnv.Name = "chkUpdateTargetEnv";
            this.chkUpdateTargetEnv.Size = new System.Drawing.Size(453, 98);
            this.chkUpdateTargetEnv.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 98);
            this.label1.TabIndex = 0;
            this.label1.Text = "Target environment(s)";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pnlSettings);
            this.tabPage2.Controls.Add(this.pnlTarget);
            this.tabPage2.Controls.Add(this.pnlSource);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(583, 296);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Apply state across environments";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pnlSettings
            // 
            this.pnlSettings.Controls.Add(this.lblSettings);
            this.pnlSettings.Controls.Add(this.radioButton1);
            this.pnlSettings.Controls.Add(this.rdbAll);
            this.pnlSettings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSettings.Location = new System.Drawing.Point(3, 229);
            this.pnlSettings.Name = "pnlSettings";
            this.pnlSettings.Size = new System.Drawing.Size(577, 64);
            this.pnlSettings.TabIndex = 3;
            // 
            // lblSettings
            // 
            this.lblSettings.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblSettings.Location = new System.Drawing.Point(0, 0);
            this.lblSettings.Name = "lblSettings";
            this.lblSettings.Size = new System.Drawing.Size(124, 64);
            this.lblSettings.TabIndex = 2;
            this.lblSettings.Text = "Process";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(124, 32);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(291, 20);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Only checked processes with different states";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // rdbAll
            // 
            this.rdbAll.AutoSize = true;
            this.rdbAll.Checked = true;
            this.rdbAll.Location = new System.Drawing.Point(124, 6);
            this.rdbAll.Name = "rdbAll";
            this.rdbAll.Size = new System.Drawing.Size(224, 20);
            this.rdbAll.TabIndex = 0;
            this.rdbAll.TabStop = true;
            this.rdbAll.Text = "All processes with different states";
            this.rdbAll.UseVisualStyleBackColor = true;
            // 
            // pnlTarget
            // 
            this.pnlTarget.Controls.Add(this.chkListTarget);
            this.pnlTarget.Controls.Add(this.lblTarget);
            this.pnlTarget.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTarget.Location = new System.Drawing.Point(3, 55);
            this.pnlTarget.Name = "pnlTarget";
            this.pnlTarget.Size = new System.Drawing.Size(577, 98);
            this.pnlTarget.TabIndex = 2;
            // 
            // chkListTarget
            // 
            this.chkListTarget.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkListTarget.FormattingEnabled = true;
            this.chkListTarget.Location = new System.Drawing.Point(124, 0);
            this.chkListTarget.Name = "chkListTarget";
            this.chkListTarget.Size = new System.Drawing.Size(453, 98);
            this.chkListTarget.TabIndex = 1;
            // 
            // lblTarget
            // 
            this.lblTarget.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTarget.Location = new System.Drawing.Point(0, 0);
            this.lblTarget.Name = "lblTarget";
            this.lblTarget.Size = new System.Drawing.Size(124, 98);
            this.lblTarget.TabIndex = 0;
            this.lblTarget.Text = "To";
            // 
            // pnlSource
            // 
            this.pnlSource.Controls.Add(this.cbbSource);
            this.pnlSource.Controls.Add(this.lblSource);
            this.pnlSource.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSource.Location = new System.Drawing.Point(3, 3);
            this.pnlSource.Name = "pnlSource";
            this.pnlSource.Size = new System.Drawing.Size(577, 52);
            this.pnlSource.TabIndex = 1;
            // 
            // cbbSource
            // 
            this.cbbSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbbSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSource.FormattingEnabled = true;
            this.cbbSource.Location = new System.Drawing.Point(124, 0);
            this.cbbSource.Name = "cbbSource";
            this.cbbSource.Size = new System.Drawing.Size(453, 24);
            this.cbbSource.TabIndex = 1;
            this.cbbSource.SelectedIndexChanged += new System.EventHandler(this.cbbSource_SelectedIndexChanged);
            // 
            // lblSource
            // 
            this.lblSource.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblSource.Location = new System.Drawing.Point(0, 0);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(124, 52);
            this.lblSource.TabIndex = 0;
            this.lblSource.Text = "From";
            // 
            // BulkUpdateSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 453);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BulkUpdateSettings";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bulk Update Settings";
            this.pnlBottom.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.tabControlMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.pnlSettings.ResumeLayout(false);
            this.pnlSettings.PerformLayout();
            this.pnlTarget.ResumeLayout(false);
            this.pnlSource.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel pnlSource;
        private System.Windows.Forms.ComboBox cbbSource;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.Panel pnlTarget;
        private System.Windows.Forms.CheckedListBox chkListTarget;
        private System.Windows.Forms.Label lblTarget;
        private System.Windows.Forms.Panel pnlSettings;
        private System.Windows.Forms.Label lblSettings;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton rdbAll;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rdbUpdateStateDisabled;
        private System.Windows.Forms.RadioButton rdbUpdateStateEnabled;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckedListBox chkUpdateTargetEnv;
        private System.Windows.Forms.Label label1;
    }
}