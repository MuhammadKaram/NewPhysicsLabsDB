using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhysicsLabsDB.ConnectionString
{
    public partial class frmConnectionString : Form
    {
        public frmConnectionString()
        {
            InitializeComponent();
        }

        private void btnChangeConnection_Click(object sender, EventArgs e)
        {
            string serverAddress = txtServerAddress.Text == string.Empty ? "localhost" : txtServerAddress.Text;
            string userName = txtUserName.Text;
            string password = txtPassword.Text;

            string error = string.Empty;
            //if (txtServerAddress.Text == string.Empty)
            //    error += "إدخل اسم الجهاز\n";
            if (txtUserName.Text == string.Empty)
                error += "إدخل اسم المستخدم\n";
            if (txtPassword.Text == string.Empty)
                error += "إدخل كلمة المرور\n";

            if (error != string.Empty)
            {
                MessageBox.Show(error, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
            connectionStringsSection.ConnectionStrings["ConnectionStringSQL"].ConnectionString = "server="+serverAddress+"; database=Physics_DB; uid="+userName+";pwd="+password+";";
            // replace &quot;
            const string quote = "\"";
            connectionStringsSection.ConnectionStrings["physics_dbEntities"].ConnectionString = @"metadata=res://*/physics_db.csdl|res://*/physics_db.ssdl|res://*/physics_db.msl;provider=MySql.Data.MySqlClient;provider connection string=" + quote + "server=" + serverAddress + ";user id=" + userName + ";password=" + password + @";persistsecurityinfo=True;database=physics_db" + quote;
            config.Save();
            ConfigurationManager.RefreshSection("connectionStrings");
            this.Close();
            Application.Restart();
        }
    }
}
