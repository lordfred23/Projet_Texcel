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
    public partial class afficherEquipe : Form
    {
        Form1 form;
        public afficherEquipe(Form1 form)
        {
            InitializeComponent();
            this.form = form;
            afficher();
        }

        private void afficher()
        {
            string msg = "";
            string[] lstEquipe = form.employeRemplirListeEquipe();
            foreach (string valeur in lstEquipe)
            {
                msg += valeur + "\n";
            }
            txtEquipe.Text = msg;
        }

        private void affichageGenre_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.afEquipeConn = false;
        }
    }
}
