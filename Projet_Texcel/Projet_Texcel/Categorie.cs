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
    public partial class Categorie : Form
    {
        Form1 form;
        int cptValide = 0;
        public Categorie(Form1 form)
        {
            InitializeComponent();
            this.form = form;
            btnCreerCatego.Enabled = false;
        }

        private void btnCreerCatego_Click(object sender, EventArgs e)
        {
            cptValide = 0;
            btnCreerCatego.Enabled = false;
            picValid1.Visible = false;
            //Code pour insérer la catego dans la BD
        }

        private void Categorie_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.cateConn = false;
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
                btnCreerCatego.Enabled = true;
        }
    }
}
