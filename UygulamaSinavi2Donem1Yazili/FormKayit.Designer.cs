namespace UygulamaSinavi2Donem1Yazili
{
    partial class FormKayit
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
            this.groupBoxKayit = new System.Windows.Forms.GroupBox();
            this.numericOkulNo = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxDali = new System.Windows.Forms.TextBox();
            this.txtBoxAlani = new System.Windows.Forms.TextBox();
            this.btnKayit = new System.Windows.Forms.Button();
            this.lblSinifi = new System.Windows.Forms.Label();
            this.btnKapat = new System.Windows.Forms.Button();
            this.lblAdiSoyadi = new System.Windows.Forms.Label();
            this.lblOkulNo = new System.Windows.Forms.Label();
            this.txtBoxSinifi = new System.Windows.Forms.TextBox();
            this.txtBoxAdiSoyadi = new System.Windows.Forms.TextBox();
            this.labelSonuc = new System.Windows.Forms.Label();
            this.groupBoxKayit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericOkulNo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxKayit
            // 
            this.groupBoxKayit.Controls.Add(this.labelSonuc);
            this.groupBoxKayit.Controls.Add(this.numericOkulNo);
            this.groupBoxKayit.Controls.Add(this.label2);
            this.groupBoxKayit.Controls.Add(this.label3);
            this.groupBoxKayit.Controls.Add(this.txtBoxDali);
            this.groupBoxKayit.Controls.Add(this.txtBoxAlani);
            this.groupBoxKayit.Controls.Add(this.btnKayit);
            this.groupBoxKayit.Controls.Add(this.lblSinifi);
            this.groupBoxKayit.Controls.Add(this.btnKapat);
            this.groupBoxKayit.Controls.Add(this.lblAdiSoyadi);
            this.groupBoxKayit.Controls.Add(this.lblOkulNo);
            this.groupBoxKayit.Controls.Add(this.txtBoxSinifi);
            this.groupBoxKayit.Controls.Add(this.txtBoxAdiSoyadi);
            this.groupBoxKayit.Location = new System.Drawing.Point(22, 27);
            this.groupBoxKayit.Name = "groupBoxKayit";
            this.groupBoxKayit.Size = new System.Drawing.Size(273, 286);
            this.groupBoxKayit.TabIndex = 2;
            this.groupBoxKayit.TabStop = false;
            this.groupBoxKayit.Text = "Öğrenci Bilgileri";
            // 
            // numericOkulNo
            // 
            this.numericOkulNo.Location = new System.Drawing.Point(88, 34);
            this.numericOkulNo.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericOkulNo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericOkulNo.Name = "numericOkulNo";
            this.numericOkulNo.Size = new System.Drawing.Size(164, 20);
            this.numericOkulNo.TabIndex = 0;
            this.numericOkulNo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Dalı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Alanı:";
            // 
            // txtBoxDali
            // 
            this.txtBoxDali.Location = new System.Drawing.Point(88, 188);
            this.txtBoxDali.Name = "txtBoxDali";
            this.txtBoxDali.Size = new System.Drawing.Size(164, 20);
            this.txtBoxDali.TabIndex = 4;
            // 
            // txtBoxAlani
            // 
            this.txtBoxAlani.Location = new System.Drawing.Point(88, 151);
            this.txtBoxAlani.Name = "txtBoxAlani";
            this.txtBoxAlani.Size = new System.Drawing.Size(164, 20);
            this.txtBoxAlani.TabIndex = 3;
            // 
            // btnKayit
            // 
            this.btnKayit.Location = new System.Drawing.Point(142, 247);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(110, 23);
            this.btnKayit.TabIndex = 6;
            this.btnKayit.Text = "Öğrenciyi Kaydet";
            this.btnKayit.UseVisualStyleBackColor = true;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            // 
            // lblSinifi
            // 
            this.lblSinifi.AutoSize = true;
            this.lblSinifi.Location = new System.Drawing.Point(41, 114);
            this.lblSinifi.Name = "lblSinifi";
            this.lblSinifi.Size = new System.Drawing.Size(32, 13);
            this.lblSinifi.TabIndex = 1;
            this.lblSinifi.Text = "Sınıfı:";
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(73, 247);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(63, 23);
            this.btnKapat.TabIndex = 5;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // lblAdiSoyadi
            // 
            this.lblAdiSoyadi.AutoSize = true;
            this.lblAdiSoyadi.Location = new System.Drawing.Point(13, 74);
            this.lblAdiSoyadi.Name = "lblAdiSoyadi";
            this.lblAdiSoyadi.Size = new System.Drawing.Size(60, 13);
            this.lblAdiSoyadi.TabIndex = 1;
            this.lblAdiSoyadi.Text = "Adı Soyadı:";
            // 
            // lblOkulNo
            // 
            this.lblOkulNo.AutoSize = true;
            this.lblOkulNo.Location = new System.Drawing.Point(24, 37);
            this.lblOkulNo.Name = "lblOkulNo";
            this.lblOkulNo.Size = new System.Drawing.Size(49, 13);
            this.lblOkulNo.TabIndex = 1;
            this.lblOkulNo.Text = "Okul No:";
            // 
            // txtBoxSinifi
            // 
            this.txtBoxSinifi.Location = new System.Drawing.Point(88, 111);
            this.txtBoxSinifi.Name = "txtBoxSinifi";
            this.txtBoxSinifi.Size = new System.Drawing.Size(164, 20);
            this.txtBoxSinifi.TabIndex = 2;
            // 
            // txtBoxAdiSoyadi
            // 
            this.txtBoxAdiSoyadi.Location = new System.Drawing.Point(88, 71);
            this.txtBoxAdiSoyadi.Name = "txtBoxAdiSoyadi";
            this.txtBoxAdiSoyadi.Size = new System.Drawing.Size(164, 20);
            this.txtBoxAdiSoyadi.TabIndex = 1;
            // 
            // labelSonuc
            // 
            this.labelSonuc.AutoSize = true;
            this.labelSonuc.ForeColor = System.Drawing.Color.Red;
            this.labelSonuc.Location = new System.Drawing.Point(90, 223);
            this.labelSonuc.Name = "labelSonuc";
            this.labelSonuc.Size = new System.Drawing.Size(0, 13);
            this.labelSonuc.TabIndex = 9;
            // 
            // FormKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 325);
            this.ControlBox = false;
            this.Controls.Add(this.groupBoxKayit);
            this.MaximizeBox = false;
            this.Name = "FormKayit";
            this.Text = "Kayıt Ekranı";
            this.Load += new System.EventHandler(this.FormKayit_Load);
            this.groupBoxKayit.ResumeLayout(false);
            this.groupBoxKayit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericOkulNo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxKayit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxDali;
        private System.Windows.Forms.TextBox txtBoxAlani;
        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.Label lblSinifi;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Label lblAdiSoyadi;
        private System.Windows.Forms.Label lblOkulNo;
        private System.Windows.Forms.TextBox txtBoxSinifi;
        private System.Windows.Forms.TextBox txtBoxAdiSoyadi;
        private System.Windows.Forms.NumericUpDown numericOkulNo;
        private System.Windows.Forms.Label labelSonuc;
    }
}