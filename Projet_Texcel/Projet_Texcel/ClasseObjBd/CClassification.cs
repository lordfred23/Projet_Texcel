using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Texcel.ClasseObjBd
{
    class CClassification
    {
        int idClassification;
        string nom, description, tag;
        public CClassification(int idClassification,string nom,string description,string tag)
        {
            IdClassification = idClassification;
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

        public int IdClassification
        {
            get
            {
                return idClassification;
            }

            set
            {
                idClassification = value;
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
