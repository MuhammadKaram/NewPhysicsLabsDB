namespace PhysicsLabsDB.Devices
{
	partial class DevicesWithoutExperiment
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DevicesWithoutExperiment));
			this.cmbLabs = new System.Windows.Forms.ComboBox();
			this.lblLabs = new System.Windows.Forms.Label();
			this.lstWork = new System.Windows.Forms.ListBox();
			this.lblWork = new System.Windows.Forms.Label();
			this.lstNotWork = new System.Windows.Forms.ListBox();
			this.lblNotWork = new System.Windows.Forms.Label();
			this.lstTakhin = new System.Windows.Forms.ListBox();
			this.lblTakhin = new System.Windows.Forms.Label();
			this.btnFinishInventory = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// cmbLabs
			// 
			this.cmbLabs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbLabs.FormattingEnabled = true;
			this.cmbLabs.Location = new System.Drawing.Point(807, 85);
			this.cmbLabs.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
			this.cmbLabs.Name = "cmbLabs";
			this.cmbLabs.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.cmbLabs.Size = new System.Drawing.Size(200, 27);
			this.cmbLabs.TabIndex = 0;
			this.cmbLabs.SelectedIndexChanged += new System.EventHandler(this.cmbLabs_SelectedIndexChanged);
			// 
			// lblLabs
			// 
			this.lblLabs.AutoSize = true;
			this.lblLabs.Location = new System.Drawing.Point(1019, 88);
			this.lblLabs.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.lblLabs.Name = "lblLabs";
			this.lblLabs.Size = new System.Drawing.Size(48, 19);
			this.lblLabs.TabIndex = 1;
			this.lblLabs.Text = "المعامل";
			// 
			// lstWork
			// 
			this.lstWork.DisplayMember = "device_name";
			this.lstWork.FormattingEnabled = true;
			this.lstWork.ItemHeight = 19;
			this.lstWork.Location = new System.Drawing.Point(808, 212);
			this.lstWork.Name = "lstWork";
			this.lstWork.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lstWork.Size = new System.Drawing.Size(259, 289);
			this.lstWork.TabIndex = 2;
			this.lstWork.DoubleClick += new System.EventHandler(this.lstWork_DoubleClick);
			// 
			// lblWork
			// 
			this.lblWork.AutoSize = true;
			this.lblWork.Location = new System.Drawing.Point(919, 159);
			this.lblWork.Name = "lblWork";
			this.lblWork.Size = new System.Drawing.Size(33, 19);
			this.lblWork.TabIndex = 3;
			this.lblWork.Text = "يعمل";
			// 
			// lstNotWork
			// 
			this.lstNotWork.DisplayMember = "device_name";
			this.lstNotWork.FormattingEnabled = true;
			this.lstNotWork.ItemHeight = 19;
			this.lstNotWork.Location = new System.Drawing.Point(449, 212);
			this.lstNotWork.Name = "lstNotWork";
			this.lstNotWork.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lstNotWork.Size = new System.Drawing.Size(259, 289);
			this.lstNotWork.TabIndex = 2;
			this.lstNotWork.DoubleClick += new System.EventHandler(this.lstNotWork_DoubleClick);
			// 
			// lblNotWork
			// 
			this.lblNotWork.AutoSize = true;
			this.lblNotWork.Location = new System.Drawing.Point(545, 159);
			this.lblNotWork.Name = "lblNotWork";
			this.lblNotWork.Size = new System.Drawing.Size(45, 19);
			this.lblNotWork.TabIndex = 3;
			this.lblNotWork.Text = "لا يعمل";
			// 
			// lstTakhin
			// 
			this.lstTakhin.DisplayMember = "device_name";
			this.lstTakhin.FormattingEnabled = true;
			this.lstTakhin.ItemHeight = 19;
			this.lstTakhin.Location = new System.Drawing.Point(89, 212);
			this.lstTakhin.Name = "lstTakhin";
			this.lstTakhin.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lstTakhin.Size = new System.Drawing.Size(259, 289);
			this.lstTakhin.TabIndex = 2;
			this.lstTakhin.DoubleClick += new System.EventHandler(this.lstTakhin_DoubleClick);
			// 
			// lblTakhin
			// 
			this.lblTakhin.AutoSize = true;
			this.lblTakhin.Location = new System.Drawing.Point(188, 159);
			this.lblTakhin.Name = "lblTakhin";
			this.lblTakhin.Size = new System.Drawing.Size(38, 19);
			this.lblTakhin.TabIndex = 3;
			this.lblTakhin.Text = "مكهن";
			// 
			// btnFinishInventory
			// 
			this.btnFinishInventory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFinishInventory.BackgroundImage")));
			this.btnFinishInventory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnFinishInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFinishInventory.Location = new System.Drawing.Point(719, 76);
			this.btnFinishInventory.Name = "btnFinishInventory";
			this.btnFinishInventory.Size = new System.Drawing.Size(48, 43);
			this.btnFinishInventory.TabIndex = 5;
			this.btnFinishInventory.UseVisualStyleBackColor = true;
			// 
			// DevicesWithoutExperiment
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1150, 550);
			this.Controls.Add(this.btnFinishInventory);
			this.Controls.Add(this.lblTakhin);
			this.Controls.Add(this.lblNotWork);
			this.Controls.Add(this.lblWork);
			this.Controls.Add(this.lstTakhin);
			this.Controls.Add(this.lstNotWork);
			this.Controls.Add(this.lstWork);
			this.Controls.Add(this.lblLabs);
			this.Controls.Add(this.cmbLabs);
			this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
			this.MinimizeBox = false;
			this.Name = "DevicesWithoutExperiment";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "أجهزة بدون تجربة";
			this.Load += new System.EventHandler(this.DevicesWithoutExperiment_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cmbLabs;
		private System.Windows.Forms.Label lblLabs;
		private System.Windows.Forms.ListBox lstWork;
		private System.Windows.Forms.Label lblWork;
		private System.Windows.Forms.ListBox lstNotWork;
		private System.Windows.Forms.Label lblNotWork;
		private System.Windows.Forms.ListBox lstTakhin;
		private System.Windows.Forms.Label lblTakhin;
		private System.Windows.Forms.Button btnFinishInventory;
	}
}