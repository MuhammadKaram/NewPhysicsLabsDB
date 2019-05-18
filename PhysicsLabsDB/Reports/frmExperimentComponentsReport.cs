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
            //dsExperimentComponents dsExperimentComponents = new dsExperimentComponents();
            // TODO: This line of code loads data into the 'dsExperimentComponents.devices_tb' table. You can move, or remove it, as needed.
            this.devices_tbTableAdapter.Fill(this.dsExperimentComponents.devices_tb, exp_name,lab_name,exp_num);

            rptExperimentComponents1.SetDataSource(dsExperimentComponents);
            crystalReportViewer1.ReportSource = this.rptExperimentComponents1;// chan_res_rpt_frm.change_respon_rpt1;

            //crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh();
        }
    }
}
