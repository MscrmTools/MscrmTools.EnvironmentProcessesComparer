
namespace MscrmTools.EnvironmentProcessesComparer.UserControls
{
    partial class ProcessStateControl
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
            this.lblEnv = new System.Windows.Forms.Label();
            this.btnChangeState = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEnv
            // 
            this.lblEnv.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblEnv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnv.Location = new System.Drawing.Point(10, 10);
            this.lblEnv.Name = "lblEnv";
            this.lblEnv.Size = new System.Drawing.Size(535, 41);
            this.lblEnv.TabIndex = 2;
            this.lblEnv.Text = "[[Nom Env]]";
            this.lblEnv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnChangeState
            // 
            this.btnChangeState.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnChangeState.Location = new System.Drawing.Point(10, 51);
            this.btnChangeState.Name = "btnChangeState";
            this.btnChangeState.Size = new System.Drawing.Size(535, 101);
            this.btnChangeState.TabIndex = 3;
            this.btnChangeState.Text = "[[State Action]]";
            this.btnChangeState.UseVisualStyleBackColor = true;
            this.btnChangeState.Click += new System.EventHandler(this.btnChangeState_Click);
            // 
            // ProcessStateControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnChangeState);
            this.Controls.Add(this.lblEnv);
            this.Name = "ProcessStateControl";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(555, 162);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblEnv;
        private System.Windows.Forms.Button btnChangeState;
    }
}
