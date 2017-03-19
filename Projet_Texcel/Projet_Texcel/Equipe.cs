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
            ajoutEmploye(lstNewEmploye); 
            lstNewEmploye.Top = previousLST.Top + previousLST.Height + 20;
            lstNewEmploye.Left = previousLST.Left;
            frmEquipe.Height += previousLST.Height + 20;
            btnCreerEquipe.Top += previousLST.Height + 20;
            Controls.Add(lstNewEmploye);
            lstNewEmploye.TextChanged += new EventHandler(comboBox1_TextChanged);
            previousLST = lstNewEmploye;
            lstNewEmploye.Show();
        }

        private void ajoutEmploye(ComboBox lstNewEmploye)
        {
            //utiliser une fonction dans control pour chercher les employes dans BD
            string[] employe = new string[] { "Alexandre Tremblay", "Frédéric Côté" };
            for(int i = 0; i < employe.Count(); i++)
            {
                lstNewEmploye.Items.Add(employe[i]);
            }
        }

        private void Equipe_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.equipeConn = false;
        }

        private void btnCreerEquipe_Click(object sender, EventArgs e)
        {

        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            int erreur = form.validate((TextBox)sender);
        }
    }
}
