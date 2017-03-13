using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Texcel.ClasseObjBd
{
    class CJeu
    {
        int idJeu, idClassification, idJeu1;
        string developpeur, description, minimalConfig,tag;

        

        public CJeu(int idJeu,int idClassification,int idJeu1,string developpeur,string description,string minimalConfig,string tag)
        {
            this.IdJeu = idJeu;
            this.IdClassification = idClassification;
            this.IdJeu1 = idJeu1;
            this.Description = description;
            this.Developpeur = developpeur;
            this.MinimalConfig = minimalConfig;
            this.Tag = tag;

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

        public int IdJeu1
        {
            get
            {
                return idJeu1;
            }

            set
            {
                idJeu1 = value;
            }
        }

        public string Developpeur
        {
            get
            {
                return developpeur;
            }

            set
            {
                developpeur = value;
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

        public string MinimalConfig
        {
            get
            {
                return minimalConfig;
            }

            set
            {
                minimalConfig = value;
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
