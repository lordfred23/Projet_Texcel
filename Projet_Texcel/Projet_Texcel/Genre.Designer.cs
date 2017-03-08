namespace Projet_Texcel
{
    partial class Genre
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
            this.btnCreerGenre = new System.Windows.Forms.Button();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCreerGenre
            // 
            this.btnCreerGenre.Location = new System.Drawing.Point(77, 105);
            this.btnCreerGenre.Name = "btnCreerGenre";
            this.btnCreerGenre.Size = new System.Drawing.Size(134, 38);
            this.btnCreerGenre.TabIndex = 5;
            this.btnCreerGenre.Text = "Créer Genre";
            this.btnCreerGenre.UseVisualStyleBackColor = true;
            this.btnCreerGenre.Click += new System.EventHandler(this.btnCreerGenre_Click);
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(64, 41);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(159, 22);
            this.txtGenre.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nom du genre :";
            // 
            // Genre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 176);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.btnCreerGenre);
            this.Name = "Genre";
            this.Text = "Genre";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Genre_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreerGenre;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.Label label1;
    }
}