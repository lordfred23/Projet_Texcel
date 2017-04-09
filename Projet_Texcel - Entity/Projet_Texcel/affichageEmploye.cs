using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projet_Texcel.ClasseObjBd;
using System.Windows.Forms;

namespace Projet_Texcel
{
    public partial class affichageEmploye : Form
    {
        Form1 form;
        public affichageEmploye(Form1 form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void affichageEmploye_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.afEmployeConn = false;
        }
    }
}
