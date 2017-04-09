namespace Projet_Texcel
{
    partial class affichagePlatforme
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
            this.dataGridViewPlatforme = new System.Windows.Forms.DataGridView();
            this.tblPlatformBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idPlatformDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.configDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typePlatformDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSysExpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlatforme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPlatformBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPlatforme
            // 
            this.dataGridViewPlatforme.AllowUserToAddRows = false;
            this.dataGridViewPlatforme.AllowUserToDeleteRows = false;
            this.dataGridViewPlatforme.AllowUserToResizeColumns = false;
            this.dataGridViewPlatforme.AllowUserToResizeRows = false;
            this.dataGridViewPlatforme.AutoGenerateColumns = false;
            this.dataGridViewPlatforme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPlatforme.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPlatformDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.configDataGridViewTextBoxColumn,
            this.typePlatformDataGridViewTextBoxColumn,
            this.idSysExpDataGridViewTextBoxColumn,
            this.tagDataGridViewTextBoxColumn});
            this.dataGridViewPlatforme.DataSource = this.tblPlatformBindingSource;
            this.dataGridViewPlatforme.Location = new System.Drawing.Point(2, 2);
            this.dataGridViewPlatforme.Name = "dataGridViewPlatforme";
            this.dataGridViewPlatforme.RowTemplate.Height = 24;
            this.dataGridViewPlatforme.Size = new System.Drawing.Size(644, 315);
            this.dataGridViewPlatforme.TabIndex = 0;
            // 
            // tblPlatformBindingSource
            // 
            this.tblPlatformBindingSource.DataSource = typeof(Projet_Texcel.tblPlatform);
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
            // configDataGridViewTextBoxColumn
            // 
            this.configDataGridViewTextBoxColumn.DataPropertyName = "config";
            this.configDataGridViewTextBoxColumn.HeaderText = "config";
            this.configDataGridViewTextBoxColumn.Name = "configDataGridViewTextBoxColumn";
            // 
            // typePlatformDataGridViewTextBoxColumn
            // 
            this.typePlatformDataGridViewTextBoxColumn.DataPropertyName = "typePlatform";
            this.typePlatformDataGridViewTextBoxColumn.HeaderText = "typePlatform";
            this.typePlatformDataGridViewTextBoxColumn.Name = "typePlatformDataGridViewTextBoxColumn";
            // 
            // idSysExpDataGridViewTextBoxColumn
            // 
            this.idSysExpDataGridViewTextBoxColumn.DataPropertyName = "idSysExp";
            this.idSysExpDataGridViewTextBoxColumn.HeaderText = "idSysExp";
            this.idSysExpDataGridViewTextBoxColumn.Name = "idSysExpDataGridViewTextBoxColumn";
            // 
            // tagDataGridViewTextBoxColumn
            // 
            this.tagDataGridViewTextBoxColumn.DataPropertyName = "tag";
            this.tagDataGridViewTextBoxColumn.HeaderText = "tag";
            this.tagDataGridViewTextBoxColumn.Name = "tagDataGridViewTextBoxColumn";
            // 
            // affichagePlatforme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 318);
            this.Controls.Add(this.dataGridViewPlatforme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "affichagePlatforme";
            this.Text = "affichagePlatforme";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.affichagePlatforme_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlatforme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPlatformBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPlatforme;
        private System.Windows.Forms.BindingSource tblPlatformBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPlatformDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn configDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typePlatformDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSysExpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tagDataGridViewTextBoxColumn;
    }
}