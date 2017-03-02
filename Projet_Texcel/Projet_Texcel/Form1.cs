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
        Control control;
        Connexion connexion;
        Jeu jeu;
        Platforme platforme;
        Employes employes;
        OS os;
                
        public Form1()
        {
            InitializeComponent();
            Init(false);
            InitMDI();
            control = new Control(this);
        }

        public void Init(bool value)
        {
            jeuxToolStripMenuItem.Enabled = value;
            employéToolStripMenuItem.Enabled = value;
            équipeToolStripMenuItem.Enabled = value;
            oSToolStripMenuItem.Enabled = value;
            platformeToolStripMenuItem.Enabled = value;
            connexionToolStripMenuItem.Enabled = !value;
        }

        private void InitMDI()
        {
            connexion = new Connexion();
            connexion.Text = "Connexion";
            connexion.MdiParent = this;
            connexion.StartPosition = FormStartPosition.CenterScreen;

            employes = new Employes();
            employes.Text = "Employés";
            employes.MdiParent = this;
            employes.StartPosition = FormStartPosition.CenterScreen;
        }

        private void employeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            employes.Show();
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
            connexion.Show();
        }
    }
}
