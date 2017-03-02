namespace Projet_Texcel
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.jeuxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creerJeuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creerGenreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creerClassificationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creerCatégorieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.équipeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.platformeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jeuxToolStripMenuItem,
            this.employéToolStripMenuItem,
            this.équipeToolStripMenuItem,
            this.oSToolStripMenuItem,
            this.platformeToolStripMenuItem,
            this.connexionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(857, 31);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // jeuxToolStripMenuItem
            // 
            this.jeuxToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creerJeuToolStripMenuItem,
            this.creerGenreToolStripMenuItem,
            this.creerClassificationToolStripMenuItem,
            this.creerCatégorieToolStripMenuItem});
            this.jeuxToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.jeuxToolStripMenuItem.Name = "jeuxToolStripMenuItem";
            this.jeuxToolStripMenuItem.Size = new System.Drawing.Size(55, 27);
            this.jeuxToolStripMenuItem.Text = "Jeux";
            // 
            // creerJeuToolStripMenuItem
            // 
            this.creerJeuToolStripMenuItem.Name = "creerJeuToolStripMenuItem";
            this.creerJeuToolStripMenuItem.Size = new System.Drawing.Size(230, 28);
            this.creerJeuToolStripMenuItem.Text = "Creer Jeu";
            // 
            // creerGenreToolStripMenuItem
            // 
            this.creerGenreToolStripMenuItem.Name = "creerGenreToolStripMenuItem";
            this.creerGenreToolStripMenuItem.Size = new System.Drawing.Size(230, 28);
            this.creerGenreToolStripMenuItem.Text = "Creer Genre";
            // 
            // creerClassificationToolStripMenuItem
            // 
            this.creerClassificationToolStripMenuItem.Name = "creerClassificationToolStripMenuItem";
            this.creerClassificationToolStripMenuItem.Size = new System.Drawing.Size(230, 28);
            this.creerClassificationToolStripMenuItem.Text = "Creer Classification";
            // 
            // creerCatégorieToolStripMenuItem
            // 
            this.creerCatégorieToolStripMenuItem.Name = "creerCatégorieToolStripMenuItem";
            this.creerCatégorieToolStripMenuItem.Size = new System.Drawing.Size(230, 28);
            this.creerCatégorieToolStripMenuItem.Text = "Creer Catégorie";
            // 
            // employéToolStripMenuItem
            // 
            this.employéToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.employéToolStripMenuItem.Name = "employéToolStripMenuItem";
            this.employéToolStripMenuItem.Size = new System.Drawing.Size(87, 27);
            this.employéToolStripMenuItem.Text = "Employé";
            this.employéToolStripMenuItem.Click += new System.EventHandler(this.employeToolStripMenuItem_Click);
            // 
            // équipeToolStripMenuItem
            // 
            this.équipeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.équipeToolStripMenuItem.Name = "équipeToolStripMenuItem";
            this.équipeToolStripMenuItem.Size = new System.Drawing.Size(74, 27);
            this.équipeToolStripMenuItem.Text = "Équipe";
            this.équipeToolStripMenuItem.Click += new System.EventHandler(this.equipeToolStripMenuItem_Click);
            // 
            // oSToolStripMenuItem
            // 
            this.oSToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.oSToolStripMenuItem.Name = "oSToolStripMenuItem";
            this.oSToolStripMenuItem.Size = new System.Drawing.Size(44, 27);
            this.oSToolStripMenuItem.Text = "OS";
            this.oSToolStripMenuItem.Click += new System.EventHandler(this.osToolStripMenuItem_Click);
            // 
            // platformeToolStripMenuItem
            // 
            this.platformeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.platformeToolStripMenuItem.Name = "platformeToolStripMenuItem";
            this.platformeToolStripMenuItem.Size = new System.Drawing.Size(96, 27);
            this.platformeToolStripMenuItem.Text = "Platforme";
            this.platformeToolStripMenuItem.Click += new System.EventHandler(this.platformeToolStripMenuItem_Click);
            // 
            // connexionToolStripMenuItem
            // 
            this.connexionToolStripMenuItem.Name = "connexionToolStripMenuItem";
            this.connexionToolStripMenuItem.Size = new System.Drawing.Size(91, 27);
            this.connexionToolStripMenuItem.Text = "Connexion";
            this.connexionToolStripMenuItem.Click += new System.EventHandler(this.connexionToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 564);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Texcel";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem jeuxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creerJeuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creerGenreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creerClassificationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creerCatégorieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employéToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem équipeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem platformeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connexionToolStripMenuItem;
    }
}

