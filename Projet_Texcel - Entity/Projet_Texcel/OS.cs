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
    
    public partial class OS : Form
    {
        Form1 form;
        int cptValide = 0;
        public OS(Form1 form)
        {
            InitializeComponent();
            this.form = form;
            btnCreerOS.Enabled = false;
        }

        private void button_Click(object sender, EventArgs e)
        {
            
            cptValide = 0;
            for (int i = 1; i <= 3; i++)
            {
                //image = (PictureBox)Controls["picValid" + i];
                //image.Visible = false;
            }
            btnCreerOS.Enabled = false;
            form.AddSystemExploitation(txtNom.Text,txtVersion.Text,txtEdition.Text);
            this.Close();
        }

        private void OS_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.osConn = false;
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            PictureBox image;
            int erreur = 0;
            if (Convert.ToInt32(textBox.Tag) == 4)
                erreur = form.validateTel(textBox);
            else
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
            if (cptValide == 3)//Nombre de textbox a valider
                btnCreerOS.Enabled = true;
        }
    }
}
