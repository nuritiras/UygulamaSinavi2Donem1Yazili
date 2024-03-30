namespace UygulamaSinavi2Donem1Yazili
{
    partial class FormGiris
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
            this.groupBoxGiris = new System.Windows.Forms.GroupBox();
            this.labelDurum = new System.Windows.Forms.Label();
            this.numericUpDownOkulNo = new System.Windows.Forms.NumericUpDown();
            this.buttonKayit = new System.Windows.Forms.Button();
            this.labelSinifi = new System.Windows.Forms.Label();
            this.buttonGiris = new System.Windows.Forms.Button();
            this.labelAdiSoyadi = new System.Windows.Forms.Label();
            this.labelOkulNo = new System.Windows.Forms.Label();
            this.textBoxSinifi = new System.Windows.Forms.TextBox();
            this.textBoxAdiSoyadi = new System.Windows.Forms.TextBox();
            this.groupBoxGiris.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOkulNo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxGiris
            // 
            this.groupBoxGiris.Controls.Add(this.labelDurum);
            this.groupBoxGiris.Controls.Add(this.numericUpDownOkulNo);
            this.groupBoxGiris.Controls.Add(this.buttonKayit);
            this.groupBoxGiris.Controls.Add(this.labelSinifi);
            this.groupBoxGiris.Controls.Add(this.buttonGiris);
            this.groupBoxGiris.Controls.Add(this.labelAdiSoyadi);
            this.groupBoxGiris.Controls.Add(this.labelOkulNo);
            this.groupBoxGiris.Controls.Add(this.textBoxSinifi);
            this.groupBoxGiris.Controls.Add(this.textBoxAdiSoyadi);
            this.groupBoxGiris.Location = new System.Drawing.Point(21, 12);
            this.groupBoxGiris.Name = "groupBoxGiris";
            this.groupBoxGiris.Size = new System.Drawing.Size(238, 236);
            this.groupBoxGiris.TabIndex = 0;
            this.groupBoxGiris.TabStop = false;
            this.groupBoxGiris.Text = "Öğrenci Bilgileri";
            // 
            // labelDurum
            // 
            this.labelDurum.AutoSize = true;
            this.labelDurum.Location = new System.Drawing.Point(76, 149);
            this.labelDurum.Name = "labelDurum";
            this.labelDurum.Size = new System.Drawing.Size(0, 13);
            this.labelDurum.TabIndex = 4;
            // 
            // numericUpDownOkulNo
            // 
            this.numericUpDownOkulNo.Location = new System.Drawing.Point(79, 34);
            this.numericUpDownOkulNo.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownOkulNo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownOkulNo.Name = "numericUpDownOkulNo";
            this.numericUpDownOkulNo.Size = new System.Drawing.Size(138, 20);
            this.numericUpDownOkulNo.TabIndex = 0;
            this.numericUpDownOkulNo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonKayit
            // 
            this.buttonKayit.Location = new System.Drawing.Point(124, 177);
            this.buttonKayit.Name = "buttonKayit";
            this.buttonKayit.Size = new System.Drawing.Size(93, 23);
            this.buttonKayit.TabIndex = 4;
            this.buttonKayit.Text = "Öğrenci Kayıt";
            this.buttonKayit.UseVisualStyleBackColor = true;
            this.buttonKayit.Click += new System.EventHandler(this.buttonKayit_Click);
            // 
            // labelSinifi
            // 
            this.labelSinifi.AutoSize = true;
            this.labelSinifi.Location = new System.Drawing.Point(41, 114);
            this.labelSinifi.Name = "labelSinifi";
            this.labelSinifi.Size = new System.Drawing.Size(32, 13);
            this.labelSinifi.TabIndex = 1;
            this.labelSinifi.Text = "Sınıfı:";
            // 
            // buttonGiris
            // 
            this.buttonGiris.Location = new System.Drawing.Point(27, 177);
            this.buttonGiris.Name = "buttonGiris";
            this.buttonGiris.Size = new System.Drawing.Size(75, 23);
            this.buttonGiris.TabIndex = 3;
            this.buttonGiris.Text = "Giriş";
            this.buttonGiris.UseVisualStyleBackColor = true;
            this.buttonGiris.Click += new System.EventHandler(this.buttonGiris_Click);
            // 
            // labelAdiSoyadi
            // 
            this.labelAdiSoyadi.AutoSize = true;
            this.labelAdiSoyadi.Location = new System.Drawing.Point(13, 74);
            this.labelAdiSoyadi.Name = "labelAdiSoyadi";
            this.labelAdiSoyadi.Size = new System.Drawing.Size(60, 13);
            this.labelAdiSoyadi.TabIndex = 1;
            this.labelAdiSoyadi.Text = "Adı Soyadı:";
            // 
            // labelOkulNo
            // 
            this.labelOkulNo.AutoSize = true;
            this.labelOkulNo.Location = new System.Drawing.Point(24, 37);
            this.labelOkulNo.Name = "labelOkulNo";
            this.labelOkulNo.Size = new System.Drawing.Size(49, 13);
            this.labelOkulNo.TabIndex = 1;
            this.labelOkulNo.Text = "Okul No:";
            // 
            // textBoxSinifi
            // 
            this.textBoxSinifi.Location = new System.Drawing.Point(79, 111);
            this.textBoxSinifi.Name = "textBoxSinifi";
            this.textBoxSinifi.Size = new System.Drawing.Size(138, 20);
            this.textBoxSinifi.TabIndex = 2;
            // 
            // textBoxAdiSoyadi
            // 
            this.textBoxAdiSoyadi.Location = new System.Drawing.Point(79, 71);
            this.textBoxAdiSoyadi.Name = "textBoxAdiSoyadi";
            this.textBoxAdiSoyadi.Size = new System.Drawing.Size(138, 20);
            this.textBoxAdiSoyadi.TabIndex = 1;
            // 
            // FormGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 260);
            this.Controls.Add(this.groupBoxGiris);
            this.Name = "FormGiris";
            this.Text = "Giriş Ekranı";
            this.groupBoxGiris.ResumeLayout(false);
            this.groupBoxGiris.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOkulNo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxGiris;
        private System.Windows.Forms.Button buttonGiris;
        private System.Windows.Forms.Button buttonKayit;
        private System.Windows.Forms.Label labelSinifi;
        private System.Windows.Forms.Label labelAdiSoyadi;
        private System.Windows.Forms.Label labelOkulNo;
        private System.Windows.Forms.TextBox textBoxSinifi;
        private System.Windows.Forms.TextBox textBoxAdiSoyadi;
        private System.Windows.Forms.NumericUpDown numericUpDownOkulNo;
        private System.Windows.Forms.Label labelDurum;
    }
}

