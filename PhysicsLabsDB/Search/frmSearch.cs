﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhysicsLabsDB.Search
{
    public partial class frmSearch : Form
    {
        physics_dbEntities db = new physics_dbEntities();

        public frmSearch()
        {
            InitializeComponent();
        }

        private void frmSearch_Load(object sender, EventArgs e)
        {
            cmbStatus.DataSource = db.Device_Status.Select(u => u.Status).ToArray();
            cmbLab.DataSource = db.labs.Select(u => u.lab_name).ToArray();
            grdVwSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grdVwSearch.AutoGenerateColumns = false;
            Search();
        }

        private void chkLab_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLab.Checked == true) { cmbLab.Enabled = true; } else { cmbLab.Enabled = false; }
            Search();
        }

        private void chkStatus_CheckedChanged(object sender, EventArgs e)
        {
            if (chkStatus.Checked == true) { cmbStatus.Enabled = true; } else { cmbStatus.Enabled = false; }
            Search();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Search();
            //var devices_query = from devices in db.devices_tb
            //                    where devices.device_name == device
            //                    && devices.exp_name == experiment
            //                    && devices.respon == employee
            //                    && devices.device_barcode == barcode
            //                    && devices.lab_name == lab
            //                    && devices.device_status == status
            //                    select devices;
        }

        public void Search()
        {
            object device, experiment, employee, lab, status;
            object barcode;
            if (rdDevice.Checked == true) { device = txtSearch.Text; } else { device = DBNull.Value; }
            if (rdExperiment.Checked == true) { experiment = txtSearch.Text; } else { experiment = DBNull.Value; }
            if (rdEmployee.Checked == true) { employee = txtSearch.Text; } else { employee = DBNull.Value; }
            if (rdBarcode.Checked == true) { barcode = txtSearch.Text; } else { barcode = DBNull.Value; }
            if (chkLab.Checked == true) { lab = cmbLab.SelectedText; } else { lab = DBNull.Value; }
            if (chkStatus.Checked == true) { status = cmbStatus.SelectedItem; } else { status = DBNull.Value; }

            // must add reference to System.Configuration  from assemblies
            SqlConnection connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionStringSQL"].ConnectionString);
            SqlDataAdapter data_adabter = new SqlDataAdapter();
            DataTable result = new DataTable();

            string query = @"select device_name,
            	   device_barcode,
            	   lab_name,
            	   exp_name,
            	   exp_num,
            	   device_status,
            	   respon,
            	   description
            from devices_tb 
            	   where (@device is null or device_name like @device + '%')
            	   and (@experiment is null or exp_name like @experiment + '%')
            	   and (@employee is null or respon like @employee + '%')
            	   and (@lab is null or lab_name like @lab + '%')
            	   and (@status is null or device_status like @status + '%')
            	   and (@barcode is null or device_barcode like @barcode + '%');";

            connection.Open();
            data_adabter = new SqlDataAdapter(query, connection);
            data_adabter.SelectCommand.Parameters.AddWithValue("@device", device);
            data_adabter.SelectCommand.Parameters.AddWithValue("@experiment", experiment);
            data_adabter.SelectCommand.Parameters.AddWithValue("@employee", employee);
            data_adabter.SelectCommand.Parameters.AddWithValue("@lab", lab);
            data_adabter.SelectCommand.Parameters.AddWithValue("@status", status);
            data_adabter.SelectCommand.Parameters.AddWithValue("@barcode", barcode);
            data_adabter.Fill(result);
            connection.Close();

            grdVwSearch.Columns["colDeviceName"].DataPropertyName = "device_name";
            grdVwSearch.Columns["colBarcode"].DataPropertyName = "device_barcode";
            grdVwSearch.Columns["colLab"].DataPropertyName = "lab_name";
            grdVwSearch.Columns["colExperiment"].DataPropertyName = "exp_name";
            grdVwSearch.Columns["colExperimentNum"].DataPropertyName = "exp_num";
            grdVwSearch.Columns["colStatus"].DataPropertyName = "device_status";
            grdVwSearch.Columns["colEmployee"].DataPropertyName = "respon";
            grdVwSearch.Columns["colDescription"].DataPropertyName = "description";
            grdVwSearch.DataSource = result;
        }
    }
}