using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Texcel.ClasseObjBd
{
    class CRole
    {
        int idRole;
        string nom, description, tag;
        public CRole(int idRole,string nom,string description,string tag)
        {
            Description = description;
            IdRole = idRole;
            Nom = nom;
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

        public int IdRole
        {
            get
            {
                return idRole;
            }

            set
            {
                idRole = value;
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
