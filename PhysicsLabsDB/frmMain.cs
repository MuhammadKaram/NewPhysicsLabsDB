using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhysicsLabsDB
{
    public partial class frmMain : Form
    {
        physics_dbEntities db = new physics_dbEntities();

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Search.frmSearch frmSearch = new Search.frmSearch();
            frmSearch.MdiParent = this;
            frmSearch.Show();
        }

        private void tsbtnDevices_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            Devices.frmDevice frmDevice = new Devices.frmDevice();
            frmDevice.MdiParent = this;
            frmDevice.Show();
        }

        private void tsbtnMain_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            Search.frmSearch frmSearch = new Search.frmSearch();
            frmSearch.MdiParent = this;
            frmSearch.Show();
        }

		private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Custody.frmCustody frmCustody = new Custody.frmCustody();
			frmCustody.ShowDialog();
		}

		private void custodyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Custody.frmTransferCustody frmTransferCustody = new Custody.frmTransferCustody();
			frmTransferCustody.ShowDialog();
		}

        private void tsbtnExperiments_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            Experiments.frmExperiment frmExperiment = new Experiments.frmExperiment();
            frmExperiment.MdiParent = this;
            frmExperiment.Show();
        }

        private void tsbtnAccounts_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            Accounts.frmAccounts frmAccounts = new Accounts.frmAccounts();
            frmAccounts.MdiParent = this;
            frmAccounts.Show();
        }
    }
}
