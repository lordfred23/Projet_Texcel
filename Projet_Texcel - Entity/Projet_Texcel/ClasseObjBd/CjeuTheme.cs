using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Texcel.ClasseObjBd
{
    class CJeuTheme
    {
        int idTheme, idJeu;
        public CJeuTheme(int idTheme,int idJeu)
        {
            IdJeu = idJeu;
            IdTheme = idTheme;
           
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

        public int IdTheme
        {
            get
            {
                return idTheme;
            }

            set
            {
                idTheme = value;
            }
        }
    }
}
