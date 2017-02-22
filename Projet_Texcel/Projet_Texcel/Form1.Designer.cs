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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Employés");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Équipes");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Jeu");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Genre");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Classification");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Catégories");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Jeux", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("OS");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Platforme");
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Nœud0";
            treeNode1.Text = "Employés";
            treeNode2.Name = "Nœud1";
            treeNode2.Text = "Équipes";
            treeNode3.Name = "Nœud6";
            treeNode3.Text = "Jeu";
            treeNode4.Name = "Nœud8";
            treeNode4.Text = "Genre";
            treeNode5.Name = "Nœud9";
            treeNode5.Text = "Classification";
            treeNode6.Name = "Nœud10";
            treeNode6.Text = "Catégories";
            treeNode7.Name = "Nœud2";
            treeNode7.Text = "Jeux";
            treeNode8.Name = "Nœud3";
            treeNode8.Text = "OS";
            treeNode9.Name = "Nœud4";
            treeNode9.Text = "Platforme";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode7,
            treeNode8,
            treeNode9});
            this.treeView1.Size = new System.Drawing.Size(235, 411);
            this.treeView1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 564);
            this.Controls.Add(this.treeView1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Texcel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
    }
}

