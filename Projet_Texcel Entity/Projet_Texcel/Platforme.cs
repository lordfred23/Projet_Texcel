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
    public partial class Platforme : Form
    {
        Form1 form;
        int cptValide = 0;
        public Platforme(Form1 form)
        {
            InitializeComponent();
            this.form = form;
            btnCreerPlat.Enabled = false;
            chercherConfiguration();//Obtient toutes les configuration de la bd
            chercherOS();//Obtient toutes les OS de la bd
        }

        private void chercherOS()
        {

        }

        private void chercherConfiguration()
        {

        }

        private void btnCreerPlat_Click(object sender, EventArgs e)
        {
            cptValide = 0;
            picValid1.Visible = false;
            btnCreerPlat.Enabled = false;
            //Ajouter la platforme a la BD
        }

        private void btnCreerOs_Click(object sender, EventArgs e)
        {
            form.osToolStripMenuItem_Click();//Ouvre la form OS
        }

        private void Platforme_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.platConn = false;
            //platConn devient a false pour réouvrir la form, sinon on ne peut en ouvrir une seconde
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            PictureBox image;
            int erreur = form.validate(textBox);//Envoie le textbox a valider
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
            if (cptValide == 1)//Nombre de textbox a valider
                btnCreerPlat.Enabled = true;
        }
    }
}
