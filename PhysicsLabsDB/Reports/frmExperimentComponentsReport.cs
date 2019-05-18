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
            dsExperimentComponents dsExperimentComponents = new dsExperimentComponents();
            dsExperimentComponentsTableAdapters.devices_tbTableAdapter devices_tbTableAdapter = new dsExperimentComponentsTableAdapters.devices_tbTableAdapter();
            devices_tbTableAdapter.Fill(dsExperimentComponents.devices_tb, exp_name, lab_name, exp_num);
            // if uncomment this line you must comment the previous three lines
            //this.devices_tbTableAdapter.Fill(this.dsExperimentComponents.devices_tb, exp_name,lab_name,exp_num);

            rptExperimentComponents1.SetDataSource(dsExperimentComponents);
            crystalReportViewer1.ReportSource = this.rptExperimentComponents1;
            
            crystalReportViewer1.Refresh();
        }
    }
}
