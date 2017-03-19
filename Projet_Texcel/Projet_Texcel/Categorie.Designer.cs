namespace Projet_Texcel
{
    partial class Categorie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Categorie));
            this.label1 = new System.Windows.Forms.Label();
            this.txtCatego = new System.Windows.Forms.TextBox();
            this.btnCreerCatego = new System.Windows.Forms.Button();
            this.picValid1 = new System.Windows.Forms.PictureBox();
            this.picError1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picValid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picError1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nom de catégorie :";
            // 
            // txtCatego
            // 
            this.txtCatego.Location = new System.Drawing.Point(50, 43);
            this.txtCatego.Name = "txtCatego";
            this.txtCatego.Size = new System.Drawing.Size(159, 22);
            this.txtCatego.TabIndex = 9;
            this.txtCatego.Tag = "1";
            this.txtCatego.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // btnCreerCatego
            // 
            this.btnCreerCatego.Location = new System.Drawing.Point(63, 107);
            this.btnCreerCatego.Name = "btnCreerCatego";
            this.btnCreerCatego.Size = new System.Drawing.Size(134, 38);
            this.btnCreerCatego.TabIndex = 8;
            this.btnCreerCatego.Text = "Créer Catégorie";
            this.btnCreerCatego.UseVisualStyleBackColor = true;
            this.btnCreerCatego.Click += new System.EventHandler(this.btnCreerCatego_Click);
            // 
            // picValid1
            // 
            this.picValid1.Image = global::Projet_Texcel.Properties.Resources.images__1_;
            this.picValid1.Location = new System.Drawing.Point(215, 44);
            this.picValid1.Name = "picValid1";
            this.picValid1.Size = new System.Drawing.Size(20, 21);
            this.picValid1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picValid1.TabIndex = 14;
            this.picValid1.TabStop = false;
            this.picValid1.Visible = false;
            // 
            // picError1
            // 
            this.picError1.Image = ((System.Drawing.Image)(resources.GetObject("picError1.Image")));
            this.picError1.Location = new System.Drawing.Point(215, 44);
            this.picError1.Name = "picError1";
            this.picError1.Size = new System.Drawing.Size(20, 21);
            this.picError1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picError1.TabIndex = 13;
            this.picError1.TabStop = false;
            this.picError1.Visible = false;
            // 
            // Categorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 173);
            this.Controls.Add(this.picValid1);
            this.Controls.Add(this.picError1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCatego);
            this.Controls.Add(this.btnCreerCatego);
            this.Name = "Categorie";
            this.Text = "Categorie";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Categorie_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.picValid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picError1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCatego;
        private System.Windows.Forms.Button btnCreerCatego;
        private System.Windows.Forms.PictureBox picValid1;
        private System.Windows.Forms.PictureBox picError1;
    }
}