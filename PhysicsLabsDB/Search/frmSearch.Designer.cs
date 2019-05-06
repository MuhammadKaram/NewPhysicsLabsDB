namespace PhysicsLabsDB.Search
{
    partial class frmSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearch));
            this.rdDevice = new System.Windows.Forms.RadioButton();
            this.rdExperiment = new System.Windows.Forms.RadioButton();
            this.rdEmployee = new System.Windows.Forms.RadioButton();
            this.rdBarcode = new System.Windows.Forms.RadioButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmbLab = new System.Windows.Forms.ComboBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.picFacultyLogo = new System.Windows.Forms.PictureBox();
            this.picDepartmentLogo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkLab = new System.Windows.Forms.CheckBox();
            this.chkStatus = new System.Windows.Forms.CheckBox();
            this.grdVwSearch = new System.Windows.Forms.DataGridView();
            this.colDeviceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBarcode = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colLab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExperiment = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colExperimentNum = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmployee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.picFacultyLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDepartmentLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdVwSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // rdDevice
            // 
            this.rdDevice.AutoSize = true;
            this.rdDevice.Checked = true;
            this.rdDevice.Location = new System.Drawing.Point(1041, 151);
            this.rdDevice.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rdDevice.Name = "rdDevice";
            this.rdDevice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdDevice.Size = new System.Drawing.Size(85, 23);
            this.rdDevice.TabIndex = 2;
            this.rdDevice.TabStop = true;
            this.rdDevice.Text = "اسم الجهاز";
            this.rdDevice.UseVisualStyleBackColor = true;
            this.rdDevice.CheckedChanged += new System.EventHandler(this.rdDevice_CheckedChanged);
            // 
            // rdExperiment
            // 
            this.rdExperiment.AutoSize = true;
            this.rdExperiment.Location = new System.Drawing.Point(944, 151);
            this.rdExperiment.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rdExperiment.Name = "rdExperiment";
            this.rdExperiment.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdExperiment.Size = new System.Drawing.Size(89, 23);
            this.rdExperiment.TabIndex = 3;
            this.rdExperiment.Text = "اسم التجربة";
            this.rdExperiment.UseVisualStyleBackColor = true;
            this.rdExperiment.CheckedChanged += new System.EventHandler(this.rdDevice_CheckedChanged);
            // 
            // rdEmployee
            // 
            this.rdEmployee.AutoSize = true;
            this.rdEmployee.Location = new System.Drawing.Point(838, 151);
            this.rdEmployee.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rdEmployee.Name = "rdEmployee";
            this.rdEmployee.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdEmployee.Size = new System.Drawing.Size(96, 23);
            this.rdEmployee.TabIndex = 4;
            this.rdEmployee.Text = "صاحب العهدة";
            this.rdEmployee.UseVisualStyleBackColor = true;
            this.rdEmployee.CheckedChanged += new System.EventHandler(this.rdDevice_CheckedChanged);
            // 
            // rdBarcode
            // 
            this.rdBarcode.AutoSize = true;
            this.rdBarcode.Location = new System.Drawing.Point(762, 151);
            this.rdBarcode.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rdBarcode.Name = "rdBarcode";
            this.rdBarcode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdBarcode.Size = new System.Drawing.Size(68, 23);
            this.rdBarcode.TabIndex = 5;
            this.rdBarcode.Text = "الباركود";
            this.rdBarcode.UseVisualStyleBackColor = true;
            this.rdBarcode.CheckedChanged += new System.EventHandler(this.rdDevice_CheckedChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(353, 88);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(443, 26);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // cmbLab
            // 
            this.cmbLab.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLab.Enabled = false;
            this.cmbLab.FormattingEnabled = true;
            this.cmbLab.Location = new System.Drawing.Point(380, 147);
            this.cmbLab.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbLab.Name = "cmbLab";
            this.cmbLab.Size = new System.Drawing.Size(228, 27);
            this.cmbLab.TabIndex = 6;
            this.cmbLab.SelectedIndexChanged += new System.EventHandler(this.cmbLab_SelectedIndexChanged);
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Enabled = false;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(23, 147);
            this.cmbStatus.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(228, 27);
            this.cmbStatus.TabIndex = 7;
            this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.cmbStatus_SelectedIndexChanged);
            // 
            // picFacultyLogo
            // 
            this.picFacultyLogo.Image = ((System.Drawing.Image)(resources.GetObject("picFacultyLogo.Image")));
            this.picFacultyLogo.Location = new System.Drawing.Point(1027, 24);
            this.picFacultyLogo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.picFacultyLogo.Name = "picFacultyLogo";
            this.picFacultyLogo.Size = new System.Drawing.Size(99, 105);
            this.picFacultyLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFacultyLogo.TabIndex = 5;
            this.picFacultyLogo.TabStop = false;
            // 
            // picDepartmentLogo
            // 
            this.picDepartmentLogo.Image = ((System.Drawing.Image)(resources.GetObject("picDepartmentLogo.Image")));
            this.picDepartmentLogo.Location = new System.Drawing.Point(23, 24);
            this.picDepartmentLogo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.picDepartmentLogo.Name = "picDepartmentLogo";
            this.picDepartmentLogo.Size = new System.Drawing.Size(99, 105);
            this.picDepartmentLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDepartmentLogo.TabIndex = 5;
            this.picDepartmentLogo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(476, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "أجهزة معامل قسم الفيزياء";
            // 
            // chkLab
            // 
            this.chkLab.AutoSize = true;
            this.chkLab.Location = new System.Drawing.Point(613, 149);
            this.chkLab.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.chkLab.Name = "chkLab";
            this.chkLab.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkLab.Size = new System.Drawing.Size(63, 23);
            this.chkLab.TabIndex = 8;
            this.chkLab.Text = "المعمل";
            this.chkLab.UseVisualStyleBackColor = true;
            this.chkLab.CheckedChanged += new System.EventHandler(this.chkLab_CheckedChanged);
            // 
            // chkStatus
            // 
            this.chkStatus.AutoSize = true;
            this.chkStatus.Location = new System.Drawing.Point(256, 149);
            this.chkStatus.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.chkStatus.Name = "chkStatus";
            this.chkStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkStatus.Size = new System.Drawing.Size(89, 23);
            this.chkStatus.TabIndex = 8;
            this.chkStatus.Text = "حالة الجهاز";
            this.chkStatus.UseVisualStyleBackColor = true;
            this.chkStatus.CheckedChanged += new System.EventHandler(this.chkStatus_CheckedChanged);
            // 
            // grdVwSearch
            // 
            this.grdVwSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdVwSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdVwSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDeviceName,
            this.colBarcode,
            this.colLab,
            this.colExperiment,
            this.colExperimentNum,
            this.colStatus,
            this.colEmployee,
            this.colDescription});
            this.grdVwSearch.Location = new System.Drawing.Point(23, 193);
            this.grdVwSearch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grdVwSearch.Name = "grdVwSearch";
            this.grdVwSearch.ReadOnly = true;
            this.grdVwSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grdVwSearch.Size = new System.Drawing.Size(1103, 332);
            this.grdVwSearch.TabIndex = 9;
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
            // colLab
            // 
            this.colLab.HeaderText = "المعمل";
            this.colLab.Name = "colLab";
            this.colLab.ReadOnly = true;
            // 
            // colExperiment
            // 
            this.colExperiment.HeaderText = "التجربة";
            this.colExperiment.Name = "colExperiment";
            this.colExperiment.ReadOnly = true;
            this.colExperiment.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colExperiment.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colExperimentNum
            // 
            this.colExperimentNum.HeaderText = "رقم نسخة التجربة";
            this.colExperimentNum.Name = "colExperimentNum";
            this.colExperimentNum.ReadOnly = true;
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "حالة الجهاز";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            // 
            // colEmployee
            // 
            this.colEmployee.HeaderText = "صاحب العهدة";
            this.colEmployee.Name = "colEmployee";
            this.colEmployee.ReadOnly = true;
            // 
            // colDescription
            // 
            this.colDescription.HeaderText = "الوصف";
            this.colDescription.Name = "colDescription";
            this.colDescription.ReadOnly = true;
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1150, 550);
            this.Controls.Add(this.grdVwSearch);
            this.Controls.Add(this.chkStatus);
            this.Controls.Add(this.chkLab);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picDepartmentLogo);
            this.Controls.Add(this.picFacultyLogo);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.cmbLab);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.rdBarcode);
            this.Controls.Add(this.rdEmployee);
            this.Controls.Add(this.rdExperiment);
            this.Controls.Add(this.rdDevice);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLabs";
            this.Load += new System.EventHandler(this.frmSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picFacultyLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDepartmentLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdVwSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rdDevice;
        private System.Windows.Forms.RadioButton rdExperiment;
        private System.Windows.Forms.RadioButton rdEmployee;
        private System.Windows.Forms.RadioButton rdBarcode;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmbLab;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.PictureBox picFacultyLogo;
        private System.Windows.Forms.PictureBox picDepartmentLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkLab;
        private System.Windows.Forms.CheckBox chkStatus;
        private System.Windows.Forms.DataGridView grdVwSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeviceName;
        private System.Windows.Forms.DataGridViewLinkColumn colBarcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLab;
        private System.Windows.Forms.DataGridViewLinkColumn colExperiment;
        private System.Windows.Forms.DataGridViewLinkColumn colExperimentNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
    }
}