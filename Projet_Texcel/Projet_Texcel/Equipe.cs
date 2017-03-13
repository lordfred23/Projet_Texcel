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
    public partial class Equipe : Form
    {
        static int cptEmploye = 1;
        ComboBox previousLST;
        Form1 form;
        public Equipe(Form1 form)
        {
            InitializeComponent();
            this.form = form;
            previousLST = lstEmploye1;
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            cptEmploye++;
            Equipe frmEquipe = this;
            ComboBox lstNewEmploye = new ComboBox();
            lstNewEmploye.Name = "lstEmploye" + cptEmploye;
            lstNewEmploye.Height = previousLST.Height;
            lstNewEmploye.Width = previousLST.Width;
            lstNewEmploye.Items.Add(previousLST.Items); //utiliser une fonction dans control pour chercher les employes dans BD
            lstNewEmploye.Location = previousLST.Location;
            lstNewEmploye.Top = previousLST.Height + 20;
            frmEquipe.Height += previousLST.Height + 20;
            btnCreerEquipe.Top += previousLST.Height + 20;
            lstNewEmploye.Show();
            previousLST = lstNewEmploye;
        }

        private void Equipe_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.equipeConn = false;
        }

        private void btnCreerEquipe_Click(object sender, EventArgs e)
        {

        }
    }
}
