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
            PictureBox image;
            
            cptValide = 0;
            for (int i = 1; i <= 4; i++)
            {
                image = (PictureBox)Controls["picValid" + i];
                image.Visible = false;
            }
            btnCreerOS.Enabled = false;
           
        }

        private void OS_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.osConn = false;
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
            if (cptValide == 4)//Nombre de textbox a valider
                btnCreerOS.Enabled = true;
        }
    }
}
