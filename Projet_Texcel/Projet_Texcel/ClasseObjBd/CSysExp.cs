using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Texcel.ClasseObjBd
{
    class CSysExp
    {
        int idSysExp;
        string nom, version, edition,tag;

        public CSysExp(int idSysExp,string nom,string version,string edition,string tag)
        {
            this.IdSysExp = idSysExp;
            this.Nom = nom;
            this.Version = version;
            this.Edition = edition;
            this.Tag = tag;
        }

        public string Edition
        {
            get
            {
                return edition;
            }

            set
            {
                edition = value;
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

        public string Version
        {
            get
            {
                return version;
            }

            set
            {
                version = value;
            }
        }
    }
}
