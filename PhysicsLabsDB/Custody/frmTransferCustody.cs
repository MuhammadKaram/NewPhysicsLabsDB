using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhysicsLabsDB.Custody
{
	public partial class frmTransferCustody : Form
	{
		physics_dbEntities db = new physics_dbEntities();

		public frmTransferCustody()
		{
			InitializeComponent();
		}

		private void btnTransfer_Click(object sender, EventArgs e)
		{
			try
			{
				DialogResult dialogResult = MessageBox.Show("هل تريد نقل المتعهد", "رسالة تأكيد", MessageBoxButtons.YesNo);
				if (dialogResult == DialogResult.Yes)
				{
					List<devices_tb> OldRespon = db.devices_tb.Where(u => u.lab_name == cmbLab.Text && u.respon == cmbCurrentCustody.Text).ToList();

					foreach (var r in OldRespon)
					{
						r.respon = cmbNewCustody.Text;
					}
					db.SaveChanges();

					//cmbNewCustody.Text = string.Empty;

					//lbxEmployee.Items.Clear();
					var CurrentCustody = db.devices_tb.Where(u => u.lab_name == cmbLab.Text).Select(u => u.respon).Distinct().ToList();
					cmbCurrentCustody.DataSource = CurrentCustody;
					//cmbNewCustody.DataSource = db.respons.Select(u => u.name).ToList();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString(), "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void frmTransferCustody_Load(object sender, EventArgs e)
		{
			cmbLab.DataSource = db.labs.Select(u => u.lab_name).ToList();
			//cmbCurrentCustody.DataSource = db.devices_tb.Where(u => u.lab_name == cmbLab.Text).Select(u => u.respon).ToList();
			//cmbCurrentCustody.DataSource = db.respons.Select(u => u.name).ToList();
			cmbNewCustody.DataSource = db.respons.Select(u => u.name).ToList();
		}

		private void cmbLab_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cmbLab.SelectedItem == null)
			{
				cmbCurrentCustody.DataSource = null;
			}
			else
			{
				var CurrentCustody = db.devices_tb.Where(u => u.lab_name == cmbLab.Text).Select(u => u.respon).Distinct().ToList();
				cmbCurrentCustody.DataSource = CurrentCustody;
			}
		}
	}
}
