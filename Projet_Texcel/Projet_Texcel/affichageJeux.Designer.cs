﻿namespace Projet_Texcel
{
    partial class affichageJeux
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
            this.txtJeux = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtJeux
            // 
            this.txtJeux.Location = new System.Drawing.Point(-1, 0);
            this.txtJeux.Name = "txtJeux";
            this.txtJeux.Size = new System.Drawing.Size(283, 254);
            this.txtJeux.TabIndex = 0;
            this.txtJeux.Text = "";
            // 
            // affichageJeux
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 255);
            this.Controls.Add(this.txtJeux);
            this.Name = "affichageJeux";
            this.Text = "affichageJeux";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.affichageJeux_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtJeux;
    }
}