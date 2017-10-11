using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hspro
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private void dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you realy want to Exit the program?","Exit", MessageBoxButtons.YesNo);
            if(dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialog == DialogResult.No)
            {
                e.Cancel = true;
            }
            
        }

        private void cMToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cSSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            css_compliance cssfrm = new css_compliance();
            cssfrm.MdiParent = this;
            cssfrm.WindowState = FormWindowState.Maximized;
            cssfrm.Show();

            


        }
    }
}
