namespace PhysicsLabsDB
{
    partial class frmMain
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			this.tstrpMain = new System.Windows.Forms.ToolStrip();
			this.tsbtnMain = new System.Windows.Forms.ToolStripButton();
			this.tsbtnDevices = new System.Windows.Forms.ToolStripButton();
			this.tsbtnCustody = new System.Windows.Forms.ToolStripDropDownButton();
			this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.custodyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tsbtnExperiments = new System.Windows.Forms.ToolStripButton();
			this.tsbtnAccounts = new System.Windows.Forms.ToolStripButton();
			this.tsbtnInventory = new System.Windows.Forms.ToolStripButton();
			this.tsbtnDevicesWithoutExp = new System.Windows.Forms.ToolStripButton();
			this.tstrpMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// tstrpMain
			// 
			this.tstrpMain.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tstrpMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnMain,
            this.tsbtnDevices,
            this.tsbtnCustody,
            this.tsbtnExperiments,
            this.tsbtnAccounts,
            this.tsbtnInventory,
            this.tsbtnDevicesWithoutExp});
			this.tstrpMain.Location = new System.Drawing.Point(0, 0);
			this.tstrpMain.Name = "tstrpMain";
			this.tstrpMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.tstrpMain.Size = new System.Drawing.Size(1234, 25);
			this.tstrpMain.Stretch = true;
			this.tstrpMain.TabIndex = 1;
			this.tstrpMain.Text = "tstrpMain";
			// 
			// tsbtnMain
			// 
			this.tsbtnMain.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnMain.Image")));
			this.tsbtnMain.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbtnMain.Name = "tsbtnMain";
			this.tsbtnMain.Size = new System.Drawing.Size(61, 22);
			this.tsbtnMain.Text = "الرئيسية";
			this.tsbtnMain.Click += new System.EventHandler(this.tsbtnMain_Click);
			// 
			// tsbtnDevices
			// 
			this.tsbtnDevices.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnDevices.Image")));
			this.tsbtnDevices.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbtnDevices.Name = "tsbtnDevices";
			this.tsbtnDevices.Size = new System.Drawing.Size(60, 22);
			this.tsbtnDevices.Text = "الأجهزة";
			this.tsbtnDevices.Click += new System.EventHandler(this.tsbtnDevices_Click);
			// 
			// tsbtnCustody
			// 
			this.tsbtnCustody.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeToolStripMenuItem,
            this.custodyToolStripMenuItem});
			this.tsbtnCustody.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnCustody.Image")));
			this.tsbtnCustody.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbtnCustody.Name = "tsbtnCustody";
			this.tsbtnCustody.Size = new System.Drawing.Size(57, 22);
			this.tsbtnCustody.Text = "العهد";
			// 
			// employeeToolStripMenuItem
			// 
			this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
			this.employeeToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
			this.employeeToolStripMenuItem.Text = "أصحاب العهد";
			this.employeeToolStripMenuItem.Click += new System.EventHandler(this.employeeToolStripMenuItem_Click);
			// 
			// custodyToolStripMenuItem
			// 
			this.custodyToolStripMenuItem.Name = "custodyToolStripMenuItem";
			this.custodyToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
			this.custodyToolStripMenuItem.Text = "نقل العهدة";
			this.custodyToolStripMenuItem.Click += new System.EventHandler(this.custodyToolStripMenuItem_Click);
			// 
			// tsbtnExperiments
			// 
			this.tsbtnExperiments.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnExperiments.Image")));
			this.tsbtnExperiments.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbtnExperiments.Name = "tsbtnExperiments";
			this.tsbtnExperiments.Size = new System.Drawing.Size(62, 22);
			this.tsbtnExperiments.Text = "التجارب";
			this.tsbtnExperiments.Click += new System.EventHandler(this.tsbtnExperiments_Click);
			// 
			// tsbtnAccounts
			// 
			this.tsbtnAccounts.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnAccounts.Image")));
			this.tsbtnAccounts.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbtnAccounts.Name = "tsbtnAccounts";
			this.tsbtnAccounts.Size = new System.Drawing.Size(111, 22);
			this.tsbtnAccounts.Text = "حسابات المستخدمين";
			this.tsbtnAccounts.Click += new System.EventHandler(this.tsbtnAccounts_Click);
			// 
			// tsbtnInventory
			// 
			this.tsbtnInventory.Image = global::PhysicsLabsDB.Properties.Resources.iconfinder_icon_40_clipboard_list_314403;
			this.tsbtnInventory.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbtnInventory.Name = "tsbtnInventory";
			this.tsbtnInventory.Size = new System.Drawing.Size(51, 22);
			this.tsbtnInventory.Text = "الجرد";
			this.tsbtnInventory.Click += new System.EventHandler(this.tsbtnInventory_Click);
			// 
			// tsbtnDevicesWithoutExp
			// 
			this.tsbtnDevicesWithoutExp.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnDevicesWithoutExp.Image")));
			this.tsbtnDevicesWithoutExp.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbtnDevicesWithoutExp.Name = "tsbtnDevicesWithoutExp";
			this.tsbtnDevicesWithoutExp.Size = new System.Drawing.Size(105, 22);
			this.tsbtnDevicesWithoutExp.Text = "أجهزة بدون تجربة";
			this.tsbtnDevicesWithoutExp.Click += new System.EventHandler(this.tsbtnDevicesWithoutExp_Click);
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1234, 561);
			this.Controls.Add(this.tstrpMain);
			this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.IsMdiContainer = true;
			this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
			this.MaximizeBox = false;
			this.Name = "frmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "معامل قسم الفيزياء";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
			this.Load += new System.EventHandler(this.frmMain_Load);
			this.tstrpMain.ResumeLayout(false);
			this.tstrpMain.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tstrpMain;
        private System.Windows.Forms.ToolStripButton tsbtnDevices;
        private System.Windows.Forms.ToolStripButton tsbtnMain;
		private System.Windows.Forms.ToolStripDropDownButton tsbtnCustody;
		private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem custodyToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tsbtnExperiments;
        private System.Windows.Forms.ToolStripButton tsbtnAccounts;
		private System.Windows.Forms.ToolStripButton tsbtnInventory;
		private System.Windows.Forms.ToolStripButton tsbtnDevicesWithoutExp;
	}
}