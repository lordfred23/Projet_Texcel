namespace Projet_Texcel
{
    partial class afficherEquipe
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
            this.txtEquipe = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtEquipe
            // 
            this.txtEquipe.Location = new System.Drawing.Point(0, 0);
            this.txtEquipe.Name = "txtEquipe";
            this.txtEquipe.Size = new System.Drawing.Size(283, 260);
            this.txtEquipe.TabIndex = 0;
            this.txtEquipe.Text = "";
            // 
            // afficherEquipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtEquipe);
            this.Name = "afficherEquipe";
            this.Text = "afficherEquipe";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtEquipe;
    }
}