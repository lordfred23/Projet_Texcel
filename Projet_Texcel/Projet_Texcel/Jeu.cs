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
    public partial class Jeu : Form
    {
        DBprovider db = new DBprovider();
        Form1 form;
        int cptValide = 0;
        public Jeu(Form1 form)
        {
            InitializeComponent();
            this.form = form;
            btnCreerJeu.Enabled = false;
            remplirListeGenre();
            remplirListeClassification();
            remplirListeTheme();
            remplirListePlatforme();
        }

        private void remplirListeGenre()
        {
            string[] genre = form.jeuRemplirListeGenre();
            foreach(string valeur in genre)
            {
                lstGenre.Items.Add(valeur);
            }
            lstGenre.Text = genre[genre.Count() - 1];
        }

        private void remplirListeClassification()
        {
            string[] classif = form.jeuRemplirListeClassification();
            foreach (string valeur in classif)
            {
                lstClassif.Items.Add(valeur);
            }
            lstClassif.Text = classif[classif.Count() - 1];
        }

        private void remplirListeTheme()
        {
            string[] theme = form.jeuRemplirListeTheme();
            foreach (string valeur in theme)
            {
                lstTheme.Items.Add(valeur);
            }
            lstTheme.Text = theme[theme.Count() - 1];
        }

        private void remplirListePlatforme()
        {
            string[] platforme = form.jeuRemplirListePlatforme();
            foreach (string valeur in platforme)
            {
                lstPlatforme.Items.Add(valeur);
            }
            lstPlatforme.Text = platforme[platforme.Count() - 1];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PictureBox image;
            cptValide = 0;
            btnCreerJeu.Enabled = false;
            for (int i = 1; i <= 7; i++)
            {
                image = (PictureBox)Controls["picValid" + i];
                image.Visible = false;
            }
            //Code pour inserer le jeu dans la bd
            db.AddGame(txtDev.Text, txtDesc.Text, txtConfig.Text, db.DisplayClassifID(lstClassif.Text), db.DisplayGenreID(lstGenre.Text), db.DisplayThemeID(lstTheme.Text), db.DisplayPlatformID(lstPlatforme.Text), txtNom.Text);

        }

        private void Jeu_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.jeuConn = false;
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            if(sender.GetType() == txtDesc.GetType())
            {
                cptValide++;
                picValid3.Visible = true;
                return;
            }
            TextBox textBox = (TextBox)sender;
            PictureBox image;
            int erreur = 0;
            if (Convert.ToInt32(textBox.Tag) != 4)
                erreur = form.validate(textBox);//Envoie le textbox a valider
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
            if (cptValide >= 3)//Nombre de textbox a valider
                btnCreerJeu.Enabled = true;
        }
    }
}
