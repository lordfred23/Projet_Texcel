using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projet_Texcel.ClasseObjBd; //  heyhey namespace different pour les classes de "BD" alex.

namespace Projet_Texcel
{
    class Control
    {
        DBprovider BD = new DBprovider();       
        
        public Control() { }

        public bool connexion(string uti, string pass)
        {
            bool connexion = false;
            if ((uti == "admin") && (pass == "admin"))
                connexion = true;
            return connexion;
            //return BD.connexion(uti,pass); retour d'un tableau bool[] ( [0] = uti ok? [1] directeur ou admin )
        }

        public void erreur(string erreur)
        {
            MessageBox.Show(erreur);
        }

        public void AddSystemExploitation(string nom, string version, string edition)
        {
            BD.AddSystemExploitation(nom, version, edition);
        }

        public void AddTheme(string theme, string desc)
        {
            BD.AddTheme(desc, desc);
        }

        public void AddClassification(string classif, string desc)
        {
            BD.AddClassification(classif, desc);
        }

        public void AddEmploye(string matricule, string nom, string prenom, string annee, string mois, string jour, string addresse, string cellulaire, string telePoste, string teleResid, string role)
        {
            BD.AddEmploye(matricule, nom, prenom, annee + mois + jour, addresse, cellulaire, telePoste, teleResid, BD.DisplayRoleID(role));
        }

        public void AddGenre(string genre, string desc)
        {
            BD.AddGenre(genre, desc);
        }

        public string[] employeRemplirListeEquipe()
        {
            List<CEquipe> equipe = BD.DisplayEquipe();
            string[] lstEquipe = new string[equipe.Count];
            int i = 0;
            foreach (CEquipe valeur in equipe)
            {
                lstEquipe[i] = valeur.Nom;
                i++;
            }
            return lstEquipe;
        }

        public string[] employeRemplirListeRole()
        {
            List<CRole> role = BD.DisplayRole();
            string[] lstRole = new string[role.Count];
            int i = 0;
            foreach (CRole valeur in role)
            {
                lstRole[i] = valeur.Nom;
                i++;
            }
            return lstRole;
        }

        public string[] equipeRemplirListeEmploye()
        {
            List<CEmploye> emp = BD.DisplayEmploye();
            string[] lstEmp = new string[emp.Count];
            int i = 0;
            foreach (CEmploye valeur in emp)
            {
                lstEmp[i] = valeur.Prenom + valeur.Nom;
                i++;
            }
            return lstEmp;
        }

        public string[] jeuRemplirListeGenre()
        {
            List<CGenre> genre = BD.DisplayGenre();
            string[] lstGenre = new string[genre.Count];
            int i = 0;
            foreach (CGenre valeur in genre)
            {
                lstGenre[i] = valeur.Nom;
                i++;
            }
            return lstGenre;
        }

        public string[] jeuRemplirListeTheme()
        {
            List<CTheme> theme = BD.DisplayTheme();
            string[] lstTheme = new string[theme.Count];
            int i = 0;
            foreach (CTheme valeur in theme)
            {
                lstTheme[i] = valeur.Nom;
                i++;
            }
            return lstTheme;
        }

        public string[] jeuRemplirListePlatform()
        {
            List<CPlatform> plat = BD.DisplayPlatform();
            string[] lstPlat = new string[plat.Count];
            int i = 0;
            foreach (CPlatform valeur in plat)
            {
                lstPlat[i] = valeur.Nom;
                i++;
            }
            return lstPlat;
        }

        public string[] jeuRemplirListeClassification()
        {
            List<CClassification> classif= BD.DisplayClassif();
            string[] lstClass = new string[classif.Count];
            int i = 0;
            foreach (CClassification valeur in classif)
            {
                lstClass[i] = valeur.Nom;
                i++;
            }
            return lstClass;
        }

        public string[] platformRemplirListeOS()
        {
            List<CSysExp> sys = BD.DisplaySysExp();
            string[] lstSys = new string[sys.Count];
            int i = 0;
            foreach (CSysExp valeur in sys)
            {
                lstSys[i] = valeur.Nom;
                i++;
            }
            return lstSys;
        }
    }
}
