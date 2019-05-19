namespace PhysicsLabsDB.Devices
{
    partial class frmDevice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDevice));
            this.lblDeviceName = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblBarcode = new System.Windows.Forms.Label();
            this.lblExperiment = new System.Windows.Forms.Label();
            this.lblLab = new System.Windows.Forms.Label();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.lblExperimentNum = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.tstrpDevices = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.delToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.resetToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.txtDeviceName = new System.Windows.Forms.TextBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.cmbExperiment = new System.Windows.Forms.ComboBox();
            this.cmbLab = new System.Windows.Forms.ComboBox();
            this.cmbExperimentNum = new System.Windows.Forms.ComboBox();
            this.cmbEmployee = new System.Windows.Forms.ComboBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnDisplayBarcode = new System.Windows.Forms.Button();
            this.picBarcode = new System.Windows.Forms.PictureBox();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlOpenSearch = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.grdVwSearch = new System.Windows.Forms.DataGridView();
            this.rdBarcode = new System.Windows.Forms.RadioButton();
            this.rdDevice = new System.Windows.Forms.RadioButton();
            this.colDeviceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExperiment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExperimentNum = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmployee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tstrpDevices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBarcode)).BeginInit();
            this.pnlOpenSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdVwSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDeviceName
            // 
            this.lblDeviceName.AutoSize = true;
            this.lblDeviceName.Location = new System.Drawing.Point(1055, 41);
            this.lblDeviceName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDeviceName.Name = "lblDeviceName";
            this.lblDeviceName.Size = new System.Drawing.Size(67, 19);
            this.lblDeviceName.TabIndex = 0;
            this.lblDeviceName.Text = "اسم الجهاز";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(648, 41);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(70, 19);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "حالة الجهاز";
            // 
            // lblBarcode
            // 
            this.lblBarcode.AutoSize = true;
            this.lblBarcode.Location = new System.Drawing.Point(1055, 75);
            this.lblBarcode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBarcode.Name = "lblBarcode";
            this.lblBarcode.Size = new System.Drawing.Size(50, 19);
            this.lblBarcode.TabIndex = 0;
            this.lblBarcode.Text = "الباركود";
            // 
            // lblExperiment
            // 
            this.lblExperiment.AutoSize = true;
            this.lblExperiment.Location = new System.Drawing.Point(648, 107);
            this.lblExperiment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExperiment.Name = "lblExperiment";
            this.lblExperiment.Size = new System.Drawing.Size(71, 19);
            this.lblExperiment.TabIndex = 0;
            this.lblExperiment.Text = "اسم التجربة";
            // 
            // lblLab
            // 
            this.lblLab.AutoSize = true;
            this.lblLab.Location = new System.Drawing.Point(648, 74);
            this.lblLab.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLab.Name = "lblLab";
            this.lblLab.Size = new System.Drawing.Size(44, 19);
            this.lblLab.TabIndex = 0;
            this.lblLab.Text = "المعمل";
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Location = new System.Drawing.Point(281, 41);
            this.lblEmployee.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(78, 19);
            this.lblEmployee.TabIndex = 0;
            this.lblEmployee.Text = "صاحب العهدة";
            // 
            // lblExperimentNum
            // 
            this.lblExperimentNum.AutoSize = true;
            this.lblExperimentNum.Location = new System.Drawing.Point(648, 140);
            this.lblExperimentNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExperimentNum.Name = "lblExperimentNum";
            this.lblExperimentNum.Size = new System.Drawing.Size(80, 19);
            this.lblExperimentNum.TabIndex = 0;
            this.lblExperimentNum.Text = "نسخة التجربة";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(281, 74);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(48, 19);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "الوصف";
            // 
            // tstrpDevices
            // 
            this.tstrpDevices.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.delToolStripButton,
            this.resetToolStripButton});
            this.tstrpDevices.Location = new System.Drawing.Point(0, 0);
            this.tstrpDevices.Name = "tstrpDevices";
            this.tstrpDevices.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tstrpDevices.Size = new System.Drawing.Size(1150, 25);
            this.tstrpDevices.TabIndex = 1;
            this.tstrpDevices.Text = "toolStrip1";
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.newToolStripButton.Text = "&New";
            this.newToolStripButton.Click += new System.EventHandler(this.newToolStripButton_Click);
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.openToolStripButton.Text = "&Open";
            this.openToolStripButton.Click += new System.EventHandler(this.openToolStripButton_Click);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "&Save";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // delToolStripButton
            // 
            this.delToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.delToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("delToolStripButton.Image")));
            this.delToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.delToolStripButton.Name = "delToolStripButton";
            this.delToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.delToolStripButton.Text = "Delete";
            this.delToolStripButton.Click += new System.EventHandler(this.delToolStripButton_Click);
            // 
            // resetToolStripButton
            // 
            this.resetToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.resetToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("resetToolStripButton.Image")));
            this.resetToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.resetToolStripButton.Name = "resetToolStripButton";
            this.resetToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.resetToolStripButton.Text = "&Reset";
            this.resetToolStripButton.Click += new System.EventHandler(this.resetToolStripButton_Click);
            // 
            // txtDeviceName
            // 
            this.txtDeviceName.Location = new System.Drawing.Point(802, 38);
            this.txtDeviceName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtDeviceName.Name = "txtDeviceName";
            this.txtDeviceName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDeviceName.Size = new System.Drawing.Size(246, 26);
            this.txtDeviceName.TabIndex = 2;
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(389, 38);
            this.cmbStatus.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbStatus.Size = new System.Drawing.Size(246, 27);
            this.cmbStatus.TabIndex = 3;
            // 
            // cmbExperiment
            // 
            this.cmbExperiment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbExperiment.FormattingEnabled = true;
            this.cmbExperiment.Location = new System.Drawing.Point(389, 104);
            this.cmbExperiment.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbExperiment.Name = "cmbExperiment";
            this.cmbExperiment.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbExperiment.Size = new System.Drawing.Size(246, 27);
            this.cmbExperiment.TabIndex = 3;
            this.cmbExperiment.SelectedIndexChanged += new System.EventHandler(this.cmbExperiment_SelectedIndexChanged);
            // 
            // cmbLab
            // 
            this.cmbLab.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLab.FormattingEnabled = true;
            this.cmbLab.Location = new System.Drawing.Point(389, 71);
            this.cmbLab.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbLab.Name = "cmbLab";
            this.cmbLab.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbLab.Size = new System.Drawing.Size(246, 27);
            this.cmbLab.TabIndex = 3;
            this.cmbLab.SelectedIndexChanged += new System.EventHandler(this.cmbLab_SelectedIndexChanged);
            // 
            // cmbExperimentNum
            // 
            this.cmbExperimentNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbExperimentNum.FormattingEnabled = true;
            this.cmbExperimentNum.Location = new System.Drawing.Point(389, 137);
            this.cmbExperimentNum.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbExperimentNum.Name = "cmbExperimentNum";
            this.cmbExperimentNum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbExperimentNum.Size = new System.Drawing.Size(246, 27);
            this.cmbExperimentNum.TabIndex = 3;
            // 
            // cmbEmployee
            // 
            this.cmbEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmployee.FormattingEnabled = true;
            this.cmbEmployee.Location = new System.Drawing.Point(31, 38);
            this.cmbEmployee.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbEmployee.Name = "cmbEmployee";
            this.cmbEmployee.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbEmployee.Size = new System.Drawing.Size(246, 27);
            this.cmbEmployee.TabIndex = 3;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(31, 71);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDescription.Size = new System.Drawing.Size(246, 93);
            this.txtDescription.TabIndex = 4;
            // 
            // btnDisplayBarcode
            // 
            this.btnDisplayBarcode.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDisplayBarcode.BackgroundImage")));
            this.btnDisplayBarcode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDisplayBarcode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisplayBarcode.Location = new System.Drawing.Point(768, 71);
            this.btnDisplayBarcode.Name = "btnDisplayBarcode";
            this.btnDisplayBarcode.Size = new System.Drawing.Size(29, 26);
            this.btnDisplayBarcode.TabIndex = 5;
            this.btnDisplayBarcode.UseVisualStyleBackColor = true;
            this.btnDisplayBarcode.Click += new System.EventHandler(this.btnDisplayBarcode_Click);
            // 
            // picBarcode
            // 
            this.picBarcode.Location = new System.Drawing.Point(802, 104);
            this.picBarcode.Name = "picBarcode";
            this.picBarcode.Size = new System.Drawing.Size(246, 60);
            this.picBarcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBarcode.TabIndex = 6;
            this.picBarcode.TabStop = false;
            this.picBarcode.DoubleClick += new System.EventHandler(this.picBarcode_DoubleClick);
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(802, 71);
            this.txtBarcode.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.ReadOnly = true;
            this.txtBarcode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtBarcode.Size = new System.Drawing.Size(246, 26);
            this.txtBarcode.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(11, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1126, 2);
            this.label1.TabIndex = 7;
            // 
            // pnlOpenSearch
            // 
            this.pnlOpenSearch.Controls.Add(this.txtSearch);
            this.pnlOpenSearch.Controls.Add(this.grdVwSearch);
            this.pnlOpenSearch.Controls.Add(this.rdBarcode);
            this.pnlOpenSearch.Controls.Add(this.rdDevice);
            this.pnlOpenSearch.Location = new System.Drawing.Point(12, 182);
            this.pnlOpenSearch.Name = "pnlOpenSearch";
            this.pnlOpenSearch.Size = new System.Drawing.Size(1125, 356);
            this.pnlOpenSearch.TabIndex = 20;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(269, 13);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(531, 26);
            this.txtSearch.TabIndex = 23;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // grdVwSearch
            // 
            this.grdVwSearch.AllowUserToAddRows = false;
            this.grdVwSearch.AllowUserToDeleteRows = false;
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
            this.grdVwSearch.Location = new System.Drawing.Point(3, 64);
            this.grdVwSearch.Name = "grdVwSearch";
            this.grdVwSearch.ReadOnly = true;
            this.grdVwSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grdVwSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdVwSearch.Size = new System.Drawing.Size(1119, 280);
            this.grdVwSearch.TabIndex = 22;
            this.grdVwSearch.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdVwSearch_CellClick);
            this.grdVwSearch.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdVwSearch_CellContentClick);
            // 
            // rdBarcode
            // 
            this.rdBarcode.AutoSize = true;
            this.rdBarcode.Location = new System.Drawing.Point(887, 16);
            this.rdBarcode.Name = "rdBarcode";
            this.rdBarcode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdBarcode.Size = new System.Drawing.Size(68, 23);
            this.rdBarcode.TabIndex = 21;
            this.rdBarcode.Text = "الباركود";
            this.rdBarcode.UseVisualStyleBackColor = true;
            this.rdBarcode.CheckedChanged += new System.EventHandler(this.rdBarcode_CheckedChanged);
            // 
            // rdDevice
            // 
            this.rdDevice.AutoSize = true;
            this.rdDevice.Checked = true;
            this.rdDevice.Location = new System.Drawing.Point(1008, 16);
            this.rdDevice.Name = "rdDevice";
            this.rdDevice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdDevice.Size = new System.Drawing.Size(85, 23);
            this.rdDevice.TabIndex = 20;
            this.rdDevice.TabStop = true;
            this.rdDevice.Text = "اسم الجهاز";
            this.rdDevice.UseVisualStyleBackColor = true;
            this.rdDevice.CheckedChanged += new System.EventHandler(this.rdBarcode_CheckedChanged);
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
            this.colBarcode.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colBarcode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            // frmDevice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1150, 550);
            this.Controls.Add(this.pnlOpenSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBarcode);
            this.Controls.Add(this.btnDisplayBarcode);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.cmbExperimentNum);
            this.Controls.Add(this.cmbExperiment);
            this.Controls.Add(this.cmbEmployee);
            this.Controls.Add(this.cmbLab);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.txtDeviceName);
            this.Controls.Add(this.tstrpDevices);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblExperiment);
            this.Controls.Add(this.lblExperimentNum);
            this.Controls.Add(this.lblBarcode);
            this.Controls.Add(this.lblEmployee);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblLab);
            this.Controls.Add(this.lblDeviceName);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDevice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLabs";
            this.Load += new System.EventHandler(this.frmDevice_Load);
            this.tstrpDevices.ResumeLayout(false);
            this.tstrpDevices.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBarcode)).EndInit();
            this.pnlOpenSearch.ResumeLayout(false);
            this.pnlOpenSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdVwSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDeviceName;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblBarcode;
        private System.Windows.Forms.Label lblExperiment;
        private System.Windows.Forms.Label lblLab;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.Label lblExperimentNum;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.ToolStrip tstrpDevices;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton resetToolStripButton;
        private System.Windows.Forms.TextBox txtDeviceName;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.ComboBox cmbExperiment;
        private System.Windows.Forms.ComboBox cmbLab;
        private System.Windows.Forms.ComboBox cmbExperimentNum;
        private System.Windows.Forms.ComboBox cmbEmployee;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.ToolStripButton delToolStripButton;
        private System.Windows.Forms.Button btnDisplayBarcode;
        private System.Windows.Forms.PictureBox picBarcode;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlOpenSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView grdVwSearch;
        private System.Windows.Forms.RadioButton rdBarcode;
        private System.Windows.Forms.RadioButton rdDevice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeviceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBarcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLab;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExperiment;
        private System.Windows.Forms.DataGridViewLinkColumn colExperimentNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
    }
}