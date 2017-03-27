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
            this.txtClassif = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtClassif
            // 
            this.txtClassif.Location = new System.Drawing.Point(-1, 2);
            this.txtClassif.Name = "txtClassif";
            this.txtClassif.Size = new System.Drawing.Size(285, 258);
            this.txtClassif.TabIndex = 0;
            this.txtClassif.Text = "";
            // 
            // affichageClassification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtClassif);
            this.Name = "affichageClassification";
            this.Text = "affichageClassification";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtClassif;
    }
}