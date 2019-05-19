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
    public partial class frmInventoryReport : Form
    {
        public string lab { get; set; }
        public string respon { get; set; }
        public string inventoryBarcodes { get; set; }
        public string notInventoryBarcodes { get; set; }

        public frmInventoryReport()
        {
            InitializeComponent();
        }

        private void frmInventoryReport_Load(object sender, EventArgs e)
        {
            dsInventory dsInventory = new dsInventory();
            dsInventoryTableAdapters.devices_tbTableAdapter devices_tbTableAdapter = new dsInventoryTableAdapters.devices_tbTableAdapter();
            //dsInventory.EnforceConstraints = false;
            devices_tbTableAdapter.FillByBarcodes(dsInventory.devices_tb, lab, respon, inventoryBarcodes, notInventoryBarcodes);

            rptInventory1.SetDataSource(dsInventory);
            crystalReportViewer1.ReportSource = this.rptInventory1;

            crystalReportViewer1.Refresh();
        }
    }
}
