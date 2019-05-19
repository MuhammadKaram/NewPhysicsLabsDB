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
    public partial class frmDevicesWithoutExperimentsReport : Form
    {
        public string lab { get; set; }
        public string status { get; set; }

        public frmDevicesWithoutExperimentsReport()
        {
            InitializeComponent();
        }

        private void frmDevicesWithoutExperiments_Load(object sender, EventArgs e)
        {
            dsDevicesWithoutExperiments dsDevicesWithoutExperiments = new dsDevicesWithoutExperiments();
            dsDevicesWithoutExperimentsTableAdapters.devices_tbTableAdapter devices_tbTableAdapter = new dsDevicesWithoutExperimentsTableAdapters.devices_tbTableAdapter();
            devices_tbTableAdapter.Fill(dsDevicesWithoutExperiments.devices_tb, lab, status);

            rptDevicesWithoutExperiments1.SetDataSource(dsDevicesWithoutExperiments);
            crystalReportViewer1.ReportSource = this.rptDevicesWithoutExperiments1;

            crystalReportViewer1.Refresh();
        }
    }
}
