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
    public partial class frmExperiment : Form
    {
        physics_dbEntities db = new physics_dbEntities();

        public frmExperiment()
        {
            InitializeComponent();
        }

        private void frmExperiment_Load(object sender, EventArgs e)
        {
            cmbLab.DataSource = db.labs.Select(u => u.lab_name).ToList();
            lstExperiments.DataSource = db.exps.Where(u => u.lab_name == cmbLab.Text).Select(u => u.exp_name).Distinct().ToList();
        }

        private void btnAddExperiment_Click(object sender, EventArgs e)
        {
            frmAddExperiments frmAddExperiments = new frmAddExperiments(cmbLab.Text);
            frmAddExperiments.ShowDialog();
            lstExperiments.DataSource = db.exps.Where(u => u.lab_name == cmbLab.Text).Select(u => u.exp_name).Distinct().ToList();
            GetExperimentsNum();
        }

        private void btnDeleteExperiment_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("هل تريد حذف التجربة", "رسالة تأكيد", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    var selectedExperiment = lstExperiments.SelectedItem.ToString();
                    var experiment = db.exps.Where(u => u.exp_name == selectedExperiment);
                    foreach (var exp in experiment)
                    {
                        db.exps.Remove(exp);
                    }

                    var devices = db.devices_tb.Where(u => u.exp_name == selectedExperiment);
                    foreach (var device in devices)
                    {
                        device.exp_name = "بدون تجربة";
                        device.exp_num = 0;
                    }

                    db.SaveChanges();
                    lstExperiments.DataSource = db.exps.Where(u => u.lab_name == cmbLab.Text).Select(u => u.exp_name).Distinct().ToList();
                    GetExperimentsNum();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void lstExperiments_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstExperiments.DataSource != null)
            {
                lstExperimentsNum.DataSource = db.exps.Where(u => u.exp_name == lstExperiments.SelectedItem.ToString()).Select(u => u.exp_num).ToList();
                GetExperimentsNum();
            }
        }

        private void btnAddExpCopy_Click(object sender, EventArgs e)
        {
            try
            {
                var maxExpNum = db.exps.Where(u => u.exp_name == lstExperiments.SelectedItem.ToString()).Select(u => u.exp_num).Max();
                var newExperiment = new exp()
                {
                    exp_name = lstExperiments.SelectedItem.ToString(),
                    exp_num = maxExpNum + 1,
                    lab_name = cmbLab.Text
                };
                db.exps.Add(newExperiment);
                db.SaveChanges();
                lstExperimentsNum.DataSource = db.exps.Where(u => u.exp_name == lstExperiments.SelectedItem.ToString()).Select(u => u.exp_num).ToList();
                GetExperimentsNum();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnDeleteExpCopy_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("هل تريد حذف نسخة التجربة", "رسالة تأكيد", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    var selectedExperiment = lstExperiments.SelectedItem.ToString();
                    var selectedExperimentNum = (int)lstExperimentsNum.SelectedItem;
                    var experiment = db.exps.Where(u => u.exp_name == selectedExperiment && u.exp_num == selectedExperimentNum);
                    foreach (var exp in experiment)
                    {
                        db.exps.Remove(exp);
                    }

                    var devices = db.devices_tb.Where(u => u.exp_name == selectedExperiment && u.exp_num == selectedExperimentNum);
                    foreach (var device in devices)
                    {
                        device.exp_name = "بدون تجربة";
                        device.exp_num = 0;
                    }

                    db.SaveChanges();
                    lstExperimentsNum.DataSource = db.exps.Where(u => u.exp_name == lstExperiments.SelectedItem.ToString()).Select(u => u.exp_num).ToList();
                    GetExperimentsNum();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void GetExperimentsNum()
        {
            var experimentsNumbers = db.exps.Where(u => u.exp_name == lstExperiments.SelectedItem.ToString() && u.lab_name == cmbLab.Text).Count();
            txtExperimetNum.Text = experimentsNumbers.ToString();
        }

        private void ClearControls()
        {
            lstExperiments.DataSource = null;
            lstExperimentsNum.DataSource = null;
            lstExperimentsDevices.DataSource = null;
            txtExperimetNum.Text = string.Empty;
        }

        private void cmbLab_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearControls();
            lstExperiments.DataSource = db.exps.Where(u => u.lab_name == cmbLab.Text).Select(u => u.exp_name).Distinct().ToList();
        }

        private void btnEditExpDevices_Click(object sender, EventArgs e)
        {
            frmExperimentDevices frmExperimentDevices = new frmExperimentDevices(cmbLab.Text, lstExperiments.SelectedItem.ToString(), (int)lstExperimentsNum.SelectedItem);
            frmExperimentDevices.ShowDialog();
            lstExperimentsDevices.DataSource = db.devices_tb.Where(u => u.lab_name == cmbLab.Text && u.exp_num == (int)lstExperimentsNum.SelectedItem).ToList();
            lstExperimentsDevices.DisplayMember = "device_name";
            lstExperimentsDevices.ValueMember = "ID";
        }

        private void lstExperimentsNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstExperiments.DataSource != null)
            {
                lstExperimentsDevices.DataSource = db.devices_tb.Where(u => u.lab_name == cmbLab.Text && u.exp_name == lstExperiments.SelectedItem.ToString() && u.exp_num == (int)lstExperimentsNum.SelectedItem).ToList();
                lstExperimentsDevices.DisplayMember = "device_name";
                lstExperimentsDevices.ValueMember = "ID";
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

        private void lstExperimentsDevices_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show(GetDeviceInfo((devices_tb)lstExperimentsDevices.SelectedItem), "بيانات الجهاز", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lstExperimentsNum_DoubleClick(object sender, EventArgs e)
        {
            Reports.frmExperimentComponentsReport frmExperimentComponentsReport = new Reports.frmExperimentComponentsReport();
            frmExperimentComponentsReport.lab_name = cmbLab.Text;
            frmExperimentComponentsReport.exp_name = lstExperiments.SelectedItem.ToString();
            frmExperimentComponentsReport.exp_num = Convert.ToInt32(lstExperimentsNum.SelectedItem);
            frmExperimentComponentsReport.ShowDialog();
        }

        private void btnExperimentsPicture_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog opendlg = new OpenFileDialog();
                if (opendlg.ShowDialog() == DialogResult.OK)
                {
                    Image image = Image.FromFile(opendlg.FileName);
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    image.Save(ms, image.RawFormat);
                    List<exp> experiments = db.exps.Where(u => u.exp_name == lstExperiments.SelectedItem.ToString()).ToList();
                    foreach (exp experiment in experiments)
                    {
                        experiment.exp_img = ms.ToArray();
                    }
                    db.SaveChanges();
                    MessageBox.Show("تم", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lstExperiments_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                var experiment = db.exps.FirstOrDefault(u => u.exp_name == lstExperiments.SelectedItem.ToString());
                byte[] expImageArray = experiment.exp_img;
                frmExpPicture frmExpPicture = new frmExpPicture();
                frmExpPicture.experiment = lstExperiments.SelectedItem.ToString();
                if (expImageArray != null)
                {
                    System.IO.MemoryStream ms = new System.IO.MemoryStream(expImageArray);
                    frmExpPicture.msImg = ms;
                }
                frmExpPicture.ShowDialog();

                if(frmExpPicture.deleteImage == true)
                {
                    List<exp> experiments = db.exps.Where(u => u.exp_name == lstExperiments.SelectedItem.ToString()).ToList();
                    foreach (exp exp in experiments)
                    {
                        exp.exp_img = null;
                    }
                    db.SaveChanges();
                    MessageBox.Show("تم", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
