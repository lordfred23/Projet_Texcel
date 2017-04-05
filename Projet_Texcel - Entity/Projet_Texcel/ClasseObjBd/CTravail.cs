using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Texcel.ClasseObjBd
{
    class CTravail
    {
        int idTest, idEquipe, idProjet;
        
        public CTravail(int idEquipe,int idTest,int idProjet)
        {
            IdEquipe = idEquipe;
            IdTest = idTest;
            IdProjet = idProjet;
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
    }
}
