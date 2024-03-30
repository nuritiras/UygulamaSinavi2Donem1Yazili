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
    public partial class FormGiris : Form
    {
        public List<Ogrenci> liste1 = new List<Ogrenci>();
        public FormGiris()
        {
            InitializeComponent();
        }

        private void buttonKayit_Click(object sender, EventArgs e)
        {
            FormKayit formKayit = new FormKayit();
            formKayit.Show();
            this.Hide();
        }

        private void buttonGiris_Click(object sender, EventArgs e)
        {
            bool durum = false;
            int indeks = 0;
            foreach (var ogrenci in liste1)
            {
                if (ogrenci.Numara == Convert.ToInt32(numericUpDownOkulNo.Value) &&
                   ogrenci.AdSoyad == textBoxAdiSoyadi.Text &&
                   ogrenci.Sinif == textBoxSinifi.Text)
                {
                    FormUygulama formUygulama = new FormUygulama();
                    formUygulama.liste2 = liste1;
                    formUygulama.indexNo = indeks;
                    formUygulama.Show();
                    this.Hide();
                    durum = true;
                    labelDurum.Text = "";
                    break;
                }
                indeks++;
            }
            if (!durum)
            {
                labelDurum.Text = "Bilgiler uyuşmuyor!";
                labelDurum.ForeColor = Color.Red;
            }
        }
    }
}
