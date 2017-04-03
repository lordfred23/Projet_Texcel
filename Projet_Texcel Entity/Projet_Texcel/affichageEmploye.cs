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

        private void affichageEmploye_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bdTexelFredAlexDataSet1.tblEmploye'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.tblEmployeTableAdapter.Fill(this.bdTexelFredAlexDataSet1.tblEmploye);

        }
    }
}
