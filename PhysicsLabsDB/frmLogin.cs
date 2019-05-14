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
            physics_dbEntities db = new physics_dbEntities();
            account loggedUser = new account();

            try
            {
                loggedUser = db.accounts.FirstOrDefault(u => u.UserName == txtUserName.Text && u.UserPassword == txtPassword.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ أثناء الاتصال بقاعدة البيانات .. من فضلك تأكد من بيانات الاتصال وحالة الخادم", "خطأ فى الاتصال", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
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
                lblError.Visible = false;
            }
        }

        private void btnStringConnection_Click(object sender, EventArgs e)
        {
            ConnectionString.frmConnectionString frmConnectionString = new ConnectionString.frmConnectionString();
            frmConnectionString.ShowDialog();
            //this.Hide();
            //txtUserName.Focus();
        }
    }
}
