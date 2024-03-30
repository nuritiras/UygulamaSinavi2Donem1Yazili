namespace UygulamaSinavi2Donem1Yazili
{
    partial class FormUygulama
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
            this.tabControlOgrenci = new System.Windows.Forms.TabControl();
            this.tabPageOgrenci = new System.Windows.Forms.TabPage();
            this.labelSinifi = new System.Windows.Forms.Label();
            this.labelAdiSoyadi = new System.Windows.Forms.Label();
            this.labelOkulNo = new System.Windows.Forms.Label();
            this.txtSinifi = new System.Windows.Forms.TextBox();
            this.txtAdiSoyadi = new System.Windows.Forms.TextBox();
            this.txtOkulNo = new System.Windows.Forms.TextBox();
            this.tabPageAlan = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textDali = new System.Windows.Forms.TextBox();
            this.textAlani = new System.Windows.Forms.TextBox();
            this.dataGridViewOgrenci = new System.Windows.Forms.DataGridView();
            this.btnKapat = new System.Windows.Forms.Button();
            this.tabControlOgrenci.SuspendLayout();
            this.tabPageOgrenci.SuspendLayout();
            this.tabPageAlan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOgrenci)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlOgrenci
            // 
            this.tabControlOgrenci.Controls.Add(this.tabPageOgrenci);
            this.tabControlOgrenci.Controls.Add(this.tabPageAlan);
            this.tabControlOgrenci.Location = new System.Drawing.Point(13, 12);
            this.tabControlOgrenci.Name = "tabControlOgrenci";
            this.tabControlOgrenci.SelectedIndex = 0;
            this.tabControlOgrenci.Size = new System.Drawing.Size(378, 168);
            this.tabControlOgrenci.TabIndex = 0;
            // 
            // tabPageOgrenci
            // 
            this.tabPageOgrenci.Controls.Add(this.labelSinifi);
            this.tabPageOgrenci.Controls.Add(this.labelAdiSoyadi);
            this.tabPageOgrenci.Controls.Add(this.labelOkulNo);
            this.tabPageOgrenci.Controls.Add(this.txtSinifi);
            this.tabPageOgrenci.Controls.Add(this.txtAdiSoyadi);
            this.tabPageOgrenci.Controls.Add(this.txtOkulNo);
            this.tabPageOgrenci.Location = new System.Drawing.Point(4, 22);
            this.tabPageOgrenci.Name = "tabPageOgrenci";
            this.tabPageOgrenci.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOgrenci.Size = new System.Drawing.Size(370, 142);
            this.tabPageOgrenci.TabIndex = 0;
            this.tabPageOgrenci.Text = "Öğrenci Bilgileri";
            this.tabPageOgrenci.UseVisualStyleBackColor = true;
            // 
            // labelSinifi
            // 
            this.labelSinifi.AutoSize = true;
            this.labelSinifi.Location = new System.Drawing.Point(58, 104);
            this.labelSinifi.Name = "labelSinifi";
            this.labelSinifi.Size = new System.Drawing.Size(32, 13);
            this.labelSinifi.TabIndex = 5;
            this.labelSinifi.Text = "Sınıfı:";
            // 
            // labelAdiSoyadi
            // 
            this.labelAdiSoyadi.AutoSize = true;
            this.labelAdiSoyadi.Location = new System.Drawing.Point(30, 64);
            this.labelAdiSoyadi.Name = "labelAdiSoyadi";
            this.labelAdiSoyadi.Size = new System.Drawing.Size(60, 13);
            this.labelAdiSoyadi.TabIndex = 6;
            this.labelAdiSoyadi.Text = "Adı Soyadı:";
            // 
            // labelOkulNo
            // 
            this.labelOkulNo.AutoSize = true;
            this.labelOkulNo.Location = new System.Drawing.Point(41, 27);
            this.labelOkulNo.Name = "labelOkulNo";
            this.labelOkulNo.Size = new System.Drawing.Size(49, 13);
            this.labelOkulNo.TabIndex = 7;
            this.labelOkulNo.Text = "Okul No:";
            // 
            // txtSinifi
            // 
            this.txtSinifi.Enabled = false;
            this.txtSinifi.Location = new System.Drawing.Point(96, 101);
            this.txtSinifi.Name = "txtSinifi";
            this.txtSinifi.Size = new System.Drawing.Size(224, 20);
            this.txtSinifi.TabIndex = 2;
            // 
            // txtAdiSoyadi
            // 
            this.txtAdiSoyadi.Enabled = false;
            this.txtAdiSoyadi.Location = new System.Drawing.Point(96, 61);
            this.txtAdiSoyadi.Name = "txtAdiSoyadi";
            this.txtAdiSoyadi.Size = new System.Drawing.Size(224, 20);
            this.txtAdiSoyadi.TabIndex = 3;
            // 
            // txtOkulNo
            // 
            this.txtOkulNo.Enabled = false;
            this.txtOkulNo.Location = new System.Drawing.Point(96, 24);
            this.txtOkulNo.Name = "txtOkulNo";
            this.txtOkulNo.Size = new System.Drawing.Size(224, 20);
            this.txtOkulNo.TabIndex = 4;
            this.txtOkulNo.TextChanged += new System.EventHandler(this.txtOkulNo_TextChanged);
            // 
            // tabPageAlan
            // 
            this.tabPageAlan.Controls.Add(this.label2);
            this.tabPageAlan.Controls.Add(this.label3);
            this.tabPageAlan.Controls.Add(this.textDali);
            this.tabPageAlan.Controls.Add(this.textAlani);
            this.tabPageAlan.Location = new System.Drawing.Point(4, 22);
            this.tabPageAlan.Name = "tabPageAlan";
            this.tabPageAlan.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAlan.Size = new System.Drawing.Size(370, 142);
            this.tabPageAlan.TabIndex = 1;
            this.tabPageAlan.Text = "Alan Bilgileri";
            this.tabPageAlan.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Dalı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Alanı:";
            // 
            // textDali
            // 
            this.textDali.Enabled = false;
            this.textDali.Location = new System.Drawing.Point(73, 75);
            this.textDali.Name = "textDali";
            this.textDali.Size = new System.Drawing.Size(253, 20);
            this.textDali.TabIndex = 9;
            // 
            // textAlani
            // 
            this.textAlani.Enabled = false;
            this.textAlani.Location = new System.Drawing.Point(73, 38);
            this.textAlani.Name = "textAlani";
            this.textAlani.Size = new System.Drawing.Size(253, 20);
            this.textAlani.TabIndex = 10;
            // 
            // dataGridViewOgrenci
            // 
            this.dataGridViewOgrenci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOgrenci.Location = new System.Drawing.Point(17, 203);
            this.dataGridViewOgrenci.Name = "dataGridViewOgrenci";
            this.dataGridViewOgrenci.Size = new System.Drawing.Size(370, 194);
            this.dataGridViewOgrenci.TabIndex = 1;
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(157, 415);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(75, 23);
            this.btnKapat.TabIndex = 2;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // FormUygulama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 450);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.dataGridViewOgrenci);
            this.Controls.Add(this.tabControlOgrenci);
            this.Name = "FormUygulama";
            this.Text = "Uygulama Ekranı";
            this.Load += new System.EventHandler(this.FormUygulama_Load);
            this.tabControlOgrenci.ResumeLayout(false);
            this.tabPageOgrenci.ResumeLayout(false);
            this.tabPageOgrenci.PerformLayout();
            this.tabPageAlan.ResumeLayout(false);
            this.tabPageAlan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOgrenci)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlOgrenci;
        private System.Windows.Forms.TabPage tabPageOgrenci;
        private System.Windows.Forms.TabPage tabPageAlan;
        private System.Windows.Forms.DataGridView dataGridViewOgrenci;
        private System.Windows.Forms.Label labelSinifi;
        private System.Windows.Forms.Label labelAdiSoyadi;
        private System.Windows.Forms.Label labelOkulNo;
        private System.Windows.Forms.TextBox txtSinifi;
        private System.Windows.Forms.TextBox txtAdiSoyadi;
        private System.Windows.Forms.TextBox txtOkulNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textDali;
        private System.Windows.Forms.TextBox textAlani;
        private System.Windows.Forms.Button btnKapat;
    }
}