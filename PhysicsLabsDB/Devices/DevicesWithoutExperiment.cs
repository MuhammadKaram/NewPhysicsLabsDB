using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhysicsLabsDB.Devices
{
	public partial class DevicesWithoutExperiment : Form
	{
		physics_dbEntities db = new physics_dbEntities();

		public DevicesWithoutExperiment()
		{
			InitializeComponent();
		}

		private void DevicesWithoutExperiment_Load(object sender, EventArgs e)
		{
			cmbLabs.DataSource = db.labs.Select(u => u.lab_name).ToList();
		}

		private void cmbLabs_SelectedIndexChanged(object sender, EventArgs e)
		{
			lstWork.DataSource = db.devices_tb.Where(u => u.lab_name == cmbLabs.Text && u.exp_name == "بدون تجربة" && u.device_status == "يعمل").ToList();
			lstNotWork.DataSource = db.devices_tb.Where(u => u.lab_name == cmbLabs.Text && u.exp_name == "بدون تجربة" && u.device_status == "لا يعمل").ToList();
			lstTakhin.DataSource = db.devices_tb.Where(u => u.lab_name == cmbLabs.Text && u.exp_name == "بدون تجربة" && u.device_status == "مكهن").ToList();
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

		private void lstTakhin_DoubleClick(object sender, EventArgs e)
		{
			MessageBox.Show(GetDeviceInfo((devices_tb)lstTakhin.SelectedItem), "بيانات الجهاز", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void lstWork_DoubleClick(object sender, EventArgs e)
		{
			MessageBox.Show(GetDeviceInfo((devices_tb)lstWork.SelectedItem), "بيانات الجهاز", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void lstNotWork_DoubleClick(object sender, EventArgs e)
		{
			MessageBox.Show(GetDeviceInfo((devices_tb)lstNotWork.SelectedItem), "بيانات الجهاز", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}
