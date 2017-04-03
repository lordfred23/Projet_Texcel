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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bindingJeu = new System.Windows.Forms.BindingSource(this.components);
            this.bdTexelFredAlexDSJeu = new Projet_Texcel.bdTexelFredAlexDSJeu();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tblJeuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblJeuTableAdapter = new Projet_Texcel.bdTexelFredAlexDSJeuTableAdapters.tblJeuTableAdapter();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingJeu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdTexelFredAlexDSJeu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblJeuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1044, 354);
            this.dataGridView1.TabIndex = 0;
            // 
            // bindingJeu
            // 
            this.bindingJeu.DataSource = this.bdTexelFredAlexDSJeu;
            this.bindingJeu.Position = 0;
            this.bindingJeu.CurrentChanged += new System.EventHandler(this.bindingJeu_CurrentChanged);
            // 
            // bdTexelFredAlexDSJeu
            // 
            this.bdTexelFredAlexDSJeu.DataSetName = "bdTexelFredAlexDSJeu";
            this.bdTexelFredAlexDSJeu.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idJeuDataGridViewTextBoxColumn,
            this.developpeurDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.minimalConfigDataGridViewTextBoxColumn,
            this.idClassificationDataGridViewTextBoxColumn,
            this.idGenreDataGridViewTextBoxColumn,
            this.idThemeDataGridViewTextBoxColumn,
            this.idPlatformDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.tagDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.tblJeuBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(-2, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1044, 354);
            this.dataGridView2.TabIndex = 1;
            // 
            // tblJeuBindingSource
            // 
            this.tblJeuBindingSource.DataMember = "tblJeu";
            this.tblJeuBindingSource.DataSource = this.bindingJeu;
            // 
            // tblJeuTableAdapter
            // 
            this.tblJeuTableAdapter.ClearBeforeFill = true;
            // 
            // idJeuDataGridViewTextBoxColumn
            // 
            this.idJeuDataGridViewTextBoxColumn.DataPropertyName = "idJeu";
            this.idJeuDataGridViewTextBoxColumn.HeaderText = "idJeu";
            this.idJeuDataGridViewTextBoxColumn.Name = "idJeuDataGridViewTextBoxColumn";
            this.idJeuDataGridViewTextBoxColumn.ReadOnly = true;
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
            // affichageJeux
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 348);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "affichageJeux";
            this.Text = "affichageJeux";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.affichageJeux_FormClosing);
            this.Load += new System.EventHandler(this.affichageJeux_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingJeu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdTexelFredAlexDSJeu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblJeuBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingJeu;
        private bdTexelFredAlexDSJeu bdTexelFredAlexDSJeu;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource tblJeuBindingSource;
        private bdTexelFredAlexDSJeuTableAdapters.tblJeuTableAdapter tblJeuTableAdapter;
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
    }
}