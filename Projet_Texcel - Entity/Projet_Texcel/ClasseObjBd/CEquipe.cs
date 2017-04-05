using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Texcel.ClasseObjBd
{
    class CEquipe
    {
        int idEquipe;
        string nom, tag;
        public CEquipe(int idEquipe,string nom,string tag)
        {
            IdEquipe = idEquipe;
            Nom = nom;
            Tag = tag;
        }

        public int IdEquipe
        {
            get
            {
                return idEquipe;
            }

            set
            {
                idEquipe = value;
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
