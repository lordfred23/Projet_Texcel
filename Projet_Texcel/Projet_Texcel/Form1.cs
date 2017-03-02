using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_Texcel
{
    public partial class Form1 : Form
    {
        Control control = new Control();
        public Form1()
        {
            InitializeComponent();
            Init(false);
        }

        public void Init(bool value)
        {
            jeuxToolStripMenuItem.Enabled = value;
            employéToolStripMenuItem.Enabled = value;
            équipeToolStripMenuItem.Enabled = value;
            oSToolStripMenuItem.Enabled = value;
            platformeToolStripMenuItem.Enabled = value;
        }

        private void employeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void equipeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void osToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void platformeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void connexionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
