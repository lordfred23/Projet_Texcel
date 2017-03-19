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

        public void employeRemplirListeEquipe()
        {
            
        }
    }
}
