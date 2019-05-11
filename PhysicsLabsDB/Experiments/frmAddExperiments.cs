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
    public partial class frmAddExperiments : Form
    {
        physics_dbEntities db = new physics_dbEntities();
        public string lab { get; set; }

        public frmAddExperiments()
        {
            InitializeComponent();
        }

        public frmAddExperiments(string lab)
        {
            InitializeComponent();
            this.lab = lab;
        }

        private void txtExperiment_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAddExperiment.PerformClick();
            }
        }

        private void btnAddExperiment_Click(object sender, EventArgs e)
        {
            if (txtExperiment.Text == string.Empty)
            {
                MessageBox.Show("أدخل اسم التجربة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                var newExperiment = new exp()
                {
                    exp_name = txtExperiment.Text,
                    exp_num = 1,
                    lab_name = lab
                };
                db.exps.Add(newExperiment);
                db.SaveChanges();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
