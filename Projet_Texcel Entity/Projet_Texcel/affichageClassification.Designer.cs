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
            this.bindingClassification = new System.Windows.Forms.BindingSource(this.components);
            this.bdTexelFredAlexDataSet = new Projet_Texcel.bdTexelFredAlexDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tblClassificationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblClassificationTableAdapter = new Projet_Texcel.bdTexelFredAlexDataSetTableAdapters.tblClassificationTableAdapter();
            this.idClassificationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblClassificationBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingClassification)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdTexelFredAlexDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblClassificationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblClassificationBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingClassification
            // 
            this.bindingClassification.DataSource = this.bdTexelFredAlexDataSet;
            this.bindingClassification.Position = 0;
            // 
            // bdTexelFredAlexDataSet
            // 
            this.bdTexelFredAlexDataSet.DataSetName = "bdTexelFredAlexDataSet";
            this.bdTexelFredAlexDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.idClassificationDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.tagDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblClassificationBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(2, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(451, 245);
            this.dataGridView1.TabIndex = 0;
            // 
            // tblClassificationBindingSource
            // 
            this.tblClassificationBindingSource.DataMember = "tblClassification";
            this.tblClassificationBindingSource.DataSource = this.bindingClassification;
            // 
            // tblClassificationTableAdapter
            // 
            this.tblClassificationTableAdapter.ClearBeforeFill = true;
            // 
            // idClassificationDataGridViewTextBoxColumn
            // 
            this.idClassificationDataGridViewTextBoxColumn.DataPropertyName = "idClassification";
            this.idClassificationDataGridViewTextBoxColumn.HeaderText = "idClassification";
            this.idClassificationDataGridViewTextBoxColumn.Name = "idClassificationDataGridViewTextBoxColumn";
            this.idClassificationDataGridViewTextBoxColumn.ReadOnly = true;
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
            // tblClassificationBindingSource1
            // 
            this.tblClassificationBindingSource1.DataMember = "tblClassification";
            this.tblClassificationBindingSource1.DataSource = this.bindingClassification;
            // 
            // affichageClassification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 253);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "affichageClassification";
            this.Text = "affichageClassification";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.affichageGenre_FormClosing);
            this.Load += new System.EventHandler(this.affichageClassification_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingClassification)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdTexelFredAlexDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblClassificationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblClassificationBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingClassification;
        private bdTexelFredAlexDataSet bdTexelFredAlexDataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource tblClassificationBindingSource;
        private bdTexelFredAlexDataSetTableAdapters.tblClassificationTableAdapter tblClassificationTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClassificationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tagDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tblClassificationBindingSource1;
    }
}