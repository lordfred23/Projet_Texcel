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

        private void affichageJeux_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bdTexelFredAlexDSJeu.tblJeu'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.tblJeuTableAdapter.Fill(this.bdTexelFredAlexDSJeu.tblJeu);
            // TODO: cette ligne de code charge les données dans la table 'bdTexelFredAlexDataSet1.tblJeu'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
           

        }

        private void bindingJeu_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
