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
            this.bindingEquipe = new System.Windows.Forms.BindingSource(this.components);
            this.bdTexelFredAlexDataSet3 = new Projet_Texcel.bdTexelFredAlexDataSet3();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tblEquipeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblEquipeTableAdapter = new Projet_Texcel.bdTexelFredAlexDataSet3TableAdapters.tblEquipeTableAdapter();
            this.idEquipeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bindingEquipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdTexelFredAlexDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEquipeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingEquipe
            // 
            this.bindingEquipe.DataSource = this.bdTexelFredAlexDataSet3;
            this.bindingEquipe.Position = 0;
            // 
            // bdTexelFredAlexDataSet3
            // 
            this.bdTexelFredAlexDataSet3.DataSetName = "bdTexelFredAlexDataSet3";
            this.bdTexelFredAlexDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEquipeDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.tagDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblEquipeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(344, 319);
            this.dataGridView1.TabIndex = 0;
            // 
            // tblEquipeBindingSource
            // 
            this.tblEquipeBindingSource.DataMember = "tblEquipe";
            this.tblEquipeBindingSource.DataSource = this.bindingEquipe;
            // 
            // tblEquipeTableAdapter
            // 
            this.tblEquipeTableAdapter.ClearBeforeFill = true;
            // 
            // idEquipeDataGridViewTextBoxColumn
            // 
            this.idEquipeDataGridViewTextBoxColumn.DataPropertyName = "idEquipe";
            this.idEquipeDataGridViewTextBoxColumn.HeaderText = "idEquipe";
            this.idEquipeDataGridViewTextBoxColumn.Name = "idEquipeDataGridViewTextBoxColumn";
            this.idEquipeDataGridViewTextBoxColumn.ReadOnly = true;
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
            // afficherEquipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 321);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "afficherEquipe";
            this.Text = "afficherEquipe";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.affichageGenre_FormClosing);
            this.Load += new System.EventHandler(this.afficherEquipe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingEquipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdTexelFredAlexDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEquipeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingEquipe;
        private bdTexelFredAlexDataSet3 bdTexelFredAlexDataSet3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource tblEquipeBindingSource;
        private bdTexelFredAlexDataSet3TableAdapters.tblEquipeTableAdapter tblEquipeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEquipeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tagDataGridViewTextBoxColumn;
    }
}