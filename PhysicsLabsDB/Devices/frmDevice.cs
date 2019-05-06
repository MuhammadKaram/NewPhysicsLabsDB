using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhysicsLabsDB.Devices
{
    public partial class frmDevice : Form
    {
        physics_dbEntities db = new physics_dbEntities();
        object currentDevice;

        public frmDevice()
        {
            InitializeComponent();
        }

        public void ClearControls()
        {
            txtDeviceName.Text = string.Empty;
            txtDescription.Text = string.Empty;
            txtBarcode.Text = string.Empty;
            cmbEmployee.SelectedItem = null;
            cmbExperiment.SelectedItem = null;
            cmbExperimentNum.SelectedItem = null;
            cmbLab.SelectedItem = null;
            cmbStatus.SelectedItem = null;
        }

        public void ControlStatus(bool status)
        {
            txtDeviceName.Enabled =
            txtDescription.Enabled =
            txtBarcode.Enabled =
            cmbEmployee.Enabled =
            cmbExperiment.Enabled =
            cmbExperimentNum.Enabled =
            cmbLab.Enabled =
            cmbStatus.Enabled = status;

            pnlOpenSearch.Enabled = status;
        }

        private void frmDevice_Load(object sender, EventArgs e)
        {
            ClearControls();
            ControlStatus(false);
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            ClearControls();
            ControlStatus(true);
            pnlOpenSearch.Enabled = false;
            // todo
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            //todo
            //..
            //ClearControls();
            ControlStatus(false);
        }

        private void delToolStripButton_Click(object sender, EventArgs e)
        {
            //todo
            //..
            ClearControls();
            ControlStatus(false);
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            ClearControls();
            ControlStatus(false);
            pnlOpenSearch.Enabled = true;
            txtSearch.Focus();
            Search();
        }

        public void Search()
        {
            object device, barcode;
            if (rdDevice.Checked == true) { device = txtSearch.Text.Trim(); } else { device = DBNull.Value; }
            if (rdBarcode.Checked == true) { barcode = txtSearch.Text.Trim(); } else { barcode = DBNull.Value; }
            
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
            	   and (@barcode is null or device_barcode like @barcode + '%');";

            connection.Open();
            data_adabter = new SqlDataAdapter(query, connection);
            data_adabter.SelectCommand.Parameters.AddWithValue("@device", device);
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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        public void GenerateBarcode()
        {
            // To uniqe the bar code
            int? maxBarcodeDeviceID = db.devices_tb.Select(u => u.ID).Max();
            // For first barcode
            maxBarcodeDeviceID = maxBarcodeDeviceID == null ? 0 : maxBarcodeDeviceID;

            string error = string.Empty;
            if (txtDeviceName.Text == string.Empty)
                error += "إدخل اسم الجهاز\n";
            if (cmbLab.SelectedItem == null)
                error += "اختر المعمل\n";
            if (cmbExperiment.SelectedItem == null)
                error += "اختر التجربة\n";

            if (error != string.Empty)
            {
                MessageBox.Show(error);
                return;
            }

            string myBarCode = string.Empty;
            // Get the first two characters from debended items and get its ASCII code using "Convert.ToInt32"
            myBarCode = myBarCode + Convert.ToInt32(cmbLab.Text[0]) + Convert.ToInt32(cmbLab.Text[1])
                + Convert.ToInt32(cmbExperiment.Text[0]) + Convert.ToInt32(cmbExperiment.Text[1])
                + Convert.ToInt32(txtDeviceName.Text[0]) + Convert.ToInt32(txtDeviceName.Text[1]) 
                + maxBarcodeDeviceID;
            
            myBarCode = myBarCode.Substring(myBarCode.Length - 13);

            if (myBarCode[0] == '0')
                myBarCode = '1' + myBarCode.Substring(1);

            txtBarcode.Text = myBarCode;
            Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            picBarcode.Image = barcode.Draw(myBarCode, 50);
        }

        private void btnDisplayBarcode_Click(object sender, EventArgs e)
        {
            GenerateBarcode();
        }
    }
}
