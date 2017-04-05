using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Texcel.ClasseObjBd
{
    class CGenre
    {
        int idGenre;
        string nom, description, tag;
        public CGenre(int idGenre,string nom,string description,string tag)
        {
            IdGenre = idGenre;
            Nom = nom;
            Description = description;
            Tag = tag;
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

        public int IdGenre
        {
            get
            {
                return idGenre;
            }

            set
            {
                idGenre = value;
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
