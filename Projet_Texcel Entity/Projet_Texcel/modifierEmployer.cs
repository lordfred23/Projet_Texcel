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
    public partial class modifierEmployer : Form
    {
        Form1 form;
        
        public modifierEmployer(Form1 form)
        {
            InitializeComponent();
            this.form = form;
            remplirListeEmploye();
        }

        private void remplirListeEmploye()
        {
            string[] employe = form.equipeRemplirListeEmploye();
            foreach(string valeur in employe)
            {
                lstEmploye.Items.Add(valeur);
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            form.formModifierEmployer(lstEmploye.Text,lstEmploye.SelectedIndex);
        }

        private void modifierEmployer_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.modEmployeConn = false;
        }
    }
}
