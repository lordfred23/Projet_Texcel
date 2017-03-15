using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Texcel.ClasseObjBd
{
    class CEmployeEquipe
    {
        string matricule;
        int idEquipe;

        public CEmployeEquipe(string matricule,int idEquipe)
        {
            Matricule = matricule;
            IdEquipe = idEquipe;
        }
        public string Matricule
        {
            get
            {
                return matricule;
            }

            set
            {
                matricule = value;
            }
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
    }
}
