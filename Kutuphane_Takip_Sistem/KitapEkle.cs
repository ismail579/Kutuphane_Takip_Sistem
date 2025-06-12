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
    public partial class KitapEkle : Form
    {
        private void KitapEkle_FormClosing(object sender, FormClosingEventArgs e)
        {
            Veritabani.Kaydet();
            this.Hide();
        }
        public KitapEkle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string isbn = textBox1.Text;
            string ad = textBox2.Text; 
            string yazar = textBox3.Text;
            String sayfaSayisi = textBox4.Text;
            if (string.IsNullOrWhiteSpace(isbn) || string.IsNullOrWhiteSpace(ad) ||
                string.IsNullOrWhiteSpace(yazar) || string.IsNullOrWhiteSpace(sayfaSayisi))
            {
                    MessageBox.Show("Lütfen tüm alanları doldurunuz.");
                    return;
            }

            if (!int.TryParse(sayfaSayisi, out int sayfaSayi))
            {
                MessageBox.Show("Sayfa sayısı geçerli bir sayı olmalıdır.");
                return;
            }

            Kitap yeniKitap = new Kitap
            {
                ISBN = isbn,
                Ad = ad,
                Yazar = yazar,
                SayfaSayisi = sayfaSayi,
                Durum = true
            };

            Veritabani.KitapListesi.Add(yeniKitap);
            Veritabani.Kaydet();

            MessageBox.Show($"'{yeniKitap.Ad}' adlı kitap başarıyla eklendi!");

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }


    }
}
