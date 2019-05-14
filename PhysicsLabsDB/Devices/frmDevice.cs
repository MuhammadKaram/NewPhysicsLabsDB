using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhysicsLabsDB.Devices
{
    public partial class frmDevice : Form
    {
        physics_dbEntities db = new physics_dbEntities();
        public devices_tb currentDevice = null;

        Status CurrentStatus = Status.Reset;

        public frmDevice()
        {
            InitializeComponent();
        }

        public frmDevice(devices_tb currentDevice)// : base()
        {
            this.currentDevice = currentDevice;

            InitializeComponent();

            ClearControls();
            ControlStatus(true);
            btnDisplayBarcode.Enabled = false;
            ToolStripButtonStatus(Status.Edit);
            pnlOpenSearch.Enabled = true;
            Search();
            txtDeviceName.Text = currentDevice.device_name;
            txtBarcode.Text = currentDevice.device_barcode.ToString();
            cmbLab.SelectedItem = currentDevice.lab_name;
            cmbExperiment.SelectedItem = currentDevice.exp_name;
            cmbExperimentNum.SelectedItem = currentDevice.exp_num;
            cmbStatus.SelectedItem = currentDevice.device_status;
            cmbEmployee.SelectedItem = currentDevice.respon;
            txtDescription.Text = currentDevice.description;
            Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            picBarcode.Image = barcode.Draw(currentDevice.device_barcode.ToString(), 50);
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
            picBarcode.Image = null;
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
            cmbStatus.Enabled =
            btnDisplayBarcode.Enabled = status;

            pnlOpenSearch.Enabled = status;
        }

        private enum Status
        {
            New,
            Edit,
            Reset,
            Save
        };

        private void ToolStripButtonStatus(Status status)
        {
            CurrentStatus = status;

            if (status == Status.New)
            {
                newToolStripButton.Enabled = false;
                openToolStripButton.Enabled = false;
                saveToolStripButton.Enabled = true;
                delToolStripButton.Enabled = false;
                resetToolStripButton.Enabled = true;
            }
            if (status == Status.Edit)
            {
                newToolStripButton.Enabled = false;
                openToolStripButton.Enabled = false;
                saveToolStripButton.Enabled = true;
                delToolStripButton.Enabled = true;
                resetToolStripButton.Enabled = true;
            }
            if (status == Status.Reset)
            {
                newToolStripButton.Enabled = true;
                openToolStripButton.Enabled = true;
                saveToolStripButton.Enabled = false;
                delToolStripButton.Enabled = false;
                resetToolStripButton.Enabled = false;
            }
            if (status == Status.Save)
            {
                newToolStripButton.Enabled = true;
                openToolStripButton.Enabled = true;
                saveToolStripButton.Enabled = false;
                delToolStripButton.Enabled = false;
                resetToolStripButton.Enabled = true;
            }
        }

        private void frmDevice_Load(object sender, EventArgs e)
        {
            cmbEmployee.DataSource = db.respons.Select(u => u.name).ToList();
            //cmbExperiment.DataSource = db.exps.Select(u => u.exp_name).ToList();
            //cmbExperimentNum.DataSource = db.exps.Select(u => u.exp_num);
            cmbLab.DataSource = db.labs.Select(u => u.lab_name).ToList();
            cmbStatus.DataSource = db.device_status.Select(u => u.Status).ToList();
            if (currentDevice == null)
            {
                ClearControls();
                ControlStatus(false);
                ToolStripButtonStatus(Status.Reset);
            }
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            ClearControls();
            ControlStatus(true);
            pnlOpenSearch.Enabled = false;
            ToolStripButtonStatus(Status.New);
            // todo
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            string error = string.Empty;
            if (txtDeviceName.Text == string.Empty)
                error += "إدخل اسم الجهاز\n";
            if (cmbLab.SelectedItem == null)
                error += "اختر المعمل\n";
            if (cmbExperiment.SelectedItem == null)
                error += "اختر التجربة\n";
            if (cmbStatus.SelectedItem == null)
                error += "اختر حالة الجهاز\n";

            if (error != string.Empty)
            {
                MessageBox.Show(error, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                try
                {
                    if (CurrentStatus == Status.New)
                    {
                        GenerateBarcode();

                        var device = new devices_tb()
                        {
                            device_name = txtDeviceName.Text,
                            device_barcode = Convert.ToDecimal(txtBarcode.Text),
                            device_status = cmbStatus.Text,
                            lab_name = cmbLab.Text,
                            exp_name = cmbExperiment.Text,
                            exp_num = Convert.ToInt32(cmbExperimentNum.SelectedItem == null ? 0 : Convert.ToInt32(cmbExperimentNum.Text)),
                            respon = cmbEmployee.Text,
                            description = txtDescription.Text
                        };

                        db.devices_tb.Add(device);
                        db.SaveChanges();

                        MessageBox.Show("تم الحفظ", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //ClearControls();
                        ControlStatus(false);
                        ToolStripButtonStatus(Status.Save);
                    }
                    if (CurrentStatus == Status.Edit)
                    {
                        var selectedItemBarcode = Convert.ToDecimal(txtBarcode.Text);
                        var device = db.devices_tb.FirstOrDefault(u => u.device_barcode == selectedItemBarcode);
                        device.device_name = txtDeviceName.Text;
                        device.device_barcode = Convert.ToDecimal(txtBarcode.Text);
                        device.device_status = cmbStatus.Text;
                        device.lab_name = cmbLab.Text;
                        device.exp_name = cmbExperiment.Text;
                        device.exp_num = Convert.ToInt32(cmbExperimentNum.SelectedItem == null ? 0 : Convert.ToInt32(cmbExperimentNum.Text));
                        device.respon = cmbEmployee.Text;
                        device.description = txtDescription.Text;
                        db.SaveChanges();

                        MessageBox.Show("تم التعديل", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //ClearControls();
                        ControlStatus(false);
                        ToolStripButtonStatus(Status.Save);
                        Search();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void delToolStripButton_Click(object sender, EventArgs e)
        {
            //todo
            //..
            DialogResult dialogResult = MessageBox.Show("هل تريد حذف الجهاز", "رسالة تأكيد", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    var selectedItemBarcode = Convert.ToDecimal(txtBarcode.Text);
                    var device = db.devices_tb.FirstOrDefault(u => u.device_barcode == selectedItemBarcode);
                    db.devices_tb.Remove(device);
                    db.SaveChanges();

                    MessageBox.Show("تم الحذف", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearControls();
                    ControlStatus(false);
                    ToolStripButtonStatus(Status.Reset);
                    Search();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            ClearControls();
            ControlStatus(false);
            ToolStripButtonStatus(Status.Edit);
            //btnDisplayBarcode.Enabled = false;
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
            MySqlConnection connection = new MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionStringSQL"].ConnectionString);
            MySqlDataAdapter data_adabter = new MySqlDataAdapter();
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
            	   where (@device is null or device_name like CONCAT(@device, '%'))
            	   and (@barcode is null or device_barcode like CONCAT(@barcode, '%'));";

            connection.Open();
            data_adabter = new MySqlDataAdapter(query, connection);
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
            int? maxBarcodeDeviceID = db.devices_tb.Max(u => u.ID);//Select(u => u.ID).Max();
            // For first barcode
            maxBarcodeDeviceID = maxBarcodeDeviceID == null ? 0 : maxBarcodeDeviceID;
            maxBarcodeDeviceID += 1;

            string myBarCode = string.Empty;
            // Get the first two characters from debended items and get its ASCII code using "Convert.ToInt32"
            myBarCode = myBarCode + maxBarcodeDeviceID 
                + Convert.ToInt32(cmbLab.Text[0]) + Convert.ToInt32(cmbLab.Text[1])
                + Convert.ToInt32(cmbExperiment.Text[0]) + Convert.ToInt32(cmbExperiment.Text[1])
                + Convert.ToInt32(txtDeviceName.Text[0]) + Convert.ToInt32(txtDeviceName.Text[1]);
                //+maxBarcodeDeviceID

            myBarCode = myBarCode.Substring(myBarCode.Length - 13);

            //if (myBarCode[0] == '0')
            //    myBarCode = '1' + myBarCode.Substring(1);

            txtBarcode.Text = myBarCode;
            Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            picBarcode.Image = barcode.Draw(myBarCode, 50);
        }

        private void btnDisplayBarcode_Click(object sender, EventArgs e)
        {
            string error = string.Empty;
            if (txtDeviceName.Text == string.Empty)
                error += "إدخل اسم الجهاز\n";
            if (cmbLab.SelectedItem == null)
                error += "اختر المعمل\n";
            if (cmbExperiment.SelectedItem == null)
                error += "اختر التجربة\n";

            if (error != string.Empty)
            {
                MessageBox.Show(error, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                GenerateBarcode();
            }
        }

        private void cmbLab_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillcmbExperiment();
            FillcmbExperimentNum();
        }

        private void cmbExperiment_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillcmbExperimentNum();
        }

        public void FillcmbExperimentNum()
        {
            if (cmbExperiment.SelectedItem == null)
            {
                cmbExperimentNum.DataSource = null;
            }
            else
            {
                var experiment = db.exps.Where(u => u.exp_name == cmbExperiment.Text).Select(u => u.exp_num).Distinct().ToList();
                cmbExperimentNum.DataSource = experiment;
            }
        }

        public void FillcmbExperiment()
        {
            if (cmbLab.SelectedItem == null)
            {
                cmbExperiment.DataSource = null;
            }
            else
            {
                var experiment = db.exps.Where(u => u.lab_name == cmbLab.Text).Select(u => u.exp_name).Distinct().ToList();
                experiment.Add("بدون تجربة");
                cmbExperiment.DataSource = experiment;
            }
        }

        private void resetToolStripButton_Click(object sender, EventArgs e)
        {
            //cmbEmployee.DataSource = db.respons.Select(u => u.name).ToList();
            //cmbLab.DataSource = db.labs.Select(u => u.lab_name).ToList();
            //cmbStatus.DataSource = db.Device_Status.Select(u => u.Status).ToList();
            ClearControls();
            ControlStatus(false);
            ToolStripButtonStatus(Status.Reset);
        }

        private void grdVwSearch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var rowIndex = grdVwSearch.CurrentRow.Index; //SelectedCells[0].RowIndex;
            ClearControls();
            ControlStatus(true);
            btnDisplayBarcode.Enabled = false;
            //DataGridViewRow selectedRow = grdVwSearch.Rows[rowIndex];
            txtDeviceName.Text = grdVwSearch.Rows[rowIndex].Cells[0].Value.ToString();
            txtBarcode.Text = grdVwSearch.Rows[rowIndex].Cells[1].Value.ToString();
            cmbLab.SelectedItem = grdVwSearch.Rows[rowIndex].Cells[2].Value.ToString();
            cmbExperiment.SelectedItem = grdVwSearch.Rows[rowIndex].Cells[3].Value.ToString();
            cmbExperimentNum.SelectedItem = grdVwSearch.Rows[rowIndex].Cells[4].Value.ToString();
            cmbStatus.SelectedItem = grdVwSearch.Rows[rowIndex].Cells[5].Value.ToString();
            cmbEmployee.SelectedItem = grdVwSearch.Rows[rowIndex].Cells[6].Value.ToString();
            txtDescription.Text = grdVwSearch.Rows[rowIndex].Cells[7].Value.ToString();
            Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            picBarcode.Image = barcode.Draw(txtBarcode.Text, 50);
        }

        private void picBarcode_DoubleClick(object sender, EventArgs e)
        {
            PrintDialog pd = new PrintDialog();
            PrintDocument doc = new PrintDocument();
            doc.PrintPage += Doc_PrintPage;
            pd.Document = doc;
            if (pd.ShowDialog() == DialogResult.OK)
                doc.Print();
        }

        private void Doc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(picBarcode.Width, picBarcode.Height);
            picBarcode.DrawToBitmap(bm, new Rectangle(0, 0, picBarcode.Width, picBarcode.Height));
            e.Graphics.DrawImage(bm, 0, 0);
            bm.Dispose();
        }

        private void rdBarcode_CheckedChanged(object sender, EventArgs e)
        {
            Search();
        }
    }
}
