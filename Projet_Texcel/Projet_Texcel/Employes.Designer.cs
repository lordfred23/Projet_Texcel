namespace Projet_Texcel
{
    partial class Employes
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
            this.btnCreerEmploye = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstCategories = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMatricule = new System.Windows.Forms.TextBox();
            this.txtTelePoste = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtJours = new System.Windows.Forms.TextBox();
            this.txtMois = new System.Windows.Forms.TextBox();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.txtAnnee = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCour = new System.Windows.Forms.TextBox();
            this.txtTeleResid = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstEquipe = new System.Windows.Forms.ComboBox();
            this.btnCreerEquipe = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreerEmploye
            // 
            this.btnCreerEmploye.Location = new System.Drawing.Point(50, 398);
            this.btnCreerEmploye.Name = "btnCreerEmploye";
            this.btnCreerEmploye.Size = new System.Drawing.Size(134, 38);
            this.btnCreerEmploye.TabIndex = 0;
            this.btnCreerEmploye.Text = "Créer Employé";
            this.btnCreerEmploye.UseVisualStyleBackColor = true;
            this.btnCreerEmploye.Click += new System.EventHandler(this.btnCreerEmploye_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstCategories);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtMatricule);
            this.groupBox1.Controls.Add(this.txtTelePoste);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtJours);
            this.groupBox1.Controls.Add(this.txtMois);
            this.groupBox1.Controls.Add(this.txtAdresse);
            this.groupBox1.Controls.Add(this.txtAnnee);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtCour);
            this.groupBox1.Controls.Add(this.txtTeleResid);
            this.groupBox1.Controls.Add(this.txtPrenom);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNom);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 301);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employé";
            // 
            // lstCategories
            // 
            this.lstCategories.FormattingEnabled = true;
            this.lstCategories.Location = new System.Drawing.Point(149, 264);
            this.lstCategories.Name = "lstCategories";
            this.lstCategories.Size = new System.Drawing.Size(121, 24);
            this.lstCategories.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 264);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 17);
            this.label10.TabIndex = 29;
            this.label10.Text = "Catégories :";
            // 
            // txtMatricule
            // 
            this.txtMatricule.Location = new System.Drawing.Point(149, 233);
            this.txtMatricule.Name = "txtMatricule";
            this.txtMatricule.Size = new System.Drawing.Size(174, 22);
            this.txtMatricule.TabIndex = 27;
            // 
            // txtTelePoste
            // 
            this.txtTelePoste.Location = new System.Drawing.Point(149, 205);
            this.txtTelePoste.Name = "txtTelePoste";
            this.txtTelePoste.Size = new System.Drawing.Size(174, 22);
            this.txtTelePoste.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 17);
            this.label7.TabIndex = 25;
            this.label7.Text = "Matricule :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 17);
            this.label8.TabIndex = 24;
            this.label8.Text = "Télé Poste :";
            // 
            // txtJours
            // 
            this.txtJours.Location = new System.Drawing.Point(285, 87);
            this.txtJours.Name = "txtJours";
            this.txtJours.Size = new System.Drawing.Size(38, 22);
            this.txtJours.TabIndex = 23;
            // 
            // txtMois
            // 
            this.txtMois.Location = new System.Drawing.Point(224, 87);
            this.txtMois.Name = "txtMois";
            this.txtMois.Size = new System.Drawing.Size(38, 22);
            this.txtMois.TabIndex = 22;
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(149, 118);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(174, 22);
            this.txtAdresse.TabIndex = 21;
            // 
            // txtAnnee
            // 
            this.txtAnnee.Location = new System.Drawing.Point(149, 87);
            this.txtAnnee.Name = "txtAnnee";
            this.txtAnnee.Size = new System.Drawing.Size(52, 22);
            this.txtAnnee.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Adresse :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Date de naissance :";
            // 
            // txtCour
            // 
            this.txtCour.Location = new System.Drawing.Point(149, 177);
            this.txtCour.Name = "txtCour";
            this.txtCour.Size = new System.Drawing.Size(174, 22);
            this.txtCour.TabIndex = 17;
            // 
            // txtTeleResid
            // 
            this.txtTeleResid.Location = new System.Drawing.Point(149, 147);
            this.txtTeleResid.Name = "txtTeleResid";
            this.txtTeleResid.Size = new System.Drawing.Size(174, 22);
            this.txtTeleResid.TabIndex = 16;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(149, 57);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(174, 22);
            this.txtPrenom.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Courriel :";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(149, 29);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(174, 22);
            this.txtNom.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nom :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Télé Résidence :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Prénom :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstEquipe);
            this.groupBox2.Location = new System.Drawing.Point(12, 312);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(358, 53);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Équipe";
            // 
            // lstEquipe
            // 
            this.lstEquipe.FormattingEnabled = true;
            this.lstEquipe.Location = new System.Drawing.Point(149, 18);
            this.lstEquipe.Name = "lstEquipe";
            this.lstEquipe.Size = new System.Drawing.Size(121, 24);
            this.lstEquipe.TabIndex = 0;
            // 
            // btnCreerEquipe
            // 
            this.btnCreerEquipe.Enabled = false;
            this.btnCreerEquipe.Location = new System.Drawing.Point(195, 398);
            this.btnCreerEquipe.Name = "btnCreerEquipe";
            this.btnCreerEquipe.Size = new System.Drawing.Size(134, 38);
            this.btnCreerEquipe.TabIndex = 14;
            this.btnCreerEquipe.Text = "Créer Équipe";
            this.btnCreerEquipe.UseVisualStyleBackColor = true;
            this.btnCreerEquipe.Click += new System.EventHandler(this.btnCreerEquipe_Click);
            // 
            // Employes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(382, 478);
            this.Controls.Add(this.btnCreerEquipe);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCreerEmploye);
            this.Name = "Employes";
            this.Text = "Employes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Employes_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreerEmploye;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCour;
        private System.Windows.Forms.TextBox txtTeleResid;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCreerEquipe;
        private System.Windows.Forms.TextBox txtJours;
        private System.Windows.Forms.TextBox txtMois;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.TextBox txtAnnee;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox lstEquipe;
        private System.Windows.Forms.ComboBox lstCategories;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMatricule;
        private System.Windows.Forms.TextBox txtTelePoste;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}