using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Texcel
{
    class Control
    {
        Form1 form;
        public Control() { }

        public Control(Form1 formulaire) { form = formulaire; }

        public bool connexion(string uti, string pass)
        {
            bool connexion = false;
            if ((uti == "admin") && (pass == "admin"))
                connexion = true;
            form.Init(connexion);
            return connexion;
        }
    }
}
