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
    public partial class Categorie : Form
    {
        Form1 form;
        public Categorie(Form1 form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void btnCreerCatego_Click(object sender, EventArgs e)
        {

        }

        private void Categorie_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.cateConn = false;
        }
    }
}
