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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCatego = new System.Windows.Forms.TextBox();
            this.btnCreerCatego = new System.Windows.Forms.Button();
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
            // Categorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 173);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCatego);
            this.Controls.Add(this.btnCreerCatego);
            this.Name = "Categorie";
            this.Text = "Categorie";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Categorie_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCatego;
        private System.Windows.Forms.Button btnCreerCatego;
    }
}