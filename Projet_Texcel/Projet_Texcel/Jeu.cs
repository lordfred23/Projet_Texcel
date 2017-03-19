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
        Form1 form;
        int cptValide = 0;
        public Jeu(Form1 form)
        {
            InitializeComponent();
            this.form = form;
            btnCreerJeu.Enabled = false;
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
        }

        private void Jeu_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.jeuConn = false;
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
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
