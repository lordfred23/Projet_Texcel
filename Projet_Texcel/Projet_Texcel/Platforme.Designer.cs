namespace Projet_Texcel
{
    partial class Platforme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Platforme));
            this.btnCreerOs = new System.Windows.Forms.Button();
            this.btnCreerPlat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picValid1 = new System.Windows.Forms.PictureBox();
            this.picError1 = new System.Windows.Forms.PictureBox();
            this.lstOS = new System.Windows.Forms.ComboBox();
            this.lstPlatform = new System.Windows.Forms.ComboBox();
            this.lstConfig = new System.Windows.Forms.ComboBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picValid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picError1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreerOs
            // 
            this.btnCreerOs.Location = new System.Drawing.Point(183, 220);
            this.btnCreerOs.Name = "btnCreerOs";
            this.btnCreerOs.Size = new System.Drawing.Size(134, 38);
            this.btnCreerOs.TabIndex = 2;
            this.btnCreerOs.Text = "Créer OS";
            this.btnCreerOs.UseVisualStyleBackColor = true;
            this.btnCreerOs.Click += new System.EventHandler(this.btnCreerOs_Click);
            // 
            // btnCreerPlat
            // 
            this.btnCreerPlat.Location = new System.Drawing.Point(43, 220);
            this.btnCreerPlat.Name = "btnCreerPlat";
            this.btnCreerPlat.Size = new System.Drawing.Size(134, 38);
            this.btnCreerPlat.TabIndex = 3;
            this.btnCreerPlat.Text = "Créer Platforme";
            this.btnCreerPlat.UseVisualStyleBackColor = true;
            this.btnCreerPlat.Click += new System.EventHandler(this.btnCreerPlat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picValid1);
            this.groupBox1.Controls.Add(this.picError1);
            this.groupBox1.Controls.Add(this.lstOS);
            this.groupBox1.Controls.Add(this.lstPlatform);
            this.groupBox1.Controls.Add(this.lstConfig);
            this.groupBox1.Controls.Add(this.txtNom);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 159);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Platforme";
            // 
            // picValid1
            // 
            this.picValid1.Image = global::Projet_Texcel.Properties.Resources.images__1_;
            this.picValid1.Location = new System.Drawing.Point(299, 22);
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
            this.picError1.Location = new System.Drawing.Point(299, 22);
            this.picError1.Name = "picError1";
            this.picError1.Size = new System.Drawing.Size(20, 21);
            this.picError1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picError1.TabIndex = 13;
            this.picError1.TabStop = false;
            this.picError1.Visible = false;
            // 
            // lstOS
            // 
            this.lstOS.FormattingEnabled = true;
            this.lstOS.Location = new System.Drawing.Point(153, 116);
            this.lstOS.Name = "lstOS";
            this.lstOS.Size = new System.Drawing.Size(121, 24);
            this.lstOS.TabIndex = 7;
            // 
            // lstPlatform
            // 
            this.lstPlatform.FormattingEnabled = true;
            this.lstPlatform.Location = new System.Drawing.Point(153, 84);
            this.lstPlatform.Name = "lstPlatform";
            this.lstPlatform.Size = new System.Drawing.Size(121, 24);
            this.lstPlatform.TabIndex = 6;
            // 
            // lstConfig
            // 
            this.lstConfig.Location = new System.Drawing.Point(153, 51);
            this.lstConfig.Name = "lstConfig";
            this.lstConfig.Size = new System.Drawing.Size(121, 24);
            this.lstConfig.TabIndex = 5;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(153, 22);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(140, 22);
            this.txtNom.TabIndex = 4;
            this.txtNom.Tag = "1";
            this.txtNom.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "OS :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Configuration :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Type de platforme :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom :";
            // 
            // Platforme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(358, 276);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCreerPlat);
            this.Controls.Add(this.btnCreerOs);
            this.Name = "Platforme";
            this.Text = "Platforme";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Platforme_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picValid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picError1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreerOs;
        private System.Windows.Forms.Button btnCreerPlat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox lstOS;
        private System.Windows.Forms.ComboBox lstPlatform;
        private System.Windows.Forms.ComboBox lstConfig;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox picValid1;
        private System.Windows.Forms.PictureBox picError1;
    }
}