﻿using CrystalDecisions.CrystalReports.Engine;
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
    public partial class frmTransferCustodyCrystalReport : Form
    {
        public string employeeFrom { get; set; }
        public string devicesBarcodes { get; set; }

        public frmTransferCustodyCrystalReport()
        {
            InitializeComponent();
        }

        private void frmTransferCustodyCrystalReport_Load(object sender, EventArgs e)
        {
            dsTransferCustody dsTransferCustody = new dsTransferCustody();
            dsTransferCustodyTableAdapters.devices_tbTableAdapter devices_tbTableAdapter = new dsTransferCustodyTableAdapters.devices_tbTableAdapter();
            devices_tbTableAdapter.FillByBarcodeListAndEmployeeFrom(dsTransferCustody.devices_tb, employeeFrom, devicesBarcodes);

            //ReportDocument rpt = new ReportDocument();
            //rpt.SetDataSource(dsTransferCustody);

            rptTransferCustody1.SetDataSource(dsTransferCustody);
            crystalReportViewer1.ReportSource = this.rptTransferCustody1;// chan_res_rpt_frm.change_respon_rpt1;
            
            //crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh();
        }
    }
}