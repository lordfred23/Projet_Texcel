using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projet_Texcel.ClasseObjBd;
using System.Windows.Forms;

namespace Projet_Texcel
{
    public partial class affichageEmploye : Form
    {
        Form1 form;
        public affichageEmploye(Form1 form)
        {
            InitializeComponent();
            this.form = form;
            afficher();
        }

        private void affichageEmploye_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.afEmployeConn = false;
        }

        private void afficher()
        {
            string msg = "";
            List<CEmploye> lstEmploye = form.getListeEmployes();
            foreach(CEmploye valeur in lstEmploye)
            {
                msg += valeur.Prenom + " " + valeur.Nom + "\n" + valeur.DateNaissance + "\n" + valeur.Adresse + "\n" + valeur.NoTelephone + "\n" + valeur.NoTelephoneMaison + "\n" + valeur.PosteTelephone + "\n" + valeur.Matricule + "\n\n";
            }
            txtEmploye.Text = msg;
        }
    }
}
