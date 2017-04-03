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
            this.bindingPlatforme = new System.Windows.Forms.BindingSource(this.components);
            this.bdTexelFredAlexDataSet2 = new Projet_Texcel.bdTexelFredAlexDataSet2();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tblPlatformBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblPlatformTableAdapter = new Projet_Texcel.bdTexelFredAlexDataSet2TableAdapters.tblPlatformTableAdapter();
            this.idPlatformDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.configDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typePlatformDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSysExpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bindingPlatforme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdTexelFredAlexDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPlatformBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingPlatforme
            // 
            this.bindingPlatforme.DataSource = this.bdTexelFredAlexDataSet2;
            this.bindingPlatforme.Position = 0;
            // 
            // bdTexelFredAlexDataSet2
            // 
            this.bdTexelFredAlexDataSet2.DataSetName = "bdTexelFredAlexDataSet2";
            this.bdTexelFredAlexDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPlatformDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.configDataGridViewTextBoxColumn,
            this.typePlatformDataGridViewTextBoxColumn,
            this.idSysExpDataGridViewTextBoxColumn,
            this.tagDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblPlatformBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(644, 367);
            this.dataGridView1.TabIndex = 0;
            // 
            // tblPlatformBindingSource
            // 
            this.tblPlatformBindingSource.DataMember = "tblPlatform";
            this.tblPlatformBindingSource.DataSource = this.bindingPlatforme;
            // 
            // tblPlatformTableAdapter
            // 
            this.tblPlatformTableAdapter.ClearBeforeFill = true;
            // 
            // idPlatformDataGridViewTextBoxColumn
            // 
            this.idPlatformDataGridViewTextBoxColumn.DataPropertyName = "idPlatform";
            this.idPlatformDataGridViewTextBoxColumn.HeaderText = "idPlatform";
            this.idPlatformDataGridViewTextBoxColumn.Name = "idPlatformDataGridViewTextBoxColumn";
            this.idPlatformDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.ClientSize = new System.Drawing.Size(643, 368);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "affichagePlatforme";
            this.Text = "affichagePlatforme";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.affichagePlatforme_FormClosing);
            this.Load += new System.EventHandler(this.affichagePlatforme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingPlatforme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdTexelFredAlexDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPlatformBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingPlatforme;
        private bdTexelFredAlexDataSet2 bdTexelFredAlexDataSet2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource tblPlatformBindingSource;
        private bdTexelFredAlexDataSet2TableAdapters.tblPlatformTableAdapter tblPlatformTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPlatformDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn configDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typePlatformDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSysExpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tagDataGridViewTextBoxColumn;
    }
}