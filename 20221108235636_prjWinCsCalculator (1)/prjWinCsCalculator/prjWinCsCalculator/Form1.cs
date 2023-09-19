using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjWinCsCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Programmes_Opening(object sender, CancelEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void mnuView_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void mnuVStandard_Click(object sender, EventArgs e)
        {
            Calculator frmca = new Calculator();

            //lets show the frmca
            frmca.Show();
            frmca.MdiParent = this;
        }

        private void mnuVScientifique_Click(object sender, EventArgs e)
        {
            frmScientific frmSc = new frmScientific();

            //lets show the frmsc
            frmSc.Show();
            frmSc.MdiParent = this;
        }

        private void mnuUserManual_Click(object sender, EventArgs e)
        {
            frmAbout frmAb = new frmAbout();

            //lets show the frmAb
            frmAb.Show();
            frmAb.MdiParent = this;
        }

        private void mnuToolbar_Click(object sender, EventArgs e)
        {
            if(mnuToolbar.Checked = false)
            {
                mnuToolbar.Visible = false;
            }
        }

        private void mnuStatusbar_Click(object sender, EventArgs e)
        {
            if(mnuStatusbar.Checked = false)
            {
                mnuStatusbar.Visible = false;
            }
        }
    }
}
