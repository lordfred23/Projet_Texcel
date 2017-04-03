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
    public partial class Connexion : Form
    {
        Form1 form;

        public Connexion(Form1 form) { InitializeComponent(); this.form = form; }

        private void button1_Click(object sender, EventArgs e)
        {
            form.connect(txtUti.Text, txtPass.Text);
            Close();   
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            int erreur = form.validate((TextBox)sender);
        }
    }
}
