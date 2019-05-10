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
	public partial class frmCustody : Form
	{
		physics_dbEntities db = new physics_dbEntities();

		public frmCustody()
		{
			InitializeComponent();
		}


		//void fillListRespon()
		//{
		//	try
		//	{
		//		lbxEmployee.DataSource = db.respons.Select(u => u.name).ToList();
		//	}
		//	catch (Exception ex)
		//	{
		//		MessageBox.Show(ex.ToString(), "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
		//	}
			
		//}

		private void btnAddEmploee_Click(object sender, EventArgs e)
		{
			string error = string.Empty;
			if (txtNameEmplyee.Text == string.Empty)
				error += "إدخل اسم المتعهد\n";

			if (error != string.Empty)
			{
				MessageBox.Show(error, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			else
			{
				try
				{
					var resp = new respon()
					{
						name = txtNameEmplyee.Text
					};
					db.respons.Add(resp);
					db.SaveChanges();

					txtNameEmplyee.Text = string.Empty;

					//lbxEmployee.Items.Clear();
					lbxEmployee.DataSource = db.respons.Select(u => u.name).ToList();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString(), "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void btnDeleteEmployee_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = MessageBox.Show("هل تريد حذف المتعهد", "رسالة تأكيد", MessageBoxButtons.YesNo);
			if (dialogResult == DialogResult.Yes)
			{
				try
				{
					var account = db.accounts.FirstOrDefault(u => u.respon1.name == lbxEmployee.Text);
					if (account != null)
					{
						MessageBox.Show("هذا الموظف مرتبط بحساب", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Information);
						return;
					}

					var checkRespon = db.devices_tb.FirstOrDefault(u => u.respon == lbxEmployee.Text);
					if (checkRespon != null)
					{
						MessageBox.Show("هذا الموظف مرتبط بعهدة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Information);
						return;
					}

					var resp = db.respons.FirstOrDefault(u => u.name == lbxEmployee.Text/* SelectedItem.ToString()*/);
					db.respons.Remove(resp);
					db.SaveChanges();

					MessageBox.Show("تم الحذف", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
					
					lbxEmployee.DataSource = db.respons.Select(u => u.name).ToList();

				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString(), "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void frmCustody_Load(object sender, EventArgs e)
		{
			lbxEmployee.DataSource = db.respons.Select(u => u.name).ToList();
		}

		private void txtNameEmplyee_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				btnAddEmploee.PerformClick();
			}

		}
	}
}
