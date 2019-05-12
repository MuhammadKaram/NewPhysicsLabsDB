namespace PhysicsLabsDB.Accounts
{
    partial class frmAccounts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccounts));
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblAccountType = new System.Windows.Forms.Label();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.tstrpDevices = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.delToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.resetToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.txtuserName = new System.Windows.Forms.TextBox();
            this.cmbAccountType = new System.Windows.Forms.ComboBox();
            this.cmbEmployee = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grdVwUsers = new System.Windows.Forms.DataGridView();
            this.colUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAccountType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRespon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.tstrpDevices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdVwUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(656, 52);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(81, 19);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "اسم المستخدم";
            // 
            // lblAccountType
            // 
            this.lblAccountType.AutoSize = true;
            this.lblAccountType.Location = new System.Drawing.Point(664, 86);
            this.lblAccountType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAccountType.Name = "lblAccountType";
            this.lblAccountType.Size = new System.Drawing.Size(73, 19);
            this.lblAccountType.TabIndex = 0;
            this.lblAccountType.Text = "نوع الحساب";
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Location = new System.Drawing.Point(686, 117);
            this.lblEmployee.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(51, 19);
            this.lblEmployee.TabIndex = 0;
            this.lblEmployee.Text = "الموظف";
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
            this.tstrpDevices.Size = new System.Drawing.Size(754, 25);
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
            // txtuserName
            // 
            this.txtuserName.Location = new System.Drawing.Point(389, 45);
            this.txtuserName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtuserName.Name = "txtuserName";
            this.txtuserName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtuserName.Size = new System.Drawing.Size(246, 26);
            this.txtuserName.TabIndex = 1;
            // 
            // cmbAccountType
            // 
            this.cmbAccountType.DisplayMember = "AccountType";
            this.cmbAccountType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAccountType.FormattingEnabled = true;
            this.cmbAccountType.Location = new System.Drawing.Point(389, 79);
            this.cmbAccountType.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbAccountType.Name = "cmbAccountType";
            this.cmbAccountType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbAccountType.Size = new System.Drawing.Size(246, 27);
            this.cmbAccountType.TabIndex = 2;
            this.cmbAccountType.ValueMember = "ID";
            // 
            // cmbEmployee
            // 
            this.cmbEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmployee.FormattingEnabled = true;
            this.cmbEmployee.Location = new System.Drawing.Point(389, 114);
            this.cmbEmployee.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbEmployee.Name = "cmbEmployee";
            this.cmbEmployee.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbEmployee.Size = new System.Drawing.Size(246, 27);
            this.cmbEmployee.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(19, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(713, 2);
            this.label1.TabIndex = 7;
            // 
            // grdVwUsers
            // 
            this.grdVwUsers.AllowUserToAddRows = false;
            this.grdVwUsers.AllowUserToDeleteRows = false;
            this.grdVwUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdVwUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdVwUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colUserName,
            this.colAccountType,
            this.colRespon});
            this.grdVwUsers.Location = new System.Drawing.Point(31, 174);
            this.grdVwUsers.Name = "grdVwUsers";
            this.grdVwUsers.ReadOnly = true;
            this.grdVwUsers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grdVwUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdVwUsers.Size = new System.Drawing.Size(687, 280);
            this.grdVwUsers.TabIndex = 6;
            this.grdVwUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdVwSearch_CellClick);
            // 
            // colUserName
            // 
            this.colUserName.HeaderText = "اسم المستخدم";
            this.colUserName.Name = "colUserName";
            this.colUserName.ReadOnly = true;
            // 
            // colAccountType
            // 
            this.colAccountType.HeaderText = "نوع الحساب";
            this.colAccountType.Name = "colAccountType";
            this.colAccountType.ReadOnly = true;
            this.colAccountType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colAccountType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colRespon
            // 
            this.colRespon.HeaderText = "الموظف";
            this.colRespon.Name = "colRespon";
            this.colRespon.ReadOnly = true;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(31, 44);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPassword.Size = new System.Drawing.Size(246, 26);
            this.txtPassword.TabIndex = 4;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(31, 79);
            this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtConfirmPassword.Size = new System.Drawing.Size(246, 26);
            this.txtConfirmPassword.TabIndex = 5;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(310, 52);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(62, 19);
            this.lblPassword.TabIndex = 0;
            this.lblPassword.Text = "كلمة السر";
            this.lblPassword.Click += new System.EventHandler(this.lblEmployee_Click);
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Location = new System.Drawing.Point(283, 86);
            this.lblConfirmPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(89, 19);
            this.lblConfirmPassword.TabIndex = 0;
            this.lblConfirmPassword.Text = "تأكيد كلمة السر";
            this.lblConfirmPassword.Click += new System.EventHandler(this.lblEmployee_Click);
            // 
            // frmAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(754, 477);
            this.Controls.Add(this.grdVwUsers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbEmployee);
            this.Controls.Add(this.cmbAccountType);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtuserName);
            this.Controls.Add(this.tstrpDevices);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblEmployee);
            this.Controls.Add(this.lblAccountType);
            this.Controls.Add(this.lblUserName);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAccounts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLabs";
            this.Load += new System.EventHandler(this.frmAccounts_Load);
            this.tstrpDevices.ResumeLayout(false);
            this.tstrpDevices.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdVwUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblAccountType;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.ToolStrip tstrpDevices;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton resetToolStripButton;
        private System.Windows.Forms.TextBox txtuserName;
        private System.Windows.Forms.ComboBox cmbAccountType;
        private System.Windows.Forms.ComboBox cmbEmployee;
        private System.Windows.Forms.ToolStripButton delToolStripButton;
        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView grdVwUsers;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.TextBox txtConfirmPassword;
		private System.Windows.Forms.Label lblPassword;
		private System.Windows.Forms.Label lblConfirmPassword;
		private System.Windows.Forms.DataGridViewTextBoxColumn colUserName;
		private System.Windows.Forms.DataGridViewTextBoxColumn colAccountType;
		private System.Windows.Forms.DataGridViewTextBoxColumn colRespon;
		private System.Windows.Forms.ToolStripButton openToolStripButton;
	}
}