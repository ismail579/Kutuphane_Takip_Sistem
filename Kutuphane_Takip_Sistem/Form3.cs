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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ogretmen ogretmen = new Ogretmen
            {
                Ad = txtOgrAd.Text,
                Soyad = txtOgrSoyad.Text,
                Numara = txtOgrNo.Text,
                Sifre = txtOgrSifre.Text
            };

            Veritabani.OgretmenListesi.Add(ogretmen);
            MessageBox.Show("Kayıt başarılı!");

            Form4 f4 = new Form4();
            f4.Show();
            this.Hide();
        }
    }
}
