using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Texcel.ClasseObjBd
{
    class CTest
    {
        int idTest, idCategorieTest;
        double resultat;
        string description, tag;

       

        public CTest(int idTest,int idCategorieTest, double resultat,string description,string tag)
        {
            IdTest = idTest;
            IdCategorieTest = idCategorieTest;
            Resultat = resultat;
            Description = description;
            Tag = tag;
        }

        public int IdTest
        {
            get
            {
                return idTest;
            }

            set
            {
                idTest = value;
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

        public double Resultat
        {
            get
            {
                return resultat;
            }

            set
            {
                resultat = value;
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
