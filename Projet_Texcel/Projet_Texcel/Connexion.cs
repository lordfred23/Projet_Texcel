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
    public partial class Connexion : Form
    {
        Control control;
        public Connexion()
        {
            InitializeComponent();
            control = new Control();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            control.connexion(txtUti.Text, txtPass.Text);            
        }
    }
}
