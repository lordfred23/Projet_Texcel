namespace Projet_Texcel
{
    partial class affichageClassification
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
            this.bdTexelFredAlexEntitiesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewClassif = new System.Windows.Forms.DataGridView();
            this.tblClassificationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idClassificationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblJeuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bdTexelFredAlexEntitiesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClassif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblClassificationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bdTexelFredAlexEntitiesBindingSource1
            // 
            this.bdTexelFredAlexEntitiesBindingSource1.DataSource = typeof(Projet_Texcel.bdTexelFredAlexEntities);
            // 
            // dataGridViewClassif
            // 
            this.dataGridViewClassif.AllowUserToAddRows = false;
            this.dataGridViewClassif.AllowUserToDeleteRows = false;
            this.dataGridViewClassif.AllowUserToResizeColumns = false;
            this.dataGridViewClassif.AllowUserToResizeRows = false;
            this.dataGridViewClassif.AutoGenerateColumns = false;
            this.dataGridViewClassif.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClassif.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idClassificationDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.tagDataGridViewTextBoxColumn,
            this.tblJeuDataGridViewTextBoxColumn});
            this.dataGridViewClassif.DataSource = this.tblClassificationBindingSource;
            this.dataGridViewClassif.Location = new System.Drawing.Point(1, -1);
            this.dataGridViewClassif.Name = "dataGridViewClassif";
            this.dataGridViewClassif.Size = new System.Drawing.Size(445, 288);
            this.dataGridViewClassif.TabIndex = 0;
            // 
            // tblClassificationBindingSource
            // 
            this.tblClassificationBindingSource.DataSource = typeof(Projet_Texcel.tblClassification);
            // 
            // idClassificationDataGridViewTextBoxColumn
            // 
            this.idClassificationDataGridViewTextBoxColumn.DataPropertyName = "idClassification";
            this.idClassificationDataGridViewTextBoxColumn.HeaderText = "idClassification";
            this.idClassificationDataGridViewTextBoxColumn.Name = "idClassificationDataGridViewTextBoxColumn";
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "nom";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // tagDataGridViewTextBoxColumn
            // 
            this.tagDataGridViewTextBoxColumn.DataPropertyName = "tag";
            this.tagDataGridViewTextBoxColumn.HeaderText = "tag";
            this.tagDataGridViewTextBoxColumn.Name = "tagDataGridViewTextBoxColumn";
            // 
            // tblJeuDataGridViewTextBoxColumn
            // 
            this.tblJeuDataGridViewTextBoxColumn.DataPropertyName = "tblJeu";
            this.tblJeuDataGridViewTextBoxColumn.HeaderText = "tblJeu";
            this.tblJeuDataGridViewTextBoxColumn.Name = "tblJeuDataGridViewTextBoxColumn";
            this.tblJeuDataGridViewTextBoxColumn.Visible = false;
            // 
            // affichageClassification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 288);
            this.Controls.Add(this.dataGridViewClassif);
            this.Name = "affichageClassification";
            this.Text = "affichageClassification";
            this.Load += new System.EventHandler(this.affichageClassification_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdTexelFredAlexEntitiesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClassif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblClassificationBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bdTexelFredAlexEntitiesBindingSource1;
        private System.Windows.Forms.DataGridView dataGridViewClassif;
        private System.Windows.Forms.BindingSource tblClassificationBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClassificationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tblJeuDataGridViewTextBoxColumn;
    }
}