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
            this.btnCreerOS = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picValid4 = new System.Windows.Forms.PictureBox();
            this.picError4 = new System.Windows.Forms.PictureBox();
            this.picValid3 = new System.Windows.Forms.PictureBox();
            this.picError3 = new System.Windows.Forms.PictureBox();
            this.txtVersion = new System.Windows.Forms.TextBox();
            this.txtEdition = new System.Windows.Forms.TextBox();
            this.picValid1 = new System.Windows.Forms.PictureBox();
            this.picError1 = new System.Windows.Forms.PictureBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picValid4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picError4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picValid3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picError3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picValid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picError1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreerOS
            // 
            this.btnCreerOS.Location = new System.Drawing.Point(111, 150);
            this.btnCreerOS.Name = "btnCreerOS";
            this.btnCreerOS.Size = new System.Drawing.Size(134, 38);
            this.btnCreerOS.TabIndex = 4;
            this.btnCreerOS.Text = "Créer OS";
            this.btnCreerOS.UseVisualStyleBackColor = true;
            this.btnCreerOS.Click += new System.EventHandler(this.button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picValid4);
            this.groupBox1.Controls.Add(this.picError4);
            this.groupBox1.Controls.Add(this.picValid3);
            this.groupBox1.Controls.Add(this.picError3);
            this.groupBox1.Controls.Add(this.txtVersion);
            this.groupBox1.Controls.Add(this.txtEdition);
            this.groupBox1.Controls.Add(this.picValid1);
            this.groupBox1.Controls.Add(this.picError1);
            this.groupBox1.Controls.Add(this.txtNom);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 118);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Système d\'Exploitation";
            // 
            // picValid4
            // 
            this.picValid4.Image = global::Projet_Texcel.Properties.Resources.images__1_;
            this.picValid4.Location = new System.Drawing.Point(299, 79);
            this.picValid4.Name = "picValid4";
            this.picValid4.Size = new System.Drawing.Size(20, 21);
            this.picValid4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picValid4.TabIndex = 22;
            this.picValid4.TabStop = false;
            this.picValid4.Visible = false;
            // 
            // picError4
            // 
            this.picError4.Image = ((System.Drawing.Image)(resources.GetObject("picError4.Image")));
            this.picError4.Location = new System.Drawing.Point(299, 79);
            this.picError4.Name = "picError4";
            this.picError4.Size = new System.Drawing.Size(20, 21);
            this.picError4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picError4.TabIndex = 21;
            this.picError4.TabStop = false;
            this.picError4.Visible = false;
            // 
            // picValid3
            // 
            this.picValid3.Image = global::Projet_Texcel.Properties.Resources.images__1_;
            this.picValid3.Location = new System.Drawing.Point(298, 53);
            this.picValid3.Name = "picValid3";
            this.picValid3.Size = new System.Drawing.Size(20, 21);
            this.picValid3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picValid3.TabIndex = 20;
            this.picValid3.TabStop = false;
            this.picValid3.Visible = false;
            // 
            // picError3
            // 
            this.picError3.Image = ((System.Drawing.Image)(resources.GetObject("picError3.Image")));
            this.picError3.Location = new System.Drawing.Point(298, 53);
            this.picError3.Name = "picError3";
            this.picError3.Size = new System.Drawing.Size(20, 21);
            this.picError3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picError3.TabIndex = 19;
            this.picError3.TabStop = false;
            this.picError3.Visible = false;
            // 
            // txtVersion
            // 
            this.txtVersion.Location = new System.Drawing.Point(115, 79);
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.Size = new System.Drawing.Size(178, 22);
            this.txtVersion.TabIndex = 3;
            this.txtVersion.Tag = "4";
            this.txtVersion.Text = "###-###-###";
            this.txtVersion.TextChanged += new System.EventHandler(this.TextBox_Leave);
            // 
            // txtEdition
            // 
            this.txtEdition.Location = new System.Drawing.Point(115, 52);
            this.txtEdition.Name = "txtEdition";
            this.txtEdition.Size = new System.Drawing.Size(178, 22);
            this.txtEdition.TabIndex = 2;
            this.txtEdition.Tag = "3";
            this.txtEdition.Leave += new System.EventHandler(this.TextBox_Leave);
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
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(115, 26);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(178, 22);
            this.txtNom.TabIndex = 1;
            this.txtNom.Tag = "1";
            this.txtNom.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Version :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Edition :";
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
            // OS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(370, 204);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCreerOS);
            this.Name = "OS";
            this.Text = "OS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OS_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picValid4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picError4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picValid3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picError3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picValid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picError1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreerOS;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picValid1;
        private System.Windows.Forms.PictureBox picError1;
        private System.Windows.Forms.PictureBox picValid4;
        private System.Windows.Forms.PictureBox picError4;
        private System.Windows.Forms.PictureBox picValid3;
        private System.Windows.Forms.PictureBox picError3;
        private System.Windows.Forms.TextBox txtVersion;
        private System.Windows.Forms.TextBox txtEdition;
    }
}