using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Texcel.ClasseObjBd
{
    class CPlatform
    {
        int idPlatform, idSysExp;
        string nom, config, typePlatform, tag;

        public CPlatform(int idPlatform,int idSysExp,string nom,string config,string typePlatform,string tag)
        {
            this.IdPlatform = idPlatform;
            this.IdSysExp = idSysExp;
            this.Nom = nom;
            this.Config = config;
            this.TypePlatform = typePlatform;
            this.Tag = tag;

        }

        public string Config
        {
            get
            {
                return config;
            }

            set
            {
                config = value;
            }
        }

        public int IdPlatform
        {
            get
            {
                return idPlatform;
            }

            set
            {
                idPlatform = value;
            }
        }

        public int IdSysExp
        {
            get
            {
                return idSysExp;
            }

            set
            {
                idSysExp = value;
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

        public string TypePlatform
        {
            get
            {
                return TypePlatform1;
            }

            set
            {
                TypePlatform1 = value;
            }
        }

        public string TypePlatform1
        {
            get
            {
                return typePlatform;
            }

            set
            {
                typePlatform = value;
            }
        }
    }
}
