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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string girilenNo = txtGirilenNoOgr.Text;
            string girilenSifre = txtGirilenSifreOgr.Text;

            var ogretmen = Veritabani.OgretmenListesi
                    .FirstOrDefault(o => o.Numara == girilenNo && o.Sifre == girilenSifre);

            if (ogretmen != null)
            {
                MessageBox.Show($"Hoş geldin {ogretmen.Ad}!");
                OgretmenEkran ogretmenEkran = new OgretmenEkran();
                ogretmenEkran.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Numara veya şifre hatalı!", "Giriş Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
