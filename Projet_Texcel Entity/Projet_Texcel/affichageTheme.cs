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
    public partial class affichageTheme : Form
    {
        Form1 form;
        public affichageTheme(Form1 form)
        {
            InitializeComponent();
            this.form = form;
            
        }

        

        private void affichageGenre_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.afThemeConn = false;
        }

        private void affichageTheme_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bdTexelFredAlexDataSet2.tblTheme'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
           

        }
    }
}
