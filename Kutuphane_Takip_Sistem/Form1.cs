﻿using System;
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
    public partial class Form1 : Form
    {
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Veritabani.Kaydet();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string girilenNo = txtGirilenNo.Text;
            string girilenSifre = txtGirilenSifre.Text;

            var ogrenci = Veritabani.OgrenciListesi
                    .FirstOrDefault(o => o.Numara == girilenNo && o.Sifre == girilenSifre);

            if (ogrenci != null)
            {
                MessageBox.Show($"Hoş geldin {ogrenci.Ad}!");
                OgrenciEkran ogrenciEkran = new OgrenciEkran(ogrenci);
                ogrenciEkran.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Numara veya şifre hatalı!", "Giriş Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
