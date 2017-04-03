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
            this.txtEmploye = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtEmploye
            // 
            this.txtEmploye.Location = new System.Drawing.Point(0, 2);
            this.txtEmploye.Name = "txtEmploye";
            this.txtEmploye.Size = new System.Drawing.Size(377, 438);
            this.txtEmploye.TabIndex = 0;
            this.txtEmploye.Text = "";
            // 
            // affichageEmploye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 444);
            this.Controls.Add(this.txtEmploye);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "affichageEmploye";
            this.Text = "Affichage Employe";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.affichageEmploye_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtEmploye;
    }
}