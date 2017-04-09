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
            this.bdTexelFredAlexDataSet = new Projet_Texcel.bdTexelFredAlexDataSet();
            this.tblClassificationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblClassificationTableAdapter = new Projet_Texcel.bdTexelFredAlexDataSetTableAdapters.tblClassificationTableAdapter();
            this.tableAdapterManager = new Projet_Texcel.bdTexelFredAlexDataSetTableAdapters.TableAdapterManager();
            this.bdTexelFredAlexEntitiesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bdTexelFredAlexEntitiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bdTexelFredAlexDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblClassificationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdTexelFredAlexEntitiesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdTexelFredAlexEntitiesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bdTexelFredAlexDataSet
            // 
            this.bdTexelFredAlexDataSet.DataSetName = "bdTexelFredAlexDataSet";
            this.bdTexelFredAlexDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblClassificationBindingSource
            // 
            this.tblClassificationBindingSource.DataMember = "tblClassification";
            this.tblClassificationBindingSource.DataSource = this.bdTexelFredAlexDataSet;
            // 
            // tblClassificationTableAdapter
            // 
            this.tblClassificationTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblCategorieTestTableAdapter = null;
            this.tableAdapterManager.tblClassificationTableAdapter = this.tblClassificationTableAdapter;
            this.tableAdapterManager.tblEmployeEquipeTableAdapter = null;
            this.tableAdapterManager.tblEmployeTableAdapter = null;
            this.tableAdapterManager.tblEquipeTableAdapter = null;
            this.tableAdapterManager.tblGenreTableAdapter = null;
            this.tableAdapterManager.tblJeuTableAdapter = null;
            this.tableAdapterManager.tblPlatformTableAdapter = null;
            this.tableAdapterManager.tblProjetTableAdapter = null;
            this.tableAdapterManager.tblRoleTableAdapter = null;
            this.tableAdapterManager.tblSystemExploitationTableAdapter = null;
            this.tableAdapterManager.tblTestTableAdapter = null;
            this.tableAdapterManager.tblThemeTableAdapter = null;
            this.tableAdapterManager.tblTravailTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projet_Texcel.bdTexelFredAlexDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bdTexelFredAlexEntitiesBindingSource1
            // 
            this.bdTexelFredAlexEntitiesBindingSource1.DataSource = typeof(Projet_Texcel.bdTexelFredAlexEntities);
            // 
            // bdTexelFredAlexEntitiesBindingSource
            // 
            this.bdTexelFredAlexEntitiesBindingSource.DataSource = typeof(Projet_Texcel.bdTexelFredAlexEntities);
            // 
            // affichageClassification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 354);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "affichageClassification";
            this.Text = "affichageClassification";
            this.Load += new System.EventHandler(this.affichageClassification_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdTexelFredAlexDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblClassificationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdTexelFredAlexEntitiesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdTexelFredAlexEntitiesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private bdTexelFredAlexDataSet bdTexelFredAlexDataSet;
        private System.Windows.Forms.BindingSource tblClassificationBindingSource;
        private bdTexelFredAlexDataSetTableAdapters.tblClassificationTableAdapter tblClassificationTableAdapter;
        private bdTexelFredAlexDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource bdTexelFredAlexEntitiesBindingSource1;
        private System.Windows.Forms.BindingSource bdTexelFredAlexEntitiesBindingSource;
    }
}