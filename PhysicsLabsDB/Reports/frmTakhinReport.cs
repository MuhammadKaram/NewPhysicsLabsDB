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
    public partial class frmTakhinReport : Form
    {
        public string barcodes { get; set; }

        public frmTakhinReport()
        {
            InitializeComponent();
        }

        private void frmTakhinReport_Load(object sender, EventArgs e)
        {
            dsTakhin dsTakhin = new dsTakhin();
            dsTakhinTableAdapters.devices_tbTableAdapter devices_tbTableAdapter = new dsTakhinTableAdapters.devices_tbTableAdapter();
            devices_tbTableAdapter.FillByBarcodes(dsTakhin.devices_tb, barcodes);

            rptTakhin1.SetDataSource(dsTakhin);
            crystalReportViewer1.ReportSource = this.rptTakhin1;
            
            crystalReportViewer1.Refresh();
        }
    }
}
