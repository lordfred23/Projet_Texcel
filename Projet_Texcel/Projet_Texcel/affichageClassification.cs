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
    public partial class affichageClassification : Form
    {
        Form1 form;
        public affichageClassification(Form1 form)
        {
            
            InitializeComponent();
            this.form = form;
            afficher();
        }

        private void afficher()
        {
            string msg = "";
            string[] lstClassif = form.jeuRemplirListeClassification();
            foreach (string valeur in lstClassif)
            {
                msg += valeur + "\n";
            }
            txtClassif.Text = msg;

        }

        private void affichageGenre_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.afClassifConn = false;
        }
    }
}
