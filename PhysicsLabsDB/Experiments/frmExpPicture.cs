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
        public System.IO.MemoryStream msImg { get; set; }

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
        }
    }
}
