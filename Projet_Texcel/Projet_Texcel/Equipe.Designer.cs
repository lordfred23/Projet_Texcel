namespace Projet_Texcel
{
    partial class Equipe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Equipe));
            this.btnCreerEquipe = new System.Windows.Forms.Button();
            this.txtNomEquipe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstEmploye1 = new System.Windows.Forms.ComboBox();
            this.picValid1 = new System.Windows.Forms.PictureBox();
            this.picError1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picValid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picError1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreerEquipe
            // 
            this.btnCreerEquipe.Location = new System.Drawing.Point(133, 140);
            this.btnCreerEquipe.Name = "btnCreerEquipe";
            this.btnCreerEquipe.Size = new System.Drawing.Size(134, 38);
            this.btnCreerEquipe.TabIndex = 6;
            this.btnCreerEquipe.Text = "Créer Équipe";
            this.btnCreerEquipe.UseVisualStyleBackColor = true;
            this.btnCreerEquipe.Click += new System.EventHandler(this.btnCreerEquipe_Click);
            // 
            // txtNomEquipe
            // 
            this.txtNomEquipe.Location = new System.Drawing.Point(191, 32);
            this.txtNomEquipe.Name = "txtNomEquipe";
            this.txtNomEquipe.Size = new System.Drawing.Size(173, 22);
            this.txtNomEquipe.TabIndex = 7;
            this.txtNomEquipe.Tag = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nom de l\'équipe :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Employé associé :";
            // 
            // lstEmploye1
            // 
            this.lstEmploye1.FormattingEnabled = true;
            this.lstEmploye1.Items.AddRange(new object[] {
            "Alexandre Tremblay",
            "Frédérick Côté"});
            this.lstEmploye1.Location = new System.Drawing.Point(191, 68);
            this.lstEmploye1.Name = "lstEmploye1";
            this.lstEmploye1.Size = new System.Drawing.Size(173, 24);
            this.lstEmploye1.TabIndex = 10;
            this.lstEmploye1.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // picValid1
            // 
            this.picValid1.Image = global::Projet_Texcel.Properties.Resources.images__1_;
            this.picValid1.Location = new System.Drawing.Point(370, 33);
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
            this.picError1.Location = new System.Drawing.Point(370, 33);
            this.picError1.Name = "picError1";
            this.picError1.Size = new System.Drawing.Size(20, 21);
            this.picError1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picError1.TabIndex = 13;
            this.picError1.TabStop = false;
            this.picError1.Visible = false;
            // 
            // Equipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 199);
            this.Controls.Add(this.picValid1);
            this.Controls.Add(this.picError1);
            this.Controls.Add(this.lstEmploye1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomEquipe);
            this.Controls.Add(this.btnCreerEquipe);
            this.Name = "Equipe";
            this.Text = "Equipe";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Equipe_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.picValid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picError1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreerEquipe;
        private System.Windows.Forms.TextBox txtNomEquipe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox lstEmploye1;
        private System.Windows.Forms.PictureBox picValid1;
        private System.Windows.Forms.PictureBox picError1;
    }
}