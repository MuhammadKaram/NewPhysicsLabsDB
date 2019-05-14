namespace PhysicsLabsDB.Experiments
{
    partial class frmExperimentDevices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExperimentDevices));
            this.lblExperimentName = new System.Windows.Forms.Label();
            this.txtExperimentNum = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.btnRemoveDevice = new System.Windows.Forms.Button();
            this.btnAddDevice = new System.Windows.Forms.Button();
            this.lstExperimentDevices = new System.Windows.Forms.ListBox();
            this.lstAvailableDevices = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblExperimentName
            // 
            this.lblExperimentName.AutoSize = true;
            this.lblExperimentName.Location = new System.Drawing.Point(320, 19);
            this.lblExperimentName.Name = "lblExperimentName";
            this.lblExperimentName.Size = new System.Drawing.Size(82, 22);
            this.lblExperimentName.TabIndex = 29;
            this.lblExperimentName.Text = "اسم التجربة";
            // 
            // txtExperimentNum
            // 
            this.txtExperimentNum.Location = new System.Drawing.Point(320, 44);
            this.txtExperimentNum.Name = "txtExperimentNum";
            this.txtExperimentNum.ReadOnly = true;
            this.txtExperimentNum.Size = new System.Drawing.Size(83, 29);
            this.txtExperimentNum.TabIndex = 28;
            this.txtExperimentNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(517, 63);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(110, 22);
            this.label27.TabIndex = 24;
            this.label27.Text = " الأجهزة المتاحة";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(91, 63);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(104, 22);
            this.label30.TabIndex = 26;
            this.label30.Text = "مكونات التجربة";
            // 
            // btnRemoveDevice
            // 
            this.btnRemoveDevice.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRemoveDevice.BackgroundImage")));
            this.btnRemoveDevice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemoveDevice.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveDevice.Location = new System.Drawing.Point(331, 318);
            this.btnRemoveDevice.Name = "btnRemoveDevice";
            this.btnRemoveDevice.Size = new System.Drawing.Size(63, 49);
            this.btnRemoveDevice.TabIndex = 21;
            this.btnRemoveDevice.UseVisualStyleBackColor = true;
            this.btnRemoveDevice.Click += new System.EventHandler(this.btnRemoveDevice_Click);
            // 
            // btnAddDevice
            // 
            this.btnAddDevice.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddDevice.BackgroundImage")));
            this.btnAddDevice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddDevice.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDevice.Location = new System.Drawing.Point(331, 229);
            this.btnAddDevice.Name = "btnAddDevice";
            this.btnAddDevice.Size = new System.Drawing.Size(63, 49);
            this.btnAddDevice.TabIndex = 23;
            this.btnAddDevice.UseVisualStyleBackColor = true;
            this.btnAddDevice.Click += new System.EventHandler(this.btnAddDevice_Click);
            // 
            // lstExperimentDevices
            // 
            this.lstExperimentDevices.DisplayMember = "device_name";
            this.lstExperimentDevices.FormattingEnabled = true;
            this.lstExperimentDevices.ItemHeight = 22;
            this.lstExperimentDevices.Location = new System.Drawing.Point(19, 95);
            this.lstExperimentDevices.Name = "lstExperimentDevices";
            this.lstExperimentDevices.Size = new System.Drawing.Size(252, 400);
            this.lstExperimentDevices.TabIndex = 22;
            this.lstExperimentDevices.ValueMember = "ID";
            this.lstExperimentDevices.DoubleClick += new System.EventHandler(this.lstExperimentDevices_DoubleClick);
            // 
            // lstAvailableDevices
            // 
            this.lstAvailableDevices.DisplayMember = "device_name";
            this.lstAvailableDevices.FormattingEnabled = true;
            this.lstAvailableDevices.ItemHeight = 22;
            this.lstAvailableDevices.Location = new System.Drawing.Point(449, 95);
            this.lstAvailableDevices.Name = "lstAvailableDevices";
            this.lstAvailableDevices.Size = new System.Drawing.Size(252, 400);
            this.lstAvailableDevices.TabIndex = 20;
            this.lstAvailableDevices.ValueMember = "ID";
            this.lstAvailableDevices.DoubleClick += new System.EventHandler(this.lstAvailableDevices_DoubleClick);
            // 
            // frmExperimentDevices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(720, 511);
            this.Controls.Add(this.lblExperimentName);
            this.Controls.Add(this.txtExperimentNum);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.btnRemoveDevice);
            this.Controls.Add(this.btnAddDevice);
            this.Controls.Add(this.lstExperimentDevices);
            this.Controls.Add(this.lstAvailableDevices);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmExperimentDevices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مكونات التجربة";
            this.Load += new System.EventHandler(this.frmExperimentDevices_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblExperimentName;
        public System.Windows.Forms.TextBox txtExperimentNum;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Button btnRemoveDevice;
        private System.Windows.Forms.Button btnAddDevice;
        public System.Windows.Forms.ListBox lstExperimentDevices;
        public System.Windows.Forms.ListBox lstAvailableDevices;
    }
}