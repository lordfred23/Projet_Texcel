namespace Projet_Texcel
{
    partial class affichageEmploye
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
            this.bindingEmploye = new System.Windows.Forms.BindingSource(this.components);
            this.bdTexelFredAlexDataSet1 = new Projet_Texcel.bdTexelFredAlexDataSet1();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tblEmployeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblEmployeTableAdapter = new Projet_Texcel.bdTexelFredAlexDataSet1TableAdapters.tblEmployeTableAdapter();
            this.matriculeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateNaissanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noTelephoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.posteTelephoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noTelephoneMaisonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idRoleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bindingEmploye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdTexelFredAlexDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmployeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingEmploye
            // 
            this.bindingEmploye.DataSource = this.bdTexelFredAlexDataSet1;
            this.bindingEmploye.Position = 0;
            // 
            // bdTexelFredAlexDataSet1
            // 
            this.bdTexelFredAlexDataSet1.DataSetName = "bdTexelFredAlexDataSet1";
            this.bdTexelFredAlexDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.matriculeDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.prenomDataGridViewTextBoxColumn,
            this.dateNaissanceDataGridViewTextBoxColumn,
            this.adresseDataGridViewTextBoxColumn,
            this.noTelephoneDataGridViewTextBoxColumn,
            this.posteTelephoneDataGridViewTextBoxColumn,
            this.noTelephoneMaisonDataGridViewTextBoxColumn,
            this.idRoleDataGridViewTextBoxColumn,
            this.tagDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblEmployeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1044, 444);
            this.dataGridView1.TabIndex = 0;
            // 
            // tblEmployeBindingSource
            // 
            this.tblEmployeBindingSource.DataMember = "tblEmploye";
            this.tblEmployeBindingSource.DataSource = this.bindingEmploye;
            // 
            // tblEmployeTableAdapter
            // 
            this.tblEmployeTableAdapter.ClearBeforeFill = true;
            // 
            // matriculeDataGridViewTextBoxColumn
            // 
            this.matriculeDataGridViewTextBoxColumn.DataPropertyName = "matricule";
            this.matriculeDataGridViewTextBoxColumn.HeaderText = "matricule";
            this.matriculeDataGridViewTextBoxColumn.Name = "matriculeDataGridViewTextBoxColumn";
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "nom";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            // 
            // prenomDataGridViewTextBoxColumn
            // 
            this.prenomDataGridViewTextBoxColumn.DataPropertyName = "prenom";
            this.prenomDataGridViewTextBoxColumn.HeaderText = "prenom";
            this.prenomDataGridViewTextBoxColumn.Name = "prenomDataGridViewTextBoxColumn";
            // 
            // dateNaissanceDataGridViewTextBoxColumn
            // 
            this.dateNaissanceDataGridViewTextBoxColumn.DataPropertyName = "dateNaissance";
            this.dateNaissanceDataGridViewTextBoxColumn.HeaderText = "dateNaissance";
            this.dateNaissanceDataGridViewTextBoxColumn.Name = "dateNaissanceDataGridViewTextBoxColumn";
            // 
            // adresseDataGridViewTextBoxColumn
            // 
            this.adresseDataGridViewTextBoxColumn.DataPropertyName = "adresse";
            this.adresseDataGridViewTextBoxColumn.HeaderText = "adresse";
            this.adresseDataGridViewTextBoxColumn.Name = "adresseDataGridViewTextBoxColumn";
            // 
            // noTelephoneDataGridViewTextBoxColumn
            // 
            this.noTelephoneDataGridViewTextBoxColumn.DataPropertyName = "noTelephone";
            this.noTelephoneDataGridViewTextBoxColumn.HeaderText = "noTelephone";
            this.noTelephoneDataGridViewTextBoxColumn.Name = "noTelephoneDataGridViewTextBoxColumn";
            // 
            // posteTelephoneDataGridViewTextBoxColumn
            // 
            this.posteTelephoneDataGridViewTextBoxColumn.DataPropertyName = "posteTelephone";
            this.posteTelephoneDataGridViewTextBoxColumn.HeaderText = "posteTelephone";
            this.posteTelephoneDataGridViewTextBoxColumn.Name = "posteTelephoneDataGridViewTextBoxColumn";
            // 
            // noTelephoneMaisonDataGridViewTextBoxColumn
            // 
            this.noTelephoneMaisonDataGridViewTextBoxColumn.DataPropertyName = "noTelephoneMaison";
            this.noTelephoneMaisonDataGridViewTextBoxColumn.HeaderText = "noTelephoneMaison";
            this.noTelephoneMaisonDataGridViewTextBoxColumn.Name = "noTelephoneMaisonDataGridViewTextBoxColumn";
            // 
            // idRoleDataGridViewTextBoxColumn
            // 
            this.idRoleDataGridViewTextBoxColumn.DataPropertyName = "idRole";
            this.idRoleDataGridViewTextBoxColumn.HeaderText = "idRole";
            this.idRoleDataGridViewTextBoxColumn.Name = "idRoleDataGridViewTextBoxColumn";
            // 
            // tagDataGridViewTextBoxColumn
            // 
            this.tagDataGridViewTextBoxColumn.DataPropertyName = "tag";
            this.tagDataGridViewTextBoxColumn.HeaderText = "tag";
            this.tagDataGridViewTextBoxColumn.Name = "tagDataGridViewTextBoxColumn";
            // 
            // affichageEmploye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 444);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "affichageEmploye";
            this.Text = "Affichage Employe";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.affichageEmploye_FormClosing);
            this.Load += new System.EventHandler(this.affichageEmploye_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingEmploye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdTexelFredAlexDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmployeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingEmploye;
        private bdTexelFredAlexDataSet1 bdTexelFredAlexDataSet1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource tblEmployeBindingSource;
        private bdTexelFredAlexDataSet1TableAdapters.tblEmployeTableAdapter tblEmployeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn matriculeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateNaissanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noTelephoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn posteTelephoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noTelephoneMaisonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRoleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tagDataGridViewTextBoxColumn;
    }
}