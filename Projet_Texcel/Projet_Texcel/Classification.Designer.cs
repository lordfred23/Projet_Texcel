﻿namespace Projet_Texcel
{
    partial class Classification
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtClassif = new System.Windows.Forms.TextBox();
            this.btnCreerClassif = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nom de classification :";
            // 
            // txtClassif
            // 
            this.txtClassif.Location = new System.Drawing.Point(51, 39);
            this.txtClassif.Name = "txtClassif";
            this.txtClassif.Size = new System.Drawing.Size(159, 22);
            this.txtClassif.TabIndex = 9;
            // 
            // btnCreerClassif
            // 
            this.btnCreerClassif.Location = new System.Drawing.Point(64, 103);
            this.btnCreerClassif.Name = "btnCreerClassif";
            this.btnCreerClassif.Size = new System.Drawing.Size(134, 45);
            this.btnCreerClassif.TabIndex = 8;
            this.btnCreerClassif.Text = "Créer Classification";
            this.btnCreerClassif.UseVisualStyleBackColor = true;
            this.btnCreerClassif.Click += new System.EventHandler(this.btnCreerClassif_Click);
            // 
            // Classification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 173);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtClassif);
            this.Controls.Add(this.btnCreerClassif);
            this.Name = "Classification";
            this.Text = "Classification";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Classification_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtClassif;
        private System.Windows.Forms.Button btnCreerClassif;
    }
}