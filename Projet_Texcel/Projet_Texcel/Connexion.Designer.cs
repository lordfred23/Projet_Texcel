namespace Projet_Texcel
{
    partial class Connexion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Connexion));
            this.button1 = new System.Windows.Forms.Button();
            this.txtUti = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picValid1 = new System.Windows.Forms.PictureBox();
            this.picError1 = new System.Windows.Forms.PictureBox();
            this.picValid2 = new System.Windows.Forms.PictureBox();
            this.picError2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picValid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picError1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picValid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picError2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(101, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "Connexion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtUti
            // 
            this.txtUti.Location = new System.Drawing.Point(62, 69);
            this.txtUti.Name = "txtUti";
            this.txtUti.Size = new System.Drawing.Size(187, 22);
            this.txtUti.TabIndex = 1;
            this.txtUti.Tag = "1";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(62, 140);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(187, 22);
            this.txtPass.TabIndex = 2;
            this.txtPass.Tag = "2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Utilisateur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mot de passe";
            // 
            // picValid1
            // 
            this.picValid1.Image = global::Projet_Texcel.Properties.Resources.images__1_;
            this.picValid1.Location = new System.Drawing.Point(255, 69);
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
            this.picError1.Location = new System.Drawing.Point(255, 69);
            this.picError1.Name = "picError1";
            this.picError1.Size = new System.Drawing.Size(20, 21);
            this.picError1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picError1.TabIndex = 13;
            this.picError1.TabStop = false;
            this.picError1.Visible = false;
            // 
            // picValid2
            // 
            this.picValid2.Image = global::Projet_Texcel.Properties.Resources.images__1_;
            this.picValid2.Location = new System.Drawing.Point(255, 140);
            this.picValid2.Name = "picValid2";
            this.picValid2.Size = new System.Drawing.Size(20, 21);
            this.picValid2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picValid2.TabIndex = 16;
            this.picValid2.TabStop = false;
            this.picValid2.Visible = false;
            // 
            // picError2
            // 
            this.picError2.Image = ((System.Drawing.Image)(resources.GetObject("picError2.Image")));
            this.picError2.Location = new System.Drawing.Point(255, 140);
            this.picError2.Name = "picError2";
            this.picError2.Size = new System.Drawing.Size(20, 21);
            this.picError2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picError2.TabIndex = 15;
            this.picError2.TabStop = false;
            this.picError2.Visible = false;
            // 
            // Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(333, 303);
            this.Controls.Add(this.picValid2);
            this.Controls.Add(this.picError2);
            this.Controls.Add(this.picValid1);
            this.Controls.Add(this.picError1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUti);
            this.Controls.Add(this.button1);
            this.Name = "Connexion";
            this.Text = "Connexion";
            ((System.ComponentModel.ISupportInitialize)(this.picValid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picError1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picValid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picError2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtUti;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picValid1;
        private System.Windows.Forms.PictureBox picError1;
        private System.Windows.Forms.PictureBox picValid2;
        private System.Windows.Forms.PictureBox picError2;
    }
}