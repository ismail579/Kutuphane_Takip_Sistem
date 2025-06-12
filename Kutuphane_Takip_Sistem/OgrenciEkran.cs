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
    public partial class OgrenciEkran : Form
    {
        private void OgrenciEkran_FormClosing(object sender, FormClosingEventArgs e)
        {
            Veritabani.Kaydet();
            Application.Exit();
        }

        private void OgrenciEkran_Load(object sender, EventArgs e)
        {
            listView1.Items.Clear();


            foreach (var kitap in Veritabani.KitapListesi)
            {
                ListViewItem item = new ListViewItem(kitap.ISBN);
                item.SubItems.Add(kitap.Ad);
                item.SubItems.Add(kitap.Yazar);
                item.SubItems.Add(kitap.SayfaSayisi.ToString());
                item.SubItems.Add(kitap.Durum ? "Müsait" : "Alınmış");

                listView1.Items.Add(item);
            }
        }

        private Ogrenci aktifOgrenci;
        public OgrenciEkran(Ogrenci ogrenci)
        {
            InitializeComponent();
            aktifOgrenci = ogrenci;
            listView1.View = View.Details;
            this.Load += OgrenciEkran_Load;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem secilen = listView1.SelectedItems[0];

                string isbn = secilen.SubItems[0].Text;
                string kitapAdi = secilen.SubItems[1].Text;
                string yazar = secilen.SubItems[2].Text;

                MessageBox.Show($"Seçilen Kitap:\n{kitapAdi} - {yazar}\nISBN: {isbn}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Lütfen bir kitap seçin.");
                return;
            }

            string secilenIsbn = listView1.SelectedItems[0].SubItems[0].Text;

            var kitap = Veritabani.KitapListesi.FirstOrDefault(k => k.ISBN == secilenIsbn);

            if (kitap != null && kitap.Durum)
            {
                kitap.Durum = false;
                aktifOgrenci.OduncAlinanKitaplar.Add(kitap);
                MessageBox.Show($"'{kitap.Ad}' kitabı ödünç alındı.");
                OgrenciEkran_Load(null, null);
            }
            else
            {
                MessageBox.Show("Kitap zaten ödünçte veya bulunamadı.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (aktifOgrenci.OduncAlinanKitaplar.Count == 0)
            {
                MessageBox.Show("Henüz kitap ödünç alınmamış.");
                return;
            }

            StringBuilder sb = new StringBuilder();
            foreach (var kitap in aktifOgrenci.OduncAlinanKitaplar)
            {
                sb.AppendLine($"{kitap.Ad} - {kitap.Yazar}");
            }

            MessageBox.Show($"Ödünç Alınan Kitaplar:\n{sb}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Lütfen iade etmek istediğiniz kitabı seçin.");
                return;
            }

            string secilenIsbn = listView1.SelectedItems[0].SubItems[0].Text;

            var kitap = Veritabani.KitapListesi.FirstOrDefault(k => k.ISBN == secilenIsbn);

            var ogrenciKitap = aktifOgrenci.OduncAlinanKitaplar.FirstOrDefault(k => k.ISBN == secilenIsbn);

            if (kitap != null && ogrenciKitap != null)
            {
                kitap.Durum = true;
                aktifOgrenci.OduncAlinanKitaplar.Remove(ogrenciKitap);

                MessageBox.Show($"'{kitap.Ad}' kitabı başarıyla iade edildi.");
                OgrenciEkran_Load(null, null);
            }
            else
            {
                MessageBox.Show("Bu kitabı siz ödünç almadığınız için iade edemezsiniz.");
            }
        }
    }
}
