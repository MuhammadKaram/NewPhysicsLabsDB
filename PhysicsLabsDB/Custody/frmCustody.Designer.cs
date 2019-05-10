namespace PhysicsLabsDB.Custody
{
    partial class frmCustody
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustody));
			this.lbxEmployee = new System.Windows.Forms.ListBox();
			this.txtNameEmplyee = new System.Windows.Forms.TextBox();
			this.grbAddEmployee = new System.Windows.Forms.GroupBox();
			this.btnAddEmploee = new System.Windows.Forms.Button();
			this.btnDeleteEmployee = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.grbAddEmployee.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lbxEmployee
			// 
			this.lbxEmployee.FormattingEnabled = true;
			this.lbxEmployee.ItemHeight = 19;
			this.lbxEmployee.Location = new System.Drawing.Point(71, 34);
			this.lbxEmployee.Name = "lbxEmployee";
			this.lbxEmployee.Size = new System.Drawing.Size(270, 308);
			this.lbxEmployee.TabIndex = 1;
			// 
			// txtNameEmplyee
			// 
			this.txtNameEmplyee.Location = new System.Drawing.Point(71, 39);
			this.txtNameEmplyee.Name = "txtNameEmplyee";
			this.txtNameEmplyee.Size = new System.Drawing.Size(270, 26);
			this.txtNameEmplyee.TabIndex = 3;
			this.txtNameEmplyee.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNameEmplyee_KeyDown);
			// 
			// grbAddEmployee
			// 
			this.grbAddEmployee.Controls.Add(this.txtNameEmplyee);
			this.grbAddEmployee.Controls.Add(this.btnAddEmploee);
			this.grbAddEmployee.Location = new System.Drawing.Point(21, 29);
			this.grbAddEmployee.Name = "grbAddEmployee";
			this.grbAddEmployee.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.grbAddEmployee.Size = new System.Drawing.Size(364, 98);
			this.grbAddEmployee.TabIndex = 6;
			this.grbAddEmployee.TabStop = false;
			this.grbAddEmployee.Text = "إضافة متعهد";
			// 
			// btnAddEmploee
			// 
			this.btnAddEmploee.BackgroundImage = global::PhysicsLabsDB.Properties.Resources.iconfinder_sign_add_299068;
			this.btnAddEmploee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnAddEmploee.Location = new System.Drawing.Point(23, 39);
			this.btnAddEmploee.Name = "btnAddEmploee";
			this.btnAddEmploee.Size = new System.Drawing.Size(28, 26);
			this.btnAddEmploee.TabIndex = 4;
			this.btnAddEmploee.UseVisualStyleBackColor = true;
			this.btnAddEmploee.Click += new System.EventHandler(this.btnAddEmploee_Click);
			// 
			// btnDeleteEmployee
			// 
			this.btnDeleteEmployee.BackgroundImage = global::PhysicsLabsDB.Properties.Resources.iconfinder_error_1646012;
			this.btnDeleteEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnDeleteEmployee.Location = new System.Drawing.Point(23, 34);
			this.btnDeleteEmployee.Name = "btnDeleteEmployee";
			this.btnDeleteEmployee.Size = new System.Drawing.Size(28, 30);
			this.btnDeleteEmployee.TabIndex = 5;
			this.btnDeleteEmployee.UseVisualStyleBackColor = true;
			this.btnDeleteEmployee.Click += new System.EventHandler(this.btnDeleteEmployee_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnDeleteEmployee);
			this.groupBox1.Controls.Add(this.lbxEmployee);
			this.groupBox1.Font = new System.Drawing.Font("Arial", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(21, 170);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.groupBox1.Size = new System.Drawing.Size(364, 361);
			this.groupBox1.TabIndex = 7;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "أصحاب العهد الحالية";
			// 
			// frmCustody
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(417, 561);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.grbAddEmployee);
			this.Font = new System.Drawing.Font("Arial", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(433, 600);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(433, 600);
			this.Name = "frmCustody";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "أصحاب العهد";
			this.Load += new System.EventHandler(this.frmCustody_Load);
			this.grbAddEmployee.ResumeLayout(false);
			this.grbAddEmployee.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

        }

		#endregion
		private System.Windows.Forms.ListBox lbxEmployee;
		private System.Windows.Forms.TextBox txtNameEmplyee;
		private System.Windows.Forms.Button btnAddEmploee;
		private System.Windows.Forms.Button btnDeleteEmployee;
		private System.Windows.Forms.GroupBox grbAddEmployee;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}