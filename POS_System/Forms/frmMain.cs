using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_System.Forms
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frm_Load(object sender, EventArgs e)
        {

        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.frmUser frmMain = new Forms.frmUser();
            frmMain.ShowDialog();
        }

        private void listsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Forms.frmRole frmMain = new Forms.frmRole();
            frmMain.ShowDialog();
        }

        private void listsToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Forms.frmPermission frmMain = new Forms.frmPermission();
            frmMain.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
