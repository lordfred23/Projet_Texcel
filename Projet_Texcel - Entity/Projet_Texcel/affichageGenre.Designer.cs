namespace Projet_Texcel
{
    partial class affichageGenre
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
            this.dataGridViewGenre = new System.Windows.Forms.DataGridView();
            this.tblGenreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idGenreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGenre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblGenreBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewGenre
            // 
            this.dataGridViewGenre.AllowUserToAddRows = false;
            this.dataGridViewGenre.AllowUserToDeleteRows = false;
            this.dataGridViewGenre.AllowUserToResizeColumns = false;
            this.dataGridViewGenre.AllowUserToResizeRows = false;
            this.dataGridViewGenre.AutoGenerateColumns = false;
            this.dataGridViewGenre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGenre.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idGenreDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.tagDataGridViewTextBoxColumn});
            this.dataGridViewGenre.DataSource = this.tblGenreBindingSource;
            this.dataGridViewGenre.Location = new System.Drawing.Point(1, 0);
            this.dataGridViewGenre.Name = "dataGridViewGenre";
            this.dataGridViewGenre.RowTemplate.Height = 24;
            this.dataGridViewGenre.Size = new System.Drawing.Size(443, 342);
            this.dataGridViewGenre.TabIndex = 0;
            // 
            // tblGenreBindingSource
            // 
            this.tblGenreBindingSource.DataSource = typeof(Projet_Texcel.tblGenre);
            // 
            // idGenreDataGridViewTextBoxColumn
            // 
            this.idGenreDataGridViewTextBoxColumn.DataPropertyName = "idGenre";
            this.idGenreDataGridViewTextBoxColumn.HeaderText = "idGenre";
            this.idGenreDataGridViewTextBoxColumn.Name = "idGenreDataGridViewTextBoxColumn";
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
            // affichageGenre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 344);
            this.Controls.Add(this.dataGridViewGenre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "affichageGenre";
            this.Text = "affichageGenre";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.affichageGenre_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGenre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblGenreBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewGenre;
        private System.Windows.Forms.BindingSource tblGenreBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idGenreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tagDataGridViewTextBoxColumn;
    }
}