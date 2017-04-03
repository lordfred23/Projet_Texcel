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
            this.bindingGenre = new System.Windows.Forms.BindingSource(this.components);
            this.bdTexelFredAlexDSgenre = new Projet_Texcel.bdTexelFredAlexDSgenre();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tblGenreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblGenreTableAdapter = new Projet_Texcel.bdTexelFredAlexDSgenreTableAdapters.tblGenreTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bindingGenre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdTexelFredAlexDSgenre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblGenreBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bdTexelFredAlexDSgenre
            // 
            this.bdTexelFredAlexDSgenre.DataSetName = "bdTexelFredAlexDSgenre";
            this.bdTexelFredAlexDSgenre.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.tblGenreBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(443, 303);
            this.dataGridView1.TabIndex = 0;
            // 
            // tblGenreBindingSource
            // 
            this.tblGenreBindingSource.DataSource = this.bindingGenre;
            // 
            // tblGenreTableAdapter
            // 
            this.tblGenreTableAdapter.ClearBeforeFill = true;
            // 
            // affichageGenre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 304);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "affichageGenre";
            this.Text = "affichageGenre";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.affichageGenre_FormClosing);
            this.Load += new System.EventHandler(this.affichageGenre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingGenre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdTexelFredAlexDSgenre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblGenreBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingGenre;
        private bdTexelFredAlexDSgenre bdTexelFredAlexDSgenre;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource tblGenreBindingSource;
        private bdTexelFredAlexDSgenreTableAdapters.tblGenreTableAdapter tblGenreTableAdapter;
    }
}