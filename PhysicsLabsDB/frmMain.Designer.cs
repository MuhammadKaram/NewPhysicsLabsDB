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
			this.tsbtnCustody = new System.Windows.Forms.ToolStripButton();
			this.tstrpMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// tstrpMain
			// 
			this.tstrpMain.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tstrpMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnMain,
            this.tsbtnDevices,
            this.tsbtnCustody});
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
			this.tsbtnCustody.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnCustody.Image")));
			this.tsbtnCustody.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbtnCustody.Name = "tsbtnCustody";
			this.tsbtnCustody.Size = new System.Drawing.Size(48, 22);
			this.tsbtnCustody.Text = "العهد";
			this.tsbtnCustody.Click += new System.EventHandler(this.tsbtnCustody_Click);
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
		private System.Windows.Forms.ToolStripButton tsbtnCustody;
	}
}