﻿using System;
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
    public partial class Classification : Form
    {
        Form1 form;
        public Classification(Form1 form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void btnCreerClassif_Click(object sender, EventArgs e)
        {

        }

        private void Classification_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.clasConn = false;
        }
    }
}