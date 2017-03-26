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
using Projet_Texcel.ClasseObjBd;

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
        affichageEmploye afEmploye;
        affichagePlatforme afPlatforme;
        affichageGenre afGenre;
        affichageClassification afClassif;
        affichageTheme afTheme;
        afficherEquipe afEquipe;

        public bool afEmployeConn = false, afGenreConn = false, afPlatformeConn = false, conConn = false, equipeConn = false, osConn = false, platConn = false, empConn = false, jeuConn = false, genreConn = false, clasConn = false, cateConn = false, afClassifConn=false,afThemeConn=false,afEquipeConn;
                
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

        public void AddSystemExploitation(string nom, string version, string edition)
        {
            control.AddSystemExploitation(nom, version, edition);
        }

        public void AddEmploye(string matricule, string nom, string prenom, string annee, string mois, string jour, string addresse, string cellulaire, string telePoste, string teleResid, string role)
        {
            control.AddEmploye(matricule, nom, prenom, annee , mois , jour, addresse, cellulaire, telePoste, teleResid, role);
        }

        public void AddClassification(string classif, string desc)
        {
            control.AddClassification(classif, desc);
        }

        public void AddGenre(string genre, string desc)
        {
            control.AddGenre(genre, desc);
        }

        public void AddTheme(string theme, string desc)
        {
            control.AddTheme(desc, desc);
        }

        public string[] employeRemplirListeEquipe()
        {
            return control.employeRemplirListeEquipe();
        }

        public string[] employeRemplirListeRole()
        {
            return control.employeRemplirListeRole();
        }

        public string[] equipeRemplirListeEmploye()
        {
            return control.equipeRemplirListeEmploye();
        }

        public string[] jeuRemplirListeGenre()
        {
            return control.jeuRemplirListeGenre();
        }

        public string[] jeuRemplirListeClassification()
        {
            return control.jeuRemplirListeClassification();
        }

        public string[] jeuRemplirListeTheme()
        {
            return control.jeuRemplirListeTheme();
        }

        private void oSToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!afGenreConn)
            {
                afGenre = new affichageGenre(this);
                afGenre.Text = "Affichage Genre";
                afGenre.MdiParent = this;
                afGenre.StartPosition = FormStartPosition.CenterScreen;
                afGenre.Show();
                afGenreConn = true;
            }
        }

        private void équipesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!afThemeConn)
            {
                afTheme = new affichageTheme(this);
                afTheme.Text = "Affichage Theme";
                afTheme.MdiParent = this;
                afTheme.StartPosition = FormStartPosition.CenterScreen;
                afTheme.Show();
                afThemeConn = true;
            }
        }

        private void thèmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!afEquipeConn)
            {
                afEquipe= new afficherEquipe(this);
                afEquipe.Text = "Affichage Equipe";
                afEquipe.MdiParent = this;
                afEquipe.StartPosition = FormStartPosition.CenterScreen;
                afEquipe.Show();
                afEquipeConn = true;
            }
        }

        private void classificationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!afClassifConn)
            {
                afClassif = new affichageClassification(this);
                afClassif.Text = "Affichage Classification";
                afClassif.MdiParent = this;
                afClassif.StartPosition = FormStartPosition.CenterScreen;
                afClassif.Show();
                afClassifConn = true;
            }
        }

        private void platformesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!afPlatformeConn)
            {
                afPlatforme = new affichagePlatforme(this);
                afPlatforme.Text = "Affichage Platforme";
                afPlatforme.MdiParent = this;
                afPlatforme.StartPosition = FormStartPosition.CenterScreen;
                afPlatforme.Show();
                afPlatformeConn = true;
            }
        }

        private void employésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!afEmployeConn)
            {
                afEmploye = new affichageEmploye(this);
                afEmploye.Text = "Affichage Employe";
                afEmploye.MdiParent = this;
                afEmploye.StartPosition = FormStartPosition.CenterScreen;
                afEmploye.Show();
                afEmployeConn = true;
            }
        }

        public string[] jeuRemplirListePlatforme()
        {
            return control.jeuRemplirListePlatform();
        }

        public List<CEmploye> getListeEmployes()
        {
            return control.getListeEmploye();
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
            Regex regex = new Regex("^[aA-zZ0-9]{7}");
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
            Regex regex = new Regex("^[0-9]{3}");
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
