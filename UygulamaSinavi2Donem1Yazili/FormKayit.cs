using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UygulamaSinavi2Donem1Yazili
{
    public partial class FormKayit : Form
    {
        static List<Ogrenci> liste = new List<Ogrenci>();
        public FormKayit()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            FormGiris formGiris = new FormGiris();
            formGiris.liste1 = liste;
            formGiris.Show();
            this.Close();
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoxAdiSoyadi.Text) ||
                string.IsNullOrEmpty(txtBoxSinifi.Text) ||
                string.IsNullOrEmpty(txtBoxAlani.Text) ||
                string.IsNullOrEmpty(txtBoxDali.Text))
            {
                labelSonuc.Text="Alanlar boş bırakılamaz.";
            }
            else
            {
                labelSonuc.Text = "";
                Ogrenci ogrenci = new Ogrenci();
                ogrenci.Numara = Convert.ToInt32(numericOkulNo.Value);
                ogrenci.AdSoyad = txtBoxAdiSoyadi.Text;
                ogrenci.Sinif = txtBoxSinifi.Text;
                ogrenci.Alan = txtBoxAlani.Text;
                ogrenci.Dal = txtBoxDali.Text;
                liste.Add(ogrenci);             
            }
        }

        private void FormKayit_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }
    }
}
