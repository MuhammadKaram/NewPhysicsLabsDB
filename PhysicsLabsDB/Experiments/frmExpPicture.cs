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
    public partial class frmExpPicture : Form
    {
        physics_dbEntities db = new physics_dbEntities();

        public System.IO.MemoryStream msImg { get; set; }
        public string experiment { get; set; }
        public bool deleteImage = false;

        public frmExpPicture()
        {
            InitializeComponent();
        }

        private void frmExpPicture_Load(object sender, EventArgs e)
        {
            if (msImg != null)
            {
                pictureBox.Image = Image.FromStream(msImg);
            }
            else
            {
                delToolStripButton.Enabled = false;
            }
        }

        private void delToolStripButton_Click(object sender, EventArgs e)
        {
            deleteImage = true;
            this.Close();
            //try
            //{
            //    List<exp> experiments = db.exps.Where(u => u.exp_name == experiment).ToList();
            //    foreach (exp experiment in experiments)
            //    {
            //        experiment.exp_img = null;
            //    }
            //    db.SaveChanges();
            //    MessageBox.Show("تم", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    this.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString(), "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
    }
}
