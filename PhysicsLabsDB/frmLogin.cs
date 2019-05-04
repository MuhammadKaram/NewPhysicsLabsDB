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
        //// must add reference to System.Configuration  from assemblies
        //SqlConnection connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);

        public physics_dbEntities db = new physics_dbEntities();

        public static account loggedUser = new account();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SelectNextControl(ActiveControl, true, true, true, true);
                if(ActiveControl == btnLogin)
                {
                    Login();
                }
                e.Handled = true;
            }
        }

        private void Login()
        {
            loggedUser = db.accounts.FirstOrDefault(u => u.UserName == txtUserName.Text && u.UserPassword == txtPassword.Text);
            if (loggedUser == null)
            {
                lblError.Text = "بيانات الدخول خطأ";
                lblError.Visible = true;
            }
            else
            {
                frmMain frmMain = new frmMain();
                frmMain.Show();
                this.Hide();
                lblError.Visible = true;
            }
        }
    }
}
