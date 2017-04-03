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
    public partial class affichagePlatforme : Form
    {
        Form1 form;
        public affichagePlatforme(Form1 form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void affichagePlatforme_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.afPlatformeConn = false;
        }

        private void affichagePlatforme_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bdTexelFredAlexDataSet2.tblPlatform'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.tblPlatformTableAdapter.Fill(this.bdTexelFredAlexDataSet2.tblPlatform);

        }
    }
}
