using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Texcel.ClasseObjBd
{
    class CGenreJeu
    {
        int idGenre, idJeu;
        public CGenreJeu(int idGenre,int idJeu)
        {
            IdGenre = idGenre;
            IdJeu = idJeu;
        }

        public int IdGenre
        {
            get
            {
                return idGenre;
            }

            set
            {
                idGenre = value;
            }
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
    }
}
