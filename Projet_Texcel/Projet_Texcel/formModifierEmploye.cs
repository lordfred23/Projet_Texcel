using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projet_Texcel.ClasseObjBd;

namespace Projet_Texcel
{
    public partial class formModifierEmploye : Form
    {
        Form1 form;
        List<CEmploye> lstEmploye;
        public formModifierEmploye(Form1 form, string employe, int index)
        {
            InitializeComponent();
            this.form = form;
            remplirChamps(index);
        }

        private void remplirChamps(int index)
        {
            lstEmploye = form.getListeEmployes();
            CEmploye employe = lstEmploye[index];
            string dateNaissance = employe.DateNaissance;
            string[] date = dateNaissance.Split(new char(), ' ');

            txtPrenom.Text = employe.Prenom;
            txtNom.Text = employe.Nom;
            txtAnnee.Text = date[3];
            txtMois.Text = Convert.ToString(trouverMois(date[2]));
            txtJours.Text = date[1];
            txtAdresse.Text = employe.Adresse;
            txtCellulaire.Text = employe.NoTelephone;
            txtTeleResid.Text = employe.NoTelephoneMaison;
            txtTelePoste.Text = employe.PosteTelephone;
            txtMatricule.Text = employe.Matricule;
            txtCour.Text = "";
        }

        private int trouverMois(string mois)
        {
            switch (mois)
            {
                case "janvier":
                    return 1;
                case "février":
                    return 2;
                case "mars":
                    return 3;
                case "avril":
                    return 4;
                case "mai":
                    return 5;
                case "juin":
                    return 6;
                case "juillet":
                    return 7;
                case "août":
                    return 8;
                case "septembre":
                    return 9;
                case "octobre":
                    return 10;
                case "novembre":
                    return 11;
                case "décembre":
                    return 12;
            }
            return 0;
        }
        private void btnModifierEmploye_Click(object sender, EventArgs e)
        {
            
        }

        private void formModifierEmploye_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.formModEmployeConn = false;
        }
    }
}
