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
    public partial class FormUygulama : Form
    {
        public List<Ogrenci> liste2 = new List<Ogrenci>();
        public int indexNo;
        public FormUygulama()
        {
            InitializeComponent();
        }

        private void FormUygulama_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            txtOkulNo.Text = liste2[indexNo].Numara.ToString();
            txtAdiSoyadi.Text = liste2[indexNo].AdSoyad;
            txtSinifi.Text = liste2[indexNo].Sinif;
            textAlani.Text = liste2[indexNo].Alan;
            textDali.Text = liste2[indexNo].Dal;
            dataGridViewOgrenci.DataSource = null;
            dataGridViewOgrenci.DataSource = liste2;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            FormGiris formGiris = new FormGiris();
            formGiris.Show();
            this.Close();
        }
    }
}
