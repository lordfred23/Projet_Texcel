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
    public partial class Employes : Form
    {
        Form1 form;
        public Employes(Form1 form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void btnCreerEquipe_Click(object sender, EventArgs e)
        {
            form.equipeToolStripMenuItem_Click();
        }

        private void btnCreerEmploye_Click(object sender, EventArgs e)
        {

        }

        private void Employes_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.empConn = false;
        }
    }
}
