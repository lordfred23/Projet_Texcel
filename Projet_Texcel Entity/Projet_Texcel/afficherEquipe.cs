using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_Texcel
{
    public partial class afficherEquipe : Form
    {
        Form1 form;
        public afficherEquipe(Form1 form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void affichageGenre_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.afEquipeConn = false;
        }

        private void afficherEquipe_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bdTexelFredAlexDataSet3.tblEquipe'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.tblEquipeTableAdapter.Fill(this.bdTexelFredAlexDataSet3.tblEquipe);

        }
    }
}
