using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhysicsLabsDB.inventory
{
	public partial class frmInventory : Form
	{
		physics_dbEntities db = new physics_dbEntities();
		List<string> InventoryBarcodeList = new List<string>();

		public frmInventory()
		{
			InitializeComponent();
		}

		private void inventory_Load(object sender, EventArgs e)
		{
			grdVwInventory.AutoGenerateColumns = false;
			cmbLabs.DataSource = db.labs.Select(u => u.lab_name).ToList();
			//cmbEmployee.DataSource = db.respons.Select(u => u.name).ToList();
			Search();
		}

		private void cmbLabs_SelectedIndexChanged(object sender, EventArgs e)
		{
			var Custody = db.devices_tb.Where(u => u.lab_name == cmbLabs.Text).Select(u => u.respon).Distinct().ToList();
			cmbEmployee.DataSource = Custody;
			Search();
		}

		public void Search()
		{
			var result = db.devices_tb.Where(u => u.lab_name == cmbLabs.Text && u.respon == cmbEmployee.Text)
				.Select(u => new
				{
					DeviceName = u.device_name,
					Barcode = u.device_barcode,
					Lab = u.lab_name,
					Respon = u.respon,
					Statue = u.device_status
				}).ToList();
			grdVwInventory.DataSource = result;

			grdVwInventory.Columns["colDeviceName"].DataPropertyName = "DeviceName";
			grdVwInventory.Columns["colBarcode"].DataPropertyName = "Barcode";
			grdVwInventory.Columns["colStatue"].DataPropertyName = "Statue";
			grdVwInventory.Columns["colLab"].DataPropertyName = "Lab";
			grdVwInventory.Columns["colRespon"].DataPropertyName = "Respon";
		}


		private void DeviceInventory(string selectedBarcode)
		{
			try
			{
				//List<devices_tb> gridData = (List<devices_tb>)grdVwInventory.DataSource;
				for (int index = 0; index < grdVwInventory.Rows.Count; index++)
				{
					if (grdVwInventory.Rows[index].Cells[1].Value.ToString() == selectedBarcode)
					{
						if (grdVwInventory.Rows[index].DefaultCellStyle.BackColor != Color.Green)
						{
							grdVwInventory.Rows[index].DefaultCellStyle.BackColor = Color.Green;
							//InventoryDevices.Add((devices_tb)grdVwInventory.Rows[index]);
							//List<string> InventoryBarcodeList = new List<string>();
							InventoryBarcodeList.Add(selectedBarcode);
							txtBarcode.Text = string.Empty;
							txtBarcode.Focus();
							return;
							//var InventoryList = (List<devices_tb>)(grdVwInventory.DataSource);
							//var InventoryRow = InventoryList[index];
							//InventoryDevices.Add(InventoryRow);
						}
						else
						{
							MessageBox.Show("تم جرده من قبل", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
							return;
						}
					}
				}
				MessageBox.Show("الجهاز غير موجود", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString(), "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void cmbEmployee_SelectedIndexChanged(object sender, EventArgs e)
		{
			Search();
			InventoryBarcodeList = new List<string>();
		}

		private void txtBarcode_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				DeviceInventory(txtBarcode.Text);
			}
		}

		private void btnFinishInventory_Click(object sender, EventArgs e)
		{
			List<string> NotInventoryBarcodeList = new List<string>();

			for (int index = 0; index < grdVwInventory.Rows.Count; index++)
			{
				if (grdVwInventory.Rows[index].DefaultCellStyle.BackColor != Color.Green)
					NotInventoryBarcodeList.Add(grdVwInventory.Rows[index].Cells[1].Value.ToString());
			}
		}
	}
}
