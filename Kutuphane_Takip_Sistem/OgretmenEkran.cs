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
    public partial class OgretmenEkran : Form
    {
        private void OgretmenEkran_FormClosing(object sender, FormClosingEventArgs e)
        {
            Veritabani.Kaydet();
            Application.Exit();
        }
        public OgretmenEkran()
        {
            InitializeComponent();
            listView1.View = View.Details;
            listView2.View = View.Details;
            this.Load += OgretmenEkran_Load;
        }
        private void OgretmenEkran_Load(object sender, EventArgs e)
        {
            listView2.Items.Clear();


            foreach (var kitap in Veritabani.KitapListesi)
            {
                ListViewItem item = new ListViewItem(kitap.ISBN);
                item.SubItems.Add(kitap.Ad);
                item.SubItems.Add(kitap.Yazar);
                item.SubItems.Add(kitap.SayfaSayisi.ToString());
                item.SubItems.Add(kitap.Durum ? "Müsait" : "Alınmış");

                listView2.Items.Add(item);
            }

            listView1.Items.Clear();


            foreach (var ogrenci in Veritabani.OgrenciListesi)
            {
                ListViewItem item = new ListViewItem(ogrenci.Numara);
                item.SubItems.Add(ogrenci.Ad);
                item.SubItems.Add(ogrenci.Soyad);
                item.SubItems.Add(ogrenci.OduncAlinanKitaplar.Count.ToString());

                listView1.Items.Add(item);
            }
        }
        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KitapEkle kitapEkle = new KitapEkle();
            kitapEkle.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OgretmenEkran_Load(null, null);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                string secilenNo = listView1.SelectedItems[0].SubItems[0].Text;

                Ogrenci ogrenci = Veritabani.OgrenciListesi
                    .FirstOrDefault(o => o.Numara == secilenNo);

                if (ogrenci == null)
                {
                    MessageBox.Show("Öğrenci bulunamadı.");
                    return;
                }

                if (ogrenci.OduncAlinanKitaplar.Count == 0)
                {
                    MessageBox.Show("Bu öğrenci henüz hiç kitap ödünç almadı.");
                }
                else
                {
                    StringBuilder sb = new StringBuilder();

                    foreach (var kitap in ogrenci.OduncAlinanKitaplar)
                    {
                        sb.AppendLine($"{kitap.Ad} - {kitap.Yazar}");
                    }

                    MessageBox.Show(sb.ToString(), "Ödünç Alınan Kitaplar");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count == 0)
            {
                MessageBox.Show("Lütfen silmek istediğiniz kitabı seçin.");
                return;
            }

            string secilenIsbn = listView2.SelectedItems[0].SubItems[0].Text;

            var kitap = Veritabani.KitapListesi.FirstOrDefault(k => k.ISBN == secilenIsbn);

            if (kitap != null)
            {
                DialogResult result = MessageBox.Show($"'{kitap.Ad}' kitabını silmek istediğinize emin misiniz?",
                    "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Veritabani.KitapListesi.Remove(kitap);

                    Veritabani.Kaydet();

                    OgretmenEkran_Load(null, null);

                    MessageBox.Show("Kitap başarıyla silindi.");
                }
            }
        }
    }
}
