namespace PhysicsLabsDB.Experiments
{
    partial class frmExperiment
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
            this.cmbLab = new System.Windows.Forms.ComboBox();
            this.lblLab = new System.Windows.Forms.Label();
            this.btnExperimentsPicture = new System.Windows.Forms.Button();
            this.txtExperimetNum = new System.Windows.Forms.TextBox();
            this.btnDeleteExpCopy = new System.Windows.Forms.Button();
            this.btnDeleteExperiment = new System.Windows.Forms.Button();
            this.btnEditExpDevices = new System.Windows.Forms.Button();
            this.btnAddExpCopy = new System.Windows.Forms.Button();
            this.btnAddExperiment = new System.Windows.Forms.Button();
            this.lstExperimentsDevices = new System.Windows.Forms.ListBox();
            this.lstExperimentsNum = new System.Windows.Forms.ListBox();
            this.lstExperiments = new System.Windows.Forms.ListBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbLab
            // 
            this.cmbLab.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLab.FormattingEnabled = true;
            this.cmbLab.Location = new System.Drawing.Point(769, 42);
            this.cmbLab.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbLab.Name = "cmbLab";
            this.cmbLab.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbLab.Size = new System.Drawing.Size(246, 30);
            this.cmbLab.TabIndex = 5;
            this.cmbLab.SelectedIndexChanged += new System.EventHandler(this.cmbLab_SelectedIndexChanged);
            // 
            // lblLab
            // 
            this.lblLab.AutoSize = true;
            this.lblLab.Location = new System.Drawing.Point(1026, 45);
            this.lblLab.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLab.Name = "lblLab";
            this.lblLab.Size = new System.Drawing.Size(50, 22);
            this.lblLab.TabIndex = 4;
            this.lblLab.Text = "المعمل";
            // 
            // btnExperimentsPicture
            // 
            this.btnExperimentsPicture.Location = new System.Drawing.Point(733, 490);
            this.btnExperimentsPicture.Name = "btnExperimentsPicture";
            this.btnExperimentsPicture.Size = new System.Drawing.Size(343, 32);
            this.btnExperimentsPicture.TabIndex = 26;
            this.btnExperimentsPicture.Text = "صورة للتجربة";
            this.btnExperimentsPicture.UseVisualStyleBackColor = true;
            this.btnExperimentsPicture.Click += new System.EventHandler(this.btnExperimentsPicture_Click);
            // 
            // txtExperimetNum
            // 
            this.txtExperimetNum.Location = new System.Drawing.Point(505, 98);
            this.txtExperimetNum.Name = "txtExperimetNum";
            this.txtExperimetNum.ReadOnly = true;
            this.txtExperimetNum.Size = new System.Drawing.Size(65, 29);
            this.txtExperimetNum.TabIndex = 25;
            this.txtExperimetNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnDeleteExpCopy
            // 
            this.btnDeleteExpCopy.Location = new System.Drawing.Point(505, 490);
            this.btnDeleteExpCopy.Name = "btnDeleteExpCopy";
            this.btnDeleteExpCopy.Size = new System.Drawing.Size(146, 32);
            this.btnDeleteExpCopy.TabIndex = 22;
            this.btnDeleteExpCopy.Text = "حذف نسخة";
            this.btnDeleteExpCopy.UseVisualStyleBackColor = true;
            this.btnDeleteExpCopy.Click += new System.EventHandler(this.btnDeleteExpCopy_Click);
            // 
            // btnDeleteExperiment
            // 
            this.btnDeleteExperiment.Location = new System.Drawing.Point(733, 452);
            this.btnDeleteExperiment.Name = "btnDeleteExperiment";
            this.btnDeleteExperiment.Size = new System.Drawing.Size(343, 32);
            this.btnDeleteExperiment.TabIndex = 24;
            this.btnDeleteExperiment.Text = "حذف تجربة";
            this.btnDeleteExperiment.UseVisualStyleBackColor = true;
            this.btnDeleteExperiment.Click += new System.EventHandler(this.btnDeleteExperiment_Click);
            // 
            // btnEditExpDevices
            // 
            this.btnEditExpDevices.Location = new System.Drawing.Point(74, 490);
            this.btnEditExpDevices.Name = "btnEditExpDevices";
            this.btnEditExpDevices.Size = new System.Drawing.Size(343, 32);
            this.btnEditExpDevices.TabIndex = 19;
            this.btnEditExpDevices.Text = "تعديل أجهزة التجربة";
            this.btnEditExpDevices.UseVisualStyleBackColor = true;
            this.btnEditExpDevices.Click += new System.EventHandler(this.btnEditExpDevices_Click);
            // 
            // btnAddExpCopy
            // 
            this.btnAddExpCopy.Location = new System.Drawing.Point(505, 452);
            this.btnAddExpCopy.Name = "btnAddExpCopy";
            this.btnAddExpCopy.Size = new System.Drawing.Size(146, 32);
            this.btnAddExpCopy.TabIndex = 21;
            this.btnAddExpCopy.Text = "إضافة نسخة";
            this.btnAddExpCopy.UseVisualStyleBackColor = true;
            this.btnAddExpCopy.Click += new System.EventHandler(this.btnAddExpCopy_Click);
            // 
            // btnAddExperiment
            // 
            this.btnAddExperiment.Location = new System.Drawing.Point(733, 414);
            this.btnAddExperiment.Name = "btnAddExperiment";
            this.btnAddExperiment.Size = new System.Drawing.Size(343, 32);
            this.btnAddExperiment.TabIndex = 23;
            this.btnAddExperiment.Text = "إضافة تجربة";
            this.btnAddExperiment.UseVisualStyleBackColor = true;
            this.btnAddExperiment.Click += new System.EventHandler(this.btnAddExperiment_Click);
            // 
            // lstExperimentsDevices
            // 
            this.lstExperimentsDevices.DisplayMember = "device_name";
            this.lstExperimentsDevices.FormattingEnabled = true;
            this.lstExperimentsDevices.ItemHeight = 22;
            this.lstExperimentsDevices.Location = new System.Drawing.Point(74, 140);
            this.lstExperimentsDevices.Name = "lstExperimentsDevices";
            this.lstExperimentsDevices.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lstExperimentsDevices.Size = new System.Drawing.Size(343, 268);
            this.lstExperimentsDevices.TabIndex = 18;
            this.lstExperimentsDevices.ValueMember = "ID";
            this.lstExperimentsDevices.DoubleClick += new System.EventHandler(this.lstExperimentsDevices_DoubleClick);
            // 
            // lstExperimentsNum
            // 
            this.lstExperimentsNum.FormattingEnabled = true;
            this.lstExperimentsNum.ItemHeight = 22;
            this.lstExperimentsNum.Location = new System.Drawing.Point(505, 140);
            this.lstExperimentsNum.Name = "lstExperimentsNum";
            this.lstExperimentsNum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lstExperimentsNum.Size = new System.Drawing.Size(146, 268);
            this.lstExperimentsNum.TabIndex = 17;
            this.lstExperimentsNum.SelectedIndexChanged += new System.EventHandler(this.lstExperimentsNum_SelectedIndexChanged);
            this.lstExperimentsNum.DoubleClick += new System.EventHandler(this.lstExperimentsNum_DoubleClick);
            // 
            // lstExperiments
            // 
            this.lstExperiments.FormattingEnabled = true;
            this.lstExperiments.ItemHeight = 22;
            this.lstExperiments.Location = new System.Drawing.Point(733, 140);
            this.lstExperiments.Name = "lstExperiments";
            this.lstExperiments.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lstExperiments.Size = new System.Drawing.Size(343, 268);
            this.lstExperiments.TabIndex = 13;
            this.lstExperiments.SelectedIndexChanged += new System.EventHandler(this.lstExperiments_SelectedIndexChanged);
            this.lstExperiments.DoubleClick += new System.EventHandler(this.lstExperiments_DoubleClick);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(200, 101);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(97, 22);
            this.label21.TabIndex = 14;
            this.label21.Text = "أجهزة التجربة";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(576, 101);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(75, 22);
            this.label20.TabIndex = 15;
            this.label20.Text = "عدد النسخ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(880, 101);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(57, 22);
            this.label16.TabIndex = 16;
            this.label16.Text = "التجارب";
            // 
            // frmExperiment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1150, 550);
            this.Controls.Add(this.btnExperimentsPicture);
            this.Controls.Add(this.txtExperimetNum);
            this.Controls.Add(this.btnDeleteExpCopy);
            this.Controls.Add(this.btnDeleteExperiment);
            this.Controls.Add(this.btnEditExpDevices);
            this.Controls.Add(this.btnAddExpCopy);
            this.Controls.Add(this.btnAddExperiment);
            this.Controls.Add(this.lstExperimentsDevices);
            this.Controls.Add(this.lstExperimentsNum);
            this.Controls.Add(this.lstExperiments);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.cmbLab);
            this.Controls.Add(this.lblLab);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmExperiment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLabs";
            this.Load += new System.EventHandler(this.frmExperiment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbLab;
        private System.Windows.Forms.Label lblLab;
        private System.Windows.Forms.Button btnExperimentsPicture;
        private System.Windows.Forms.TextBox txtExperimetNum;
        private System.Windows.Forms.Button btnDeleteExpCopy;
        private System.Windows.Forms.Button btnDeleteExperiment;
        private System.Windows.Forms.Button btnEditExpDevices;
        private System.Windows.Forms.Button btnAddExpCopy;
        private System.Windows.Forms.Button btnAddExperiment;
        public System.Windows.Forms.ListBox lstExperimentsDevices;
        public System.Windows.Forms.ListBox lstExperimentsNum;
        public System.Windows.Forms.ListBox lstExperiments;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label16;
    }
}