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
            this.txtPlatforme = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtPlatforme
            // 
            this.txtPlatforme.Location = new System.Drawing.Point(-1, -1);
            this.txtPlatforme.Name = "txtPlatforme";
            this.txtPlatforme.Size = new System.Drawing.Size(283, 257);
            this.txtPlatforme.TabIndex = 0;
            this.txtPlatforme.Text = "";
            // 
            // affichagePlatforme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 255);
            this.Controls.Add(this.txtPlatforme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "affichagePlatforme";
            this.Text = "affichagePlatforme";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.affichagePlatforme_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtPlatforme;
    }
}