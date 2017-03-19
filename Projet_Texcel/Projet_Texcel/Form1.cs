using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

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
        Equipe equipe;

        public bool conConn = false, equipeConn = false, osConn = false, platConn = false, empConn = false, jeuConn = false, genreConn = false, clasConn = false, cateConn = false;
                
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

        public void equipeToolStripMenuItem_Click(object sender = null, EventArgs e = null)
        {
            if (!equipeConn)
            {
                equipe = new Equipe(this);
                equipe.Text = "Équipe";
                equipe.MdiParent = this;
                equipe.StartPosition = FormStartPosition.CenterScreen;
                equipe.Show();
                equipeConn = true;
            }
        }

        private void creerJeuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!jeuConn)
            {
                jeu = new Jeu(this);
                jeu.Text = "Jeux";
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
                genre.Text = "Genre";
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
                classification.Text = "Classification";
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
                categorie.Text = "Catégories";
                categorie.MdiParent = this;
                categorie.StartPosition = FormStartPosition.CenterScreen;
                categorie.Show();
                cateConn = true;
            }
        }

        public void osToolStripMenuItem_Click(object sender = null, EventArgs e = null)
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

        public string[] employeRemplirListeEquipe()
        {
            return control.employeRemplirListeEquipe();
        }

        public int validate(TextBox textBox)
        {
            Regex regex = new Regex("^[a-zA-Z\\s]+$");
            Match match = regex.Match(textBox.Text);
            if (match.Success)
            {
                return 0;
            }
            else
                return Convert.ToInt32(textBox.Tag);
        }

        public int validateDate(TextBox textBox)
        {
            if(Convert.ToInt32(textBox.Tag) == 3)
            {
                Regex regex = new Regex("^[0-9]{4}");
                Match match = regex.Match(textBox.Text);
                if (match.Success)
                {
                    return 0;
                }
                else
                    return Convert.ToInt32(textBox.Tag);
            }
            else
            {
                Regex regex = new Regex("^[0-9]{2}");
                Match match = regex.Match(textBox.Text);
                if (match.Success)
                {
                    if(Convert.ToInt32(textBox.Tag) == 4)
                    {
                        if ((Convert.ToInt32(textBox.Text) > 0) && (Convert.ToInt32(textBox.Text) < 13))
                            return 0;
                        else
                            return Convert.ToInt32(textBox.Tag);
                    }
                    else
                    {
                        if ((Convert.ToInt32(textBox.Text) > 0) && (Convert.ToInt32(textBox.Text) < 32))
                            return 0;
                        else
                            return Convert.ToInt32(textBox.Tag);
                    }
                }
                else
                    return Convert.ToInt32(textBox.Tag);
            }
        }

        public int validateAddresse(TextBox textBox)
        {
            Regex regex = new Regex("^([0-9]{1,8} ([aA-zZ]{1,20}) ([aA-zZ]{1,20}))");
            Match match = regex.Match(textBox.Text);
            if (match.Success)
            {
                return 0;
            }
            else
                return Convert.ToInt32(textBox.Tag);
        }

        public int validateEmail(TextBox textBox)
        {
            Regex regex = new Regex("^[a-z0-9._-]+@[a-z0-9._-]{2,}\\.[a-z]{2,4}");
            Match match = regex.Match(textBox.Text);
            if (match.Success)
            {
                return 0;
            }
            else
                return Convert.ToInt32(textBox.Tag);
        }

        public int validateMatricule(TextBox textBox)
        {
            Regex regex = new Regex("^[aA-zZ0-9]{4,8}");
            Match match = regex.Match(textBox.Text);
            if (match.Success)
            {
                return 0;
            }
            else
                return Convert.ToInt32(textBox.Tag);
        }

        public int validatePoste(TextBox textBox)
        {
            Regex regex = new Regex("^[0-9]{4}");
            Match match = regex.Match(textBox.Text);
            if (match.Success)
            {
                return 0;
            }
            else
                return Convert.ToInt32(textBox.Tag);
        }

        public int validateTel(TextBox textBox)
        {
            Regex regex = new Regex("^([0-9]{3}-[0-9]{3}-[0-9]{4})");
            Match match = regex.Match(textBox.Text);
            if (match.Success)
            {
                return 0;
            }
            else
                return Convert.ToInt32(textBox.Tag);
        }
    }
}
