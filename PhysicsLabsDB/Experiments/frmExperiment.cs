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

        private void GetExperimentsNum()
        {
            var experimentsNumbers = db.exps.Where(u => u.exp_name == lstExperiments.SelectedItem.ToString()).Count();
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
            lstExperimentsDevices.DataSource = db.devices_tb.Where(u => u.lab_name == cmbLab.Text && u.exp_num == (int)lstExperimentsNum.SelectedItem).Select(u => u.device_name).ToList();
        }

        private void lstExperimentsNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstExperiments.DataSource != null)
            {
                lstExperimentsDevices.DataSource = db.devices_tb.Where(u => u.lab_name == cmbLab.Text && u.exp_name == lstExperiments.SelectedItem.ToString() && u.exp_num == (int)lstExperimentsNum.SelectedItem).Select(u => u.device_name).ToList();
            }
        }
    }
}
