namespace PhysicsLabsDB.Custody
{
	partial class frmTransferCustody
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTransferCustody));
			this.gbxTransferCustody = new System.Windows.Forms.GroupBox();
			this.lblLab = new System.Windows.Forms.Label();
			this.lblCurrentCustody = new System.Windows.Forms.Label();
			this.lblNewCustody = new System.Windows.Forms.Label();
			this.cmbLab = new System.Windows.Forms.ComboBox();
			this.cmbCurrentCustody = new System.Windows.Forms.ComboBox();
			this.cmbNewCustody = new System.Windows.Forms.ComboBox();
			this.btnTransfer = new System.Windows.Forms.Button();
			this.gbxTransferCustody.SuspendLayout();
			this.SuspendLayout();
			// 
			// gbxTransferCustody
			// 
			this.gbxTransferCustody.Controls.Add(this.btnTransfer);
			this.gbxTransferCustody.Controls.Add(this.cmbNewCustody);
			this.gbxTransferCustody.Controls.Add(this.cmbCurrentCustody);
			this.gbxTransferCustody.Controls.Add(this.cmbLab);
			this.gbxTransferCustody.Controls.Add(this.lblNewCustody);
			this.gbxTransferCustody.Controls.Add(this.lblCurrentCustody);
			this.gbxTransferCustody.Controls.Add(this.lblLab);
			this.gbxTransferCustody.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbxTransferCustody.Location = new System.Drawing.Point(25, 29);
			this.gbxTransferCustody.Name = "gbxTransferCustody";
			this.gbxTransferCustody.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.gbxTransferCustody.Size = new System.Drawing.Size(437, 287);
			this.gbxTransferCustody.TabIndex = 0;
			this.gbxTransferCustody.TabStop = false;
			this.gbxTransferCustody.Text = "نقل العهدة";
			// 
			// lblLab
			// 
			this.lblLab.AutoSize = true;
			this.lblLab.Font = new System.Drawing.Font("Arial", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLab.Location = new System.Drawing.Point(375, 57);
			this.lblLab.Name = "lblLab";
			this.lblLab.Size = new System.Drawing.Size(45, 19);
			this.lblLab.TabIndex = 0;
			this.lblLab.Text = "المعمل";
			// 
			// lblCurrentCustody
			// 
			this.lblCurrentCustody.AutoSize = true;
			this.lblCurrentCustody.Font = new System.Drawing.Font("Arial", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCurrentCustody.Location = new System.Drawing.Point(295, 111);
			this.lblCurrentCustody.Name = "lblCurrentCustody";
			this.lblCurrentCustody.Size = new System.Drawing.Size(125, 19);
			this.lblCurrentCustody.TabIndex = 0;
			this.lblCurrentCustody.Text = "صاحب العهدة الحالي";
			// 
			// lblNewCustody
			// 
			this.lblNewCustody.AutoSize = true;
			this.lblNewCustody.Font = new System.Drawing.Font("Arial", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNewCustody.Location = new System.Drawing.Point(296, 171);
			this.lblNewCustody.Name = "lblNewCustody";
			this.lblNewCustody.Size = new System.Drawing.Size(124, 19);
			this.lblNewCustody.TabIndex = 0;
			this.lblNewCustody.Text = "صاحب العهدة الجديد";
			// 
			// cmbLab
			// 
			this.cmbLab.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbLab.FormattingEnabled = true;
			this.cmbLab.Location = new System.Drawing.Point(16, 51);
			this.cmbLab.Name = "cmbLab";
			this.cmbLab.Size = new System.Drawing.Size(261, 30);
			this.cmbLab.TabIndex = 1;
			this.cmbLab.SelectedIndexChanged += new System.EventHandler(this.cmbLab_SelectedIndexChanged);
			// 
			// cmbCurrentCustody
			// 
			this.cmbCurrentCustody.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbCurrentCustody.FormattingEnabled = true;
			this.cmbCurrentCustody.Location = new System.Drawing.Point(16, 105);
			this.cmbCurrentCustody.Name = "cmbCurrentCustody";
			this.cmbCurrentCustody.Size = new System.Drawing.Size(261, 30);
			this.cmbCurrentCustody.TabIndex = 1;
			// 
			// cmbNewCustody
			// 
			this.cmbNewCustody.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbNewCustody.FormattingEnabled = true;
			this.cmbNewCustody.Location = new System.Drawing.Point(16, 165);
			this.cmbNewCustody.Name = "cmbNewCustody";
			this.cmbNewCustody.Size = new System.Drawing.Size(261, 30);
			this.cmbNewCustody.TabIndex = 1;
			// 
			// btnTransfer
			// 
			this.btnTransfer.Location = new System.Drawing.Point(16, 232);
			this.btnTransfer.Name = "btnTransfer";
			this.btnTransfer.Size = new System.Drawing.Size(400, 35);
			this.btnTransfer.TabIndex = 2;
			this.btnTransfer.Text = "نقل";
			this.btnTransfer.UseVisualStyleBackColor = true;
			this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
			// 
			// frmTransferCustody
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(492, 362);
			this.Controls.Add(this.gbxTransferCustody);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(508, 401);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(508, 401);
			this.Name = "frmTransferCustody";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "نقل العهدة";
			this.Load += new System.EventHandler(this.frmTransferCustody_Load);
			this.gbxTransferCustody.ResumeLayout(false);
			this.gbxTransferCustody.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox gbxTransferCustody;
		private System.Windows.Forms.Label lblNewCustody;
		private System.Windows.Forms.Label lblCurrentCustody;
		private System.Windows.Forms.Label lblLab;
		private System.Windows.Forms.ComboBox cmbNewCustody;
		private System.Windows.Forms.ComboBox cmbCurrentCustody;
		private System.Windows.Forms.ComboBox cmbLab;
		private System.Windows.Forms.Button btnTransfer;
	}
}