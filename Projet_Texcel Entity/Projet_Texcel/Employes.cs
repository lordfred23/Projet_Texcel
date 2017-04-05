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
    public partial class Employes : Form
    {
        Form1 form;
        public Employes(Form1 form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void Employes_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.empConn = false;
        }

        private void Employes_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bdTexelFredAlexDSCreerEmploye.tblEmploye'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.tblEmployeTableAdapter.Fill(this.bdTexelFredAlexDSCreerEmploye.tblEmploye);

        }
    }
}
