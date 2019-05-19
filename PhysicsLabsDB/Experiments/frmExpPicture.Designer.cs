namespace PhysicsLabsDB.Experiments
{
    partial class frmExpPicture
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExpPicture));
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.tstrpImage = new System.Windows.Forms.ToolStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.delToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.tstrpImage.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(506, 436);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // tstrpImage
            // 
            this.tstrpImage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.delToolStripButton});
            this.tstrpImage.Location = new System.Drawing.Point(0, 0);
            this.tstrpImage.Name = "tstrpImage";
            this.tstrpImage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tstrpImage.Size = new System.Drawing.Size(506, 25);
            this.tstrpImage.TabIndex = 1;
            this.tstrpImage.Text = "toolStrip1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(506, 436);
            this.panel1.TabIndex = 2;
            // 
            // delToolStripButton
            // 
            this.delToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.delToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("delToolStripButton.Image")));
            this.delToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.delToolStripButton.Name = "delToolStripButton";
            this.delToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.delToolStripButton.Text = "&حذف الصورة";
            this.delToolStripButton.Click += new System.EventHandler(this.delToolStripButton_Click);
            // 
            // frmExpPicture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(506, 461);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tstrpImage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmExpPicture";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "صورة التجربة";
            this.Load += new System.EventHandler(this.frmExpPicture_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.tstrpImage.ResumeLayout(false);
            this.tstrpImage.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ToolStrip tstrpImage;
        private System.Windows.Forms.ToolStripButton delToolStripButton;
        private System.Windows.Forms.Panel panel1;
    }
}