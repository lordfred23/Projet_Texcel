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
        int cptValide = 0;
        public Employes(Form1 form)
        {
            InitializeComponent();
            this.form = form;
            btnCreerEmploye.Enabled = false;
            remplirListeEquipe();
        }

        private void btnCreerEquipe_Click(object sender, EventArgs e)
        {
            form.equipeToolStripMenuItem_Click();
        }

        private void btnCreerEmploye_Click(object sender, EventArgs e)
        {
            PictureBox image;
            cptValide = 0;
            for(int i = 1; i <= 10; i++)
            {
                image = (PictureBox)groupBox1.Controls["picValid" + i];
                image.Visible = false;
            }
            btnCreerEmploye.Enabled = false;
            //Code pour ajouter l'employer dans la bd
        }

        private void Employes_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.empConn = false;
        }

        private void remplirListeEquipe()
        {
            string[] equipe = form.employeRemplirListeEquipe();
            foreach (string valeur in equipe)
            {
                lstEquipe.Items.Add(valeur);
            }
            lstEquipe.Text = equipe[equipe.Count() - 1];
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            PictureBox image;
            int erreur = 0;         

            switch (Convert.ToInt32(textBox.Tag))
            {
                case 1:
                case 2:
                    erreur = form.validate(textBox);//Envoie le textbox a valider
                    break;
                case 3:
                case 4:
                case 5:
                    erreur = form.validateDate(textBox);//Envoie le textbox pour valider la date
                    break;
                case 6:
                    erreur = form.validateAddresse(textBox);//Envoie le textbox pour valider l'addresse
                    break;
                case 7:
                    erreur = form.validateTel(textBox);//Envoie le textbox pour valider le # de telephone
                    break;
                case 8:
                    erreur = form.validateEmail(textBox);//Envoie le textbox pour valider l'email de l'employé
                    break;
                case 9:
                    erreur = form.validatePoste(textBox);//Envoie le textbox pour valider le poste
                    break;
                case 10:
                    erreur = form.validateMatricule(textBox);//Envoie le textbox pour valider le matricule
                    break;
                case 11:
                    erreur = form.validateTel(textBox);//Envoie le textbox pour valider le # de cellulaire
                    break;
            }

            if (erreur > 0)
            {
                image = (PictureBox)groupBox1.Controls["picError" + erreur];
                image.Visible = true;
            }
            else
            {
                cptValide++;//Ajoute un au compteur de validation
                image = (PictureBox)groupBox1.Controls["picError" + textBox.Tag];
                image.Visible = false;
                image = (PictureBox)groupBox1.Controls["picValid" + textBox.Tag];
                image.Visible = true;
            }
            if (cptValide == 10)//Nombre de textbox a valider
                btnCreerEmploye.Enabled = true;
        }
    }
}
