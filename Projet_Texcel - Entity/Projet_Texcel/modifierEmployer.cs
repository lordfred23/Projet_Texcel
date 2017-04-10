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
        bdTexelFredAlexEntities context;
        //DataSet currentData = dataGridViewModifierEmployer.DataSource;

        public modifierEmployer(Form1 form)
        {
            InitializeComponent();
            context = new bdTexelFredAlexEntities();
            this.form = form;
            btnRechercher.Enabled = false;
        }

        private void modifierEmployer_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.modEmployeConn = false;
            this.context.Dispose();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            this.context.SaveChanges();
            this.dataGridViewModifierEmployer.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var query = from p in context.tblEmploye
                        where p.tag.Contains(txtRechercher.Text)
                        orderby p.prenom
                        select p;
            //dataGridViewModifierEmployer.
            foreach (var employe in query)
            {
                //dataGridViewModifierEmployer.
            }
        }

        private void txtRechercher_TextChanged(object sender, EventArgs e)
        {
            if (txtRechercher.Text == null)
                btnRechercher.Enabled = false;
            else
                btnRechercher.Enabled = true;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            this.context.SaveChanges();
            this.dataGridViewModifierEmployer.Refresh();
        }
    }
}
