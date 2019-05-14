using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PhysicsLabsDB
{
    public partial class frmLogin : Form
    {
        physics_dbEntities db = new physics_dbEntities();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void Login()
        {
            account loggedUser = db.accounts.FirstOrDefault(u => u.UserName == txtUserName.Text && u.UserPassword == txtPassword.Text);
            if (loggedUser == null)
            {
                lblError.Text = "بيانات الدخول خطأ";
                lblError.Visible = true;
                txtUserName.Text = txtPassword.Text = string.Empty;
                txtUserName.Focus();
            }
            else
            {
                LoggedUser.FillLoggedUser(loggedUser);
                frmMain frmMain = new frmMain();
                frmMain.Show();
                this.Hide();
                lblError.Visible = true;
            }
        }
    }
}
