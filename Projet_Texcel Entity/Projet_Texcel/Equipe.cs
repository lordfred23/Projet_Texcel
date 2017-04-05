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
    public partial class Equipe : Form
    {
        Form1 form;
        public Equipe(Form1 form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void Equipe_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.equipeConn = false;
        }

        private void Equipe_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bdTexelFredAlexDSCreerEquipe.tblEquipe'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.tblEquipeTableAdapter.Fill(this.bdTexelFredAlexDSCreerEquipe.tblEquipe);

        }
    }
}
