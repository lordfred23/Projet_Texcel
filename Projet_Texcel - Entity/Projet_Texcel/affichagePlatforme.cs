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
    public partial class affichagePlatforme : Form
    {
        Form1 form;
        public affichagePlatforme(Form1 form)
        {
            InitializeComponent();
            this.form = form;
            afficher();
        }

        private void afficher()
        {
            string msg = "";
            string[] lstPlatforme = form.jeuRemplirListePlatforme();
            foreach(string valeur in lstPlatforme)
            {
                msg += valeur + "\n";
            }
            txtPlatforme.Text = msg;
        }

        private void affichagePlatforme_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.afPlatformeConn = false;
        }
    }
}
