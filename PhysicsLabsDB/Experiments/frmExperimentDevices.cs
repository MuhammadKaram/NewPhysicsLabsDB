using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhysicsLabsDB.Experiments
{
    public partial class frmExperimentDevices : Form
    {
        physics_dbEntities db = new physics_dbEntities();
        private string lab;
        string experiment;
        int experimentNum;

        public frmExperimentDevices()
        {
            InitializeComponent();
        }

        public frmExperimentDevices(string lab, string experiment, int experimentNum)
        {
            InitializeComponent();

            this.lab = lab;
            this.experiment = experiment;
            this.experimentNum = experimentNum;
        }

        private void frmExperimentDevices_Load(object sender, EventArgs e)
        {
            lblExperimentName.Text = experiment;
            txtExperimentNum.Text = experimentNum.ToString();
            FillListBoxes();
            ChechButtonsStatus();
        }

        private void FillListBoxes()
        {
            lstAvailableDevices.DataSource = db.devices_tb.Where(u => u.lab_name == lab && u.exp_name == "بدون تجربة").ToList();
            lstExperimentDevices.DataSource = db.devices_tb.Where(u => u.lab_name == lab && u.exp_name == experiment && u.exp_num == experimentNum).ToList();
        }

        private void ChechButtonsStatus()
        {
            btnAddDevice.Enabled = lstAvailableDevices.Items.Count > 0;
            btnRemoveDevice.Enabled = lstExperimentDevices.Items.Count > 0;
        }

        private void btnAddDevice_Click(object sender, EventArgs e)
        {
            try
            {
                devices_tb selectedDevice = (devices_tb)lstAvailableDevices.SelectedItem;
                //selectedDevice.lab_name = lab;
                selectedDevice.exp_name = experiment;
                selectedDevice.exp_num = experimentNum;
                db.SaveChanges();
                FillListBoxes();
                ChechButtonsStatus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnRemoveDevice_Click(object sender, EventArgs e)
        {
            try
            {
                devices_tb selectedDevice = (devices_tb)lstExperimentDevices.SelectedItem;
                //selectedDevice.lab_name = lab;
                selectedDevice.exp_name = "بدون تجربة";
                selectedDevice.exp_num = 0;
                db.SaveChanges();
                FillListBoxes();
                ChechButtonsStatus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private string GetDeviceInfo(devices_tb device)
        {
            string info = string.Empty;
            info += device.device_name + "\n";
            info += device.device_barcode + "\n";
            info += device.device_status + "\n";
            info += device.respon + "\n";
            info += device.lab_name + "\n";
            info += device.exp_name + "\n";
            info += device.exp_num;
            return info;
        }

        private void lstExperimentDevices_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show(GetDeviceInfo((devices_tb)lstExperimentDevices.SelectedItem), "بيانات الجهاز", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lstAvailableDevices_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show(GetDeviceInfo((devices_tb)lstAvailableDevices.SelectedItem), "بيانات الجهاز", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
