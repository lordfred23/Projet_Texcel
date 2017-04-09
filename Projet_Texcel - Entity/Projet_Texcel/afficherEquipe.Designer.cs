namespace Projet_Texcel
{
    partial class afficherEquipe
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
            this.dataGridViewEquipe = new System.Windows.Forms.DataGridView();
            this.tblEquipeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idEquipeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblTravailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblEmployeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEquipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEquipeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEquipe
            // 
            this.dataGridViewEquipe.AutoGenerateColumns = false;
            this.dataGridViewEquipe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEquipe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEquipeDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.tagDataGridViewTextBoxColumn,
            this.tblTravailDataGridViewTextBoxColumn,
            this.tblEmployeDataGridViewTextBoxColumn});
            this.dataGridViewEquipe.DataSource = this.tblEquipeBindingSource;
            this.dataGridViewEquipe.Location = new System.Drawing.Point(0, 3);
            this.dataGridViewEquipe.Name = "dataGridViewEquipe";
            this.dataGridViewEquipe.Size = new System.Drawing.Size(344, 281);
            this.dataGridViewEquipe.TabIndex = 0;
            // 
            // tblEquipeBindingSource
            // 
            this.tblEquipeBindingSource.DataSource = typeof(Projet_Texcel.tblEquipe);
            // 
            // idEquipeDataGridViewTextBoxColumn
            // 
            this.idEquipeDataGridViewTextBoxColumn.DataPropertyName = "idEquipe";
            this.idEquipeDataGridViewTextBoxColumn.HeaderText = "idEquipe";
            this.idEquipeDataGridViewTextBoxColumn.Name = "idEquipeDataGridViewTextBoxColumn";
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
            // tblTravailDataGridViewTextBoxColumn
            // 
            this.tblTravailDataGridViewTextBoxColumn.DataPropertyName = "tblTravail";
            this.tblTravailDataGridViewTextBoxColumn.HeaderText = "tblTravail";
            this.tblTravailDataGridViewTextBoxColumn.Name = "tblTravailDataGridViewTextBoxColumn";
            this.tblTravailDataGridViewTextBoxColumn.Visible = false;
            // 
            // tblEmployeDataGridViewTextBoxColumn
            // 
            this.tblEmployeDataGridViewTextBoxColumn.DataPropertyName = "tblEmploye";
            this.tblEmployeDataGridViewTextBoxColumn.HeaderText = "tblEmploye";
            this.tblEmployeDataGridViewTextBoxColumn.Name = "tblEmployeDataGridViewTextBoxColumn";
            this.tblEmployeDataGridViewTextBoxColumn.Visible = false;
            // 
            // afficherEquipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 286);
            this.Controls.Add(this.dataGridViewEquipe);
            this.Name = "afficherEquipe";
            this.Text = "afficherEquipe";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEquipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEquipeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewEquipe;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEquipeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tblTravailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tblEmployeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tblEquipeBindingSource;
    }
}