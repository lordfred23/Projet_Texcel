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
    public partial class Form1 : Form
    {
        Control control;
        Connexion connexion;
        Jeu jeu;
        Categorie categorie;
        Genre genre;
        Classification classification;
        Platforme platforme;
        Employes employes;
        OS os;

        public bool conConn = false, osConn = false, platConn = false, empConn = false, jeuConn = false, genreConn = false, clasConn = false, cateConn = false;
                
        public Form1()
        {
            InitializeComponent();
            Init(false);
            control = new Control();
        }

        public void Init(bool value)
        {
            jeuxToolStripMenuItem.Enabled = value;
            employéToolStripMenuItem.Enabled = value;
            équipeToolStripMenuItem.Enabled = value;
            oSToolStripMenuItem.Enabled = value;
            platformeToolStripMenuItem.Enabled = value; 
            connexionToolStripMenuItem.Enabled = !value;
            déconnexionToolStripMenuItem.Enabled = value;
        }

        public void connect(string uti, string pass)
        {
            if (control.connexion(uti, pass))
                Init(true);
            else
            {
                control.erreur("Vous avez entrez un mauvais utilisateur ou mot de passe.");
            }
        }

        private void employeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!empConn)
            {
                employes = new Employes(this);
                employes.Text = "Employés";
                employes.MdiParent = this;
                employes.StartPosition = FormStartPosition.CenterScreen;
                employes.Show();
                empConn = true;
            }            
        }

        private void equipeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void creerJeuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!jeuConn)
            {
                jeu = new Jeu(this);
                jeu.Text = "OS";
                jeu.MdiParent = this;
                jeu.StartPosition = FormStartPosition.CenterScreen;
                jeu.Show();
                jeuConn = true;
            }
        }

        private void creerGenreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!genreConn)
            {
                genre = new Genre(this);
                genre.Text = "OS";
                genre.MdiParent = this;
                genre.StartPosition = FormStartPosition.CenterScreen;
                genre.Show();
                genreConn = true;
            }
        }

        private void creerClassificationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!clasConn)
            {
                classification = new Classification(this);
                classification.Text = "OS";
                classification.MdiParent = this;
                classification.StartPosition = FormStartPosition.CenterScreen;
                classification.Show();
                clasConn = true;
            }
        }

        private void creerCatégorieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!cateConn)
            {
                categorie = new Categorie(this);
                categorie.Text = "OS";
                categorie.MdiParent = this;
                categorie.StartPosition = FormStartPosition.CenterScreen;
                categorie.Show();
                cateConn = true;
            }
        }

        private void osToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!osConn)
            {
                os = new OS(this);
                os.Text = "OS";
                os.MdiParent = this;
                os.StartPosition = FormStartPosition.CenterScreen;
                os.Show();
                osConn = true;
            }
        }

        private void platformeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!platConn)
            {
                platforme = new Platforme(this);
                platforme.Text = "Platformes";
                platforme.MdiParent = this;
                platforme.StartPosition = FormStartPosition.CenterScreen;
                platforme.Show();
                platConn = true;
            }            
        }

        private void connexionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!conConn)
            {
                conConn = true;
                connexion = new Connexion(this);
                connexion.Text = "Connexion";
                connexion.MdiParent = this;
                connexion.StartPosition = FormStartPosition.CenterScreen;
                connexion.Show();
            }            
        }

        private void deconnexionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conConn = false;
            Init(false);
        }
    }
}