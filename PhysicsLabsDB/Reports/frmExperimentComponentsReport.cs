using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhysicsLabsDB.Reports
{
    public partial class frmExperimentComponentsReport : Form
    {
        public string lab_name { get; set; }
        public string exp_name { get; set; }
        public int exp_num { get; set; }

        public frmExperimentComponentsReport()
        {
            InitializeComponent();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsExperimentComponents.devices_tb' table. You can move, or remove it, as needed.
            this.devices_tbTableAdapter.Fill(this.dsExperimentComponents.devices_tb, exp_name,lab_name,exp_num);


            this.reportViewer.RefreshReport();
        }
    }
}
