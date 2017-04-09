namespace Projet_Texcel
{
    partial class affichageJeux
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridViewJeu = new System.Windows.Forms.DataGridView();
            this.idJeuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.developpeurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minimalConfigDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idClassificationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idGenreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idThemeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPlatformDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblClassificationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblGenreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblPlatformDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblThemeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblProjetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblJeuBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tblJeuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJeu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblJeuBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblJeuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewJeu
            // 
            this.dataGridViewJeu.AllowUserToAddRows = false;
            this.dataGridViewJeu.AllowUserToDeleteRows = false;
            this.dataGridViewJeu.AllowUserToResizeColumns = false;
            this.dataGridViewJeu.AllowUserToResizeRows = false;
            this.dataGridViewJeu.AutoGenerateColumns = false;
            this.dataGridViewJeu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewJeu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idJeuDataGridViewTextBoxColumn,
            this.developpeurDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.minimalConfigDataGridViewTextBoxColumn,
            this.idClassificationDataGridViewTextBoxColumn,
            this.idGenreDataGridViewTextBoxColumn,
            this.idThemeDataGridViewTextBoxColumn,
            this.idPlatformDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.tagDataGridViewTextBoxColumn,
            this.tblClassificationDataGridViewTextBoxColumn,
            this.tblGenreDataGridViewTextBoxColumn,
            this.tblPlatformDataGridViewTextBoxColumn,
            this.tblThemeDataGridViewTextBoxColumn,
            this.tblProjetDataGridViewTextBoxColumn});
            this.dataGridViewJeu.DataSource = this.tblJeuBindingSource1;
            this.dataGridViewJeu.Location = new System.Drawing.Point(2, 2);
            this.dataGridViewJeu.Name = "dataGridViewJeu";
            this.dataGridViewJeu.Size = new System.Drawing.Size(1044, 444);
            this.dataGridViewJeu.TabIndex = 0;
            // 
            // idJeuDataGridViewTextBoxColumn
            // 
            this.idJeuDataGridViewTextBoxColumn.DataPropertyName = "idJeu";
            this.idJeuDataGridViewTextBoxColumn.HeaderText = "idJeu";
            this.idJeuDataGridViewTextBoxColumn.Name = "idJeuDataGridViewTextBoxColumn";
            // 
            // developpeurDataGridViewTextBoxColumn
            // 
            this.developpeurDataGridViewTextBoxColumn.DataPropertyName = "developpeur";
            this.developpeurDataGridViewTextBoxColumn.HeaderText = "developpeur";
            this.developpeurDataGridViewTextBoxColumn.Name = "developpeurDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // minimalConfigDataGridViewTextBoxColumn
            // 
            this.minimalConfigDataGridViewTextBoxColumn.DataPropertyName = "minimalConfig";
            this.minimalConfigDataGridViewTextBoxColumn.HeaderText = "minimalConfig";
            this.minimalConfigDataGridViewTextBoxColumn.Name = "minimalConfigDataGridViewTextBoxColumn";
            // 
            // idClassificationDataGridViewTextBoxColumn
            // 
            this.idClassificationDataGridViewTextBoxColumn.DataPropertyName = "idClassification";
            this.idClassificationDataGridViewTextBoxColumn.HeaderText = "idClassification";
            this.idClassificationDataGridViewTextBoxColumn.Name = "idClassificationDataGridViewTextBoxColumn";
            // 
            // idGenreDataGridViewTextBoxColumn
            // 
            this.idGenreDataGridViewTextBoxColumn.DataPropertyName = "idGenre";
            this.idGenreDataGridViewTextBoxColumn.HeaderText = "idGenre";
            this.idGenreDataGridViewTextBoxColumn.Name = "idGenreDataGridViewTextBoxColumn";
            // 
            // idThemeDataGridViewTextBoxColumn
            // 
            this.idThemeDataGridViewTextBoxColumn.DataPropertyName = "idTheme";
            this.idThemeDataGridViewTextBoxColumn.HeaderText = "idTheme";
            this.idThemeDataGridViewTextBoxColumn.Name = "idThemeDataGridViewTextBoxColumn";
            // 
            // idPlatformDataGridViewTextBoxColumn
            // 
            this.idPlatformDataGridViewTextBoxColumn.DataPropertyName = "idPlatform";
            this.idPlatformDataGridViewTextBoxColumn.HeaderText = "idPlatform";
            this.idPlatformDataGridViewTextBoxColumn.Name = "idPlatformDataGridViewTextBoxColumn";
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "nom";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            // 
            // tagDataGridViewTextBoxColumn
            // 
            this.tagDataGridViewTextBoxColumn.DataPropertyName = "tag";
            this.tagDataGridViewTextBoxColumn.HeaderText = "tag";
            this.tagDataGridViewTextBoxColumn.Name = "tagDataGridViewTextBoxColumn";
            // 
            // tblClassificationDataGridViewTextBoxColumn
            // 
            this.tblClassificationDataGridViewTextBoxColumn.DataPropertyName = "tblClassification";
            this.tblClassificationDataGridViewTextBoxColumn.HeaderText = "tblClassification";
            this.tblClassificationDataGridViewTextBoxColumn.Name = "tblClassificationDataGridViewTextBoxColumn";
            this.tblClassificationDataGridViewTextBoxColumn.Visible = false;
            // 
            // tblGenreDataGridViewTextBoxColumn
            // 
            this.tblGenreDataGridViewTextBoxColumn.DataPropertyName = "tblGenre";
            this.tblGenreDataGridViewTextBoxColumn.HeaderText = "tblGenre";
            this.tblGenreDataGridViewTextBoxColumn.Name = "tblGenreDataGridViewTextBoxColumn";
            this.tblGenreDataGridViewTextBoxColumn.Visible = false;
            // 
            // tblPlatformDataGridViewTextBoxColumn
            // 
            this.tblPlatformDataGridViewTextBoxColumn.DataPropertyName = "tblPlatform";
            this.tblPlatformDataGridViewTextBoxColumn.HeaderText = "tblPlatform";
            this.tblPlatformDataGridViewTextBoxColumn.Name = "tblPlatformDataGridViewTextBoxColumn";
            this.tblPlatformDataGridViewTextBoxColumn.Visible = false;
            // 
            // tblThemeDataGridViewTextBoxColumn
            // 
            this.tblThemeDataGridViewTextBoxColumn.DataPropertyName = "tblTheme";
            this.tblThemeDataGridViewTextBoxColumn.HeaderText = "tblTheme";
            this.tblThemeDataGridViewTextBoxColumn.Name = "tblThemeDataGridViewTextBoxColumn";
            this.tblThemeDataGridViewTextBoxColumn.Visible = false;
            // 
            // tblProjetDataGridViewTextBoxColumn
            // 
            this.tblProjetDataGridViewTextBoxColumn.DataPropertyName = "tblProjet";
            this.tblProjetDataGridViewTextBoxColumn.HeaderText = "tblProjet";
            this.tblProjetDataGridViewTextBoxColumn.Name = "tblProjetDataGridViewTextBoxColumn";
            this.tblProjetDataGridViewTextBoxColumn.Visible = false;
            // 
            // tblJeuBindingSource1
            // 
            this.tblJeuBindingSource1.DataSource = typeof(Projet_Texcel.tblJeu);
            // 
            // tblJeuBindingSource
            // 
            this.tblJeuBindingSource.DataSource = typeof(Projet_Texcel.tblJeu);
            // 
            // affichageJeux
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 448);
            this.Controls.Add(this.dataGridViewJeu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "affichageJeux";
            this.Text = "affichageJeux";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.affichageJeux_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJeu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblJeuBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblJeuBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewJeu;
        private System.Windows.Forms.DataGridViewTextBoxColumn idJeuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn developpeurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minimalConfigDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClassificationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idGenreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idThemeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPlatformDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tblClassificationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tblGenreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tblPlatformDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tblThemeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tblProjetDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tblJeuBindingSource1;
        private System.Windows.Forms.BindingSource tblJeuBindingSource;
    }
}