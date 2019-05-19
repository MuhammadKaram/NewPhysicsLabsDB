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
    public partial class frmDevicesWithoutExpReportFilter : Form
    {
        physics_dbEntities db = new physics_dbEntities();
        public string lab { get; set; }

        public frmDevicesWithoutExpReportFilter()
        {
            InitializeComponent();
        }

        private void frmDevicesWithoutExpReportFilter_Load(object sender, EventArgs e)
        {
            cmbLab.DataSource = db.labs.Select(u => u.lab_name).ToList();
            cmbLab.SelectedItem = lab;
            var status = db.device_status.Select(u => u.Status).ToList();
            status.Add("كل الحالات");
            cmbStatus.DataSource = status;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            var lab = cmbLab.SelectedItem.ToString();
            var status = cmbStatus.Text == "كل الحالات" ? null : cmbStatus.Text;

            Reports.frmDevicesWithoutExperimentsReport frmDevicesWithoutExperiments = new Reports.frmDevicesWithoutExperimentsReport();
            frmDevicesWithoutExperiments.lab = lab;
            frmDevicesWithoutExperiments.status = status;
            frmDevicesWithoutExperiments.ShowDialog();
            this.Close();
        }
    }
}
