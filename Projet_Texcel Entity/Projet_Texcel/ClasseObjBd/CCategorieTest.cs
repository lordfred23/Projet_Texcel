using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Texcel.ClasseObjBd
{
    class CCategorieTest
    {
        int idCategorieTest;
        string nom,description, tag;
        public CCategorieTest(int idCategorieTest,string nom,string description,string tag)
        {
            IdCategorieTest = idCategorieTest;
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

        public int IdCategorieTest
        {
            get
            {
                return idCategorieTest;
            }

            set
            {
                idCategorieTest = value;
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
