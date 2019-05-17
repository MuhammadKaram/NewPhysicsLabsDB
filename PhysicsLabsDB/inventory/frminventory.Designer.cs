namespace PhysicsLabsDB.inventory
{
	partial class frmInventory
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInventory));
			this.cmbLabs = new System.Windows.Forms.ComboBox();
			this.cmbEmployee = new System.Windows.Forms.ComboBox();
			this.lblLabs = new System.Windows.Forms.Label();
			this.lblEmployee = new System.Windows.Forms.Label();
			this.txtBarcode = new System.Windows.Forms.TextBox();
			this.grdVwInventory = new System.Windows.Forms.DataGridView();
			this.colDeviceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colBarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colStatue = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colLab = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colRespon = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnFinishInventory = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.grdVwInventory)).BeginInit();
			this.SuspendLayout();
			// 
			// cmbLabs
			// 
			this.cmbLabs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbLabs.FormattingEnabled = true;
			this.cmbLabs.Location = new System.Drawing.Point(459, 56);
			this.cmbLabs.Name = "cmbLabs";
			this.cmbLabs.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.cmbLabs.Size = new System.Drawing.Size(216, 27);
			this.cmbLabs.TabIndex = 0;
			this.cmbLabs.SelectedIndexChanged += new System.EventHandler(this.cmbLabs_SelectedIndexChanged);
			// 
			// cmbEmployee
			// 
			this.cmbEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbEmployee.FormattingEnabled = true;
			this.cmbEmployee.Location = new System.Drawing.Point(34, 56);
			this.cmbEmployee.Name = "cmbEmployee";
			this.cmbEmployee.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.cmbEmployee.Size = new System.Drawing.Size(240, 27);
			this.cmbEmployee.TabIndex = 0;
			this.cmbEmployee.SelectedIndexChanged += new System.EventHandler(this.cmbEmployee_SelectedIndexChanged);
			// 
			// lblLabs
			// 
			this.lblLabs.AutoSize = true;
			this.lblLabs.Location = new System.Drawing.Point(696, 64);
			this.lblLabs.Name = "lblLabs";
			this.lblLabs.Size = new System.Drawing.Size(44, 19);
			this.lblLabs.TabIndex = 1;
			this.lblLabs.Text = "المعمل";
			// 
			// lblEmployee
			// 
			this.lblEmployee.AutoSize = true;
			this.lblEmployee.Location = new System.Drawing.Point(298, 59);
			this.lblEmployee.Name = "lblEmployee";
			this.lblEmployee.Size = new System.Drawing.Size(78, 19);
			this.lblEmployee.TabIndex = 1;
			this.lblEmployee.Text = "صاحب العهدة";
			// 
			// txtBarcode
			// 
			this.txtBarcode.Location = new System.Drawing.Point(189, 131);
			this.txtBarcode.Name = "txtBarcode";
			this.txtBarcode.Size = new System.Drawing.Size(425, 26);
			this.txtBarcode.TabIndex = 2;
			this.txtBarcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtBarcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBarcode_KeyDown);
			// 
			// grdVwInventory
			// 
			this.grdVwInventory.AllowUserToAddRows = false;
			this.grdVwInventory.AllowUserToDeleteRows = false;
			this.grdVwInventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.grdVwInventory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
			this.grdVwInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdVwInventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDeviceName,
            this.colBarcode,
            this.colStatue,
            this.colLab,
            this.colRespon});
			this.grdVwInventory.Location = new System.Drawing.Point(34, 191);
			this.grdVwInventory.Name = "grdVwInventory";
			this.grdVwInventory.ReadOnly = true;
			this.grdVwInventory.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.grdVwInventory.Size = new System.Drawing.Size(729, 236);
			this.grdVwInventory.TabIndex = 3;
			// 
			// colDeviceName
			// 
			this.colDeviceName.HeaderText = "اسم الجهاز";
			this.colDeviceName.Name = "colDeviceName";
			this.colDeviceName.ReadOnly = true;
			// 
			// colBarcode
			// 
			this.colBarcode.HeaderText = "الباركود";
			this.colBarcode.Name = "colBarcode";
			this.colBarcode.ReadOnly = true;
			// 
			// colStatue
			// 
			this.colStatue.HeaderText = "الحالة";
			this.colStatue.Name = "colStatue";
			this.colStatue.ReadOnly = true;
			// 
			// colLab
			// 
			this.colLab.HeaderText = "المعمل";
			this.colLab.Name = "colLab";
			this.colLab.ReadOnly = true;
			// 
			// colRespon
			// 
			this.colRespon.HeaderText = "صاحب العهدة";
			this.colRespon.Name = "colRespon";
			this.colRespon.ReadOnly = true;
			// 
			// btnFinishInventory
			// 
			this.btnFinishInventory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFinishInventory.BackgroundImage")));
			this.btnFinishInventory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnFinishInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFinishInventory.Location = new System.Drawing.Point(78, 122);
			this.btnFinishInventory.Name = "btnFinishInventory";
			this.btnFinishInventory.Size = new System.Drawing.Size(48, 43);
			this.btnFinishInventory.TabIndex = 4;
			this.btnFinishInventory.UseVisualStyleBackColor = true;
			this.btnFinishInventory.Click += new System.EventHandler(this.btnFinishInventory_Click);
			// 
			// frmInventory
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(800, 452);
			this.Controls.Add(this.btnFinishInventory);
			this.Controls.Add(this.grdVwInventory);
			this.Controls.Add(this.txtBarcode);
			this.Controls.Add(this.lblEmployee);
			this.Controls.Add(this.lblLabs);
			this.Controls.Add(this.cmbEmployee);
			this.Controls.Add(this.cmbLabs);
			this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximumSize = new System.Drawing.Size(1350, 694);
			this.MinimumSize = new System.Drawing.Size(36, 48);
			this.Name = "frmInventory";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "الجرد";
			this.Load += new System.EventHandler(this.inventory_Load);
			((System.ComponentModel.ISupportInitialize)(this.grdVwInventory)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cmbLabs;
		private System.Windows.Forms.ComboBox cmbEmployee;
		private System.Windows.Forms.Label lblLabs;
		private System.Windows.Forms.Label lblEmployee;
		private System.Windows.Forms.TextBox txtBarcode;
		private System.Windows.Forms.DataGridView grdVwInventory;
		private System.Windows.Forms.DataGridViewTextBoxColumn colDeviceName;
		private System.Windows.Forms.DataGridViewTextBoxColumn colBarcode;
		private System.Windows.Forms.DataGridViewTextBoxColumn colStatue;
		private System.Windows.Forms.DataGridViewTextBoxColumn colLab;
		private System.Windows.Forms.DataGridViewTextBoxColumn colRespon;
		private System.Windows.Forms.Button btnFinishInventory;
	}
}