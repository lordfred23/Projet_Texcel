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
    public partial class Classification : Form
    {
        DBprovider db = new DBprovider();
        Form1 form;
        int cptValide = 0;
        public Classification(Form1 form)
        {
            InitializeComponent();
            this.form = form;
            btnCreerClassif.Enabled = false;
        }

        private void btnCreerClassif_Click(object sender, EventArgs e)
        {
            db.AddClassification(txtClassif.Text, "Description");
            cptValide = 0;
            picValid1.Visible = false;
            btnCreerClassif.Enabled = false;
        }

        private void Classification_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.clasConn = false;
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
                btnCreerClassif.Enabled = true;
        }
    }
}
