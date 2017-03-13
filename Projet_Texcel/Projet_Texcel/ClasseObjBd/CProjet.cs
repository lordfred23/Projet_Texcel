using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Texcel.ClasseObjBd
{
    class CProjet
    {
        int idProjet,idJeu;
        string description,nom, tag;

        

        public CProjet(int idProjet,int idJeu,string nom,string description,string tag)
        {
            IdProjet = idProjet;
            IdJeu = idJeu;
            Nom = nom;
            Description = description;
            Tag = tag;
        }
        public int IdProjet
        {
            get
            {
                return idProjet;
            }

            set
            {
                idProjet = value;
            }
        }

        public int IdJeu
        {
            get
            {
                return idJeu;
            }

            set
            {
                idJeu = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }

        public string Nom
        {
            get
            {
                return nom;
            }

            set
            {
                nom = value;
            }
        }

        public string Tag
        {
            get
            {
                return tag;
            }

            set
            {
                tag = value;
            }
        }
    }
}
