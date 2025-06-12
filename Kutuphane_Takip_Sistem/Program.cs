using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane_Takip_Sistem
{

    public class Ogrenci
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Numara { get; set; }
        public string Sifre { get; set; }
        public List<Kitap> OduncAlinanKitaplar { get; set; } = new List<Kitap>();
    }

    public class Ogretmen
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Numara { get; set; }
        public string Sifre { get; set; }
    }

    public class Kitap
    {
        public string Ad { get; set; }
        public string Yazar { get; set; }
        public string ISBN { get; set; }
        public int SayfaSayisi { get; set; }
        public bool Durum { get; set; }
    }
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Veritabani.Yukle();
            Application.Run(new LandingPage());

            Veritabani.Kaydet();

        }
    }
}
