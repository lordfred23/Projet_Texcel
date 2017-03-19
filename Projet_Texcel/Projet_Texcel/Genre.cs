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
    public partial class Genre : Form
    {
        Form1 form;
        int cptValide = 0;
        public Genre(Form1 form)
        {
            InitializeComponent();
            this.form = form;
            btnCreerGenre.Enabled = false;
        }

        private void btnCreerGenre_Click(object sender, EventArgs e)
        {
            cptValide = 0;
            picValid1.Visible = false;
            btnCreerGenre.Enabled = false;
            //Code pour ajouter le genre a la bd
        }

        private void Genre_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.genreConn = false;
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
                btnCreerGenre.Enabled = true;
        }
    }
}
