namespace PhysicsLabsDB.Experiments
{
    partial class frmAddExperiments
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
            this.txtExperiment = new System.Windows.Forms.TextBox();
            this.btnAddExperiment = new System.Windows.Forms.Button();
            this.lblExperimnet = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtExperiment
            // 
            this.txtExperiment.Location = new System.Drawing.Point(69, 46);
            this.txtExperiment.Name = "txtExperiment";
            this.txtExperiment.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtExperiment.Size = new System.Drawing.Size(340, 26);
            this.txtExperiment.TabIndex = 0;
            this.txtExperiment.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtExperiment_KeyDown);
            // 
            // btnAddExperiment
            // 
            this.btnAddExperiment.BackgroundImage = global::PhysicsLabsDB.Properties.Resources.iconfinder_sign_add_299068;
            this.btnAddExperiment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddExperiment.Location = new System.Drawing.Point(23, 46);
            this.btnAddExperiment.Name = "btnAddExperiment";
            this.btnAddExperiment.Size = new System.Drawing.Size(28, 26);
            this.btnAddExperiment.TabIndex = 5;
            this.btnAddExperiment.UseVisualStyleBackColor = true;
            this.btnAddExperiment.Click += new System.EventHandler(this.btnAddExperiment_Click);
            // 
            // lblExperimnet
            // 
            this.lblExperimnet.AutoSize = true;
            this.lblExperimnet.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExperimnet.Location = new System.Drawing.Point(338, 24);
            this.lblExperimnet.Name = "lblExperimnet";
            this.lblExperimnet.Size = new System.Drawing.Size(71, 19);
            this.lblExperimnet.TabIndex = 6;
            this.lblExperimnet.Text = "اسم التجربة";
            // 
            // frmAddExperiments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 108);
            this.Controls.Add(this.lblExperimnet);
            this.Controls.Add(this.btnAddExperiment);
            this.Controls.Add(this.txtExperiment);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(455, 147);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(455, 147);
            this.Name = "frmAddExperiments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إضافة تجربة";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtExperiment;
        private System.Windows.Forms.Button btnAddExperiment;
        private System.Windows.Forms.Label lblExperimnet;
    }
}