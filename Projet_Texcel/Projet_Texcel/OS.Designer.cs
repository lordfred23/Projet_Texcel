namespace Projet_Texcel
{
    partial class OS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OS));
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstVersion = new System.Windows.Forms.ComboBox();
            this.lstEdition = new System.Windows.Forms.ComboBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picValid1 = new System.Windows.Forms.PictureBox();
            this.picError1 = new System.Windows.Forms.PictureBox();
            this.picValid2 = new System.Windows.Forms.PictureBox();
            this.picError2 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picValid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picError1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picValid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picError2)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(114, 204);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 38);
            this.button2.TabIndex = 1;
            this.button2.Text = "Créer OS";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picValid2);
            this.groupBox1.Controls.Add(this.picError2);
            this.groupBox1.Controls.Add(this.picValid1);
            this.groupBox1.Controls.Add(this.picError1);
            this.groupBox1.Controls.Add(this.lstVersion);
            this.groupBox1.Controls.Add(this.lstEdition);
            this.groupBox1.Controls.Add(this.txtCode);
            this.groupBox1.Controls.Add(this.txtNom);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 152);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Système d\'Exploitation";
            // 
            // lstVersion
            // 
            this.lstVersion.FormattingEnabled = true;
            this.lstVersion.Location = new System.Drawing.Point(115, 108);
            this.lstVersion.Name = "lstVersion";
            this.lstVersion.Size = new System.Drawing.Size(121, 24);
            this.lstVersion.TabIndex = 10;
            // 
            // lstEdition
            // 
            this.lstEdition.FormattingEnabled = true;
            this.lstEdition.Location = new System.Drawing.Point(115, 79);
            this.lstEdition.Name = "lstEdition";
            this.lstEdition.Size = new System.Drawing.Size(121, 24);
            this.lstEdition.TabIndex = 9;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(115, 53);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(178, 22);
            this.txtCode.TabIndex = 8;
            this.txtCode.Tag = "2";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(115, 26);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(178, 22);
            this.txtNom.TabIndex = 7;
            this.txtNom.Tag = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Version :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Edition :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Code :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nom :";
            // 
            // picValid1
            // 
            this.picValid1.Image = global::Projet_Texcel.Properties.Resources.images__1_;
            this.picValid1.Location = new System.Drawing.Point(299, 26);
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
            this.picError1.Location = new System.Drawing.Point(299, 26);
            this.picError1.Name = "picError1";
            this.picError1.Size = new System.Drawing.Size(20, 21);
            this.picError1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picError1.TabIndex = 13;
            this.picError1.TabStop = false;
            this.picError1.Visible = false;
            // 
            // picValid2
            // 
            this.picValid2.Image = global::Projet_Texcel.Properties.Resources.images__1_;
            this.picValid2.Location = new System.Drawing.Point(298, 53);
            this.picValid2.Name = "picValid2";
            this.picValid2.Size = new System.Drawing.Size(20, 21);
            this.picValid2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picValid2.TabIndex = 16;
            this.picValid2.TabStop = false;
            this.picValid2.Visible = false;
            // 
            // picError2
            // 
            this.picError2.Image = ((System.Drawing.Image)(resources.GetObject("picError2.Image")));
            this.picError2.Location = new System.Drawing.Point(298, 53);
            this.picError2.Name = "picError2";
            this.picError2.Size = new System.Drawing.Size(20, 21);
            this.picError2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picError2.TabIndex = 15;
            this.picError2.TabStop = false;
            this.picError2.Visible = false;
            // 
            // OS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(370, 269);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Name = "OS";
            this.Text = "OS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OS_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picValid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picError1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picValid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picError2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox lstVersion;
        private System.Windows.Forms.ComboBox lstEdition;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picValid2;
        private System.Windows.Forms.PictureBox picError2;
        private System.Windows.Forms.PictureBox picValid1;
        private System.Windows.Forms.PictureBox picError1;
    }
}