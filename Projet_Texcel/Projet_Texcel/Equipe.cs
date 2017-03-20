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
        int cptValide = 0;
        public Equipe(Form1 form)
        {
            InitializeComponent();
            this.form = form;
            previousLST = lstEmploye1;
            btnCreerEquipe.Enabled = false;
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            cptEmploye++;
            Equipe frmEquipe = this;
            ComboBox lstNewEmploye = new ComboBox();
            lstNewEmploye.Name = "lstEmploye" + cptEmploye;
            lstNewEmploye.Height = previousLST.Height;
            lstNewEmploye.Width = previousLST.Width;
            remplirListeEmploye(lstNewEmploye); 
            lstNewEmploye.Top = previousLST.Top + previousLST.Height + 20;
            lstNewEmploye.Left = previousLST.Left;
            frmEquipe.Height += previousLST.Height + 20;
            btnCreerEquipe.Top += previousLST.Height + 20;
            Controls.Add(lstNewEmploye);
            lstNewEmploye.TextChanged += new EventHandler(comboBox1_TextChanged);
            previousLST = lstNewEmploye;
            lstNewEmploye.Show();
        }

        private void remplirListeEmploye(ComboBox employe)
        {
            string[] travailleur = form.equipeRemplirListeEmploye();
            foreach (string valeur in travailleur)
            {
                employe.Items.Add(valeur);
            }
        }

        private void Equipe_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.equipeConn = false;
        }

        private void btnCreerEquipe_Click(object sender, EventArgs e)
        {
            picValid1.Visible = false;
            cptValide = 0;
            btnCreerEquipe.Enabled = false;
            //Code pour ajouter l'equipe a la bd
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            PictureBox image;
            int erreur = form.validate(textBox);//Envoie le textbox a valider
            if (erreur > 0)
            {
                image = (PictureBox)Controls["picError" + erreur];
                image.Visible = true;
            }
            else
            {
                cptValide++;//Ajoute un au compteur de validation
                image = (PictureBox)Controls["picError" + textBox.Tag];
                image.Visible = false;
                image = (PictureBox)Controls["picValid" + textBox.Tag];
                image.Visible = true;
            }
            if (cptValide == 1)//Nombre de textbox a valider
                btnCreerEquipe.Enabled = true;
        }
    }
}
