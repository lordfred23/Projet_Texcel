using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Texcel.ClasseObjBd
{
    class CPlatformJeu
    {
        int idJeu, idPlatform;
        public CPlatformJeu(int idJeu,int idPlatform)
        {
            this.IdJeu = idJeu;
            this.IdPlatform = idPlatform;
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
    }
}
