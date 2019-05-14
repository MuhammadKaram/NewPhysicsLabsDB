using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhysicsLabsDB.Accounts
{
    public partial class frmAccounts : Form
    {
        physics_dbEntities db = new physics_dbEntities();

        string selectedUserToEdit = null;

        Status CurrentStatus = Status.Reset;

        public frmAccounts()
        {
            InitializeComponent();
        }

        public void ClearControls()
        {
            txtuserName.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtConfirmPassword.Text = string.Empty;

            cmbEmployee.SelectedItem = null;
            cmbAccountType.SelectedItem = null;

            selectedUserToEdit = null;
        }

        public void ControlStatus(bool status)
        {
            txtuserName.Enabled =
            cmbEmployee.Enabled =
            cmbAccountType.Enabled =
            txtConfirmPassword.Enabled =
            txtPassword.Enabled = status;
            grdVwUsers.Enabled = status;
        }

        private enum Status
        {
            New,
            Edit,
            Reset,
            Save
        };

        private void ToolStripButtonStatus(Status status)
        {
            CurrentStatus = status;

            if (status == Status.New)
            {
                newToolStripButton.Enabled = false;
                openToolStripButton.Enabled = false;
                saveToolStripButton.Enabled = true;
                delToolStripButton.Enabled = false;
                resetToolStripButton.Enabled = true;
            }
            if (status == Status.Edit)
            {
                newToolStripButton.Enabled = false;
                openToolStripButton.Enabled = false;
                saveToolStripButton.Enabled = true;
                delToolStripButton.Enabled = true;
                resetToolStripButton.Enabled = true;
            }
            if (status == Status.Reset)
            {
                newToolStripButton.Enabled = true;
                openToolStripButton.Enabled = true;
                saveToolStripButton.Enabled = false;
                delToolStripButton.Enabled = false;
                resetToolStripButton.Enabled = false;
            }
            if (status == Status.Save)
            {
                newToolStripButton.Enabled = true;
                openToolStripButton.Enabled = true;
                saveToolStripButton.Enabled = false;
                delToolStripButton.Enabled = false;
                resetToolStripButton.Enabled = true;
            }
        }

        private void frmAccounts_Load(object sender, EventArgs e)
        {
            grdVwUsers.AutoGenerateColumns = false;

            cmbEmployee.DataSource = db.respons.ToList();
            cmbEmployee.DisplayMember = "name";
            cmbEmployee.ValueMember = "ID";

            cmbAccountType.DataSource = db.account_types.ToList();

            //cmbAccountType.DataSource = db.account_types.Select(u => u.AccountType).ToList();
            cmbAccountType.DisplayMember = "AccountType";
            cmbAccountType.ValueMember = "ID";
            Search();

            ClearControls();
            ControlStatus(false);
            ToolStripButtonStatus(Status.Reset);
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            ClearControls();
            ControlStatus(true);
            grdVwUsers.Enabled = false;
            ToolStripButtonStatus(Status.New);
            // todo
        }


        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            string error = string.Empty;
            if (txtuserName.Text == string.Empty)
                error += "إدخل اسم المستخدم\n";
            if (txtPassword.Text == string.Empty)
                error += "إدخل كلمة السر\n";
            if (txtConfirmPassword.Text == string.Empty)
                error += "إدخل تأكيد كلمة السر\n";
            if (cmbAccountType.SelectedItem == null)
                error += "اختر نوع الحساب\n";
            if (cmbEmployee.SelectedItem == null)
                error += "اختر الموظف\n";

            if (error != string.Empty)
            {
                MessageBox.Show(error, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                try
                {
                    if (CurrentStatus == Status.New)
                    {
                        if (CheckUserFound(txtuserName.Text))
                        {
                            MessageBox.Show("اسم المستخدم موجود مسبقاً", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        if (txtPassword.Text != txtConfirmPassword.Text)
                        {
                            MessageBox.Show("كلمة المرور غير متطابقة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        var account = new account()
                        {
                            UserName = txtuserName.Text,
                            AccountType = Convert.ToInt32(cmbAccountType.SelectedValue),
                            UserPassword = txtPassword.Text,
                            Respon = Convert.ToInt32(cmbEmployee.SelectedValue),
                        };

                        db.accounts.Add(account);
                        db.SaveChanges();
                        MessageBox.Show("تم الحفظ", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        //ClearControls();
                        ControlStatus(false);
                        ToolStripButtonStatus(Status.Save);
                        Search();
                    }
                    if (CurrentStatus == Status.Edit)
                    {
                        if (selectedUserToEdit != txtuserName.Text && CheckUserFound(txtuserName.Text))
                        {
                            MessageBox.Show("اسم المستخدم موجود مسبقاً", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        if (txtPassword.Text != txtConfirmPassword.Text)
                        {
                            MessageBox.Show("كلمة المرور غير متطابقة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        var account = db.accounts.FirstOrDefault(u => u.UserName == selectedUserToEdit);

                        if (account.account_types.AccountType == "admin")
                        {
                            var adminAccountsCount = db.accounts.Where(u => u.AccountType == account.AccountType).Count();
                            if (adminAccountsCount == 1 && Convert.ToInt32(cmbAccountType.SelectedValue) != account.AccountType)
                            {
                                MessageBox.Show("لا يمكن تعديل صلاحيات هذا الحساب", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }

                        account.UserName = txtuserName.Text;
                        account.AccountType = Convert.ToInt32(cmbAccountType.SelectedValue);
                        account.UserPassword = txtPassword.Text;
                        account.Respon = Convert.ToInt32(cmbEmployee.SelectedValue);
                        db.SaveChanges();

                        MessageBox.Show("تم التعديل", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //ClearControls();
                        ControlStatus(false);
                        ToolStripButtonStatus(Status.Save);
                        Search();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void delToolStripButton_Click(object sender, EventArgs e)
        {
            //todo
            //..
            //if()
            DialogResult dialogResult = MessageBox.Show("هل تريد حذف الحساب", "رسالة تأكيد", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    var account = db.accounts.FirstOrDefault(u => u.UserName == txtuserName.Text);
                    if (account.account_types.AccountType == "admin")
                    {
                        var adminAccountsCount = db.accounts.Where(u => u.AccountType == account.AccountType).Count();
                        if (adminAccountsCount == 1)
                        {
                            MessageBox.Show("لا يمكن حذف هذا الحساب", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    db.accounts.Remove(account);
                    db.SaveChanges();

                    MessageBox.Show("تم الحذف", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearControls();
                    ControlStatus(false);
                    ToolStripButtonStatus(Status.Reset);
                    Search();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        public void Search()
        {
            var result = db.accounts.Select(u => new
            {
                UserName = u.UserName,
                UserPassword = u.UserPassword,
                ID = u.ID,
                Respon = u.respon1.name,
                AccountType = u.account_types.AccountType
            }).ToList();
            grdVwUsers.DataSource = result;

            grdVwUsers.Columns["colUserName"].DataPropertyName = "UserName";
            grdVwUsers.Columns["colAccountType"].DataPropertyName = "AccountType";
            grdVwUsers.Columns["colRespon"].DataPropertyName = "Respon";
        }


        private void resetToolStripButton_Click(object sender, EventArgs e)
        {
            //cmbEmployee.DataSource = db.respons.Select(u => u.name).ToList();
            //cmbLab.DataSource = db.labs.Select(u => u.lab_name).ToList();
            //cmbStatus.DataSource = db.Device_Status.Select(u => u.Status).ToList();
            ClearControls();
            ControlStatus(false);
            ToolStripButtonStatus(Status.Reset);
        }

        private void grdVwSearch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var rowIndex = grdVwUsers.CurrentRow.Index;
            ClearControls();
            ControlStatus(true);
            txtuserName.Text = grdVwUsers.Rows[rowIndex].Cells[0].Value.ToString();
            selectedUserToEdit = txtuserName.Text;
            cmbAccountType.Text = grdVwUsers.Rows[rowIndex].Cells[1].Value.ToString();
            cmbEmployee.Text = grdVwUsers.Rows[rowIndex].Cells[2].Value.ToString();
            txtPassword.Text = txtConfirmPassword.Text
                = db.accounts.FirstOrDefault(u => u.UserName == txtuserName.Text).UserPassword;

            delToolStripButton.Enabled = cmbAccountType.Enabled = LoggedUser.UserName == txtuserName.Text ? false : true;
        }


        private void lblEmployee_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            ClearControls();
            ControlStatus(false);
            ToolStripButtonStatus(Status.Edit);
            grdVwUsers.Enabled = true;
            Search();
        }

        private bool CheckUserFound(string user)
        {
            return db.accounts.Any(u => u.UserName == user);
        }
    }
}
