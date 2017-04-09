using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projet_Texcel.ClasseObjBd;

namespace Projet_Texcel
{
    public partial class affichageJeux : Form
    {
        Form1 form;
        public affichageJeux(Form1 form)
        {
            InitializeComponent();
            this.form = form;
            
        }

        

        private void affichageJeux_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.afJeuConn = false;
        }

        
    }
}
