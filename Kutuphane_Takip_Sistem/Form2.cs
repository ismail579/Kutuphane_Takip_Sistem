using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane_Takip_Sistem
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Ogrenci ogrenci = new Ogrenci
            {
                Ad = txtAd.Text,
                Soyad = txtSoyad.Text,
                Numara = txtNo.Text,
                Sifre = txtSifre.Text
            };

            Veritabani.OgrenciListesi.Add(ogrenci);
            MessageBox.Show("Kayıt başarılı!");

            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}
