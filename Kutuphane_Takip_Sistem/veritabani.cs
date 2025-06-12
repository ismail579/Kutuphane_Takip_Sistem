using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace Kutuphane_Takip_Sistem
{
    public static class Veritabani
    {
        public static List<Ogrenci> OgrenciListesi = new List<Ogrenci>();
        public static List<Ogretmen> OgretmenListesi = new List<Ogretmen>();
        public static List<Kitap> KitapListesi = new List<Kitap>();

        private static string kitapDosya = "kitaplar.json";
        private static string ogrenciDosya = "ogrenciler.json";
        private static string ogretmenDosya = "ogretmenler.json";

        public static void Yukle()
        {
            if (!File.Exists(kitapDosya))
            {
                KitapListesi = new List<Kitap>
                {
                    new Kitap { Ad = "Simyacı", Yazar = "Paulo Coelho", ISBN = "9780062315007", SayfaSayisi = 208, Durum = true },
                    new Kitap { Ad = "1984", Yazar = "George Orwell", ISBN = "9780451524935", SayfaSayisi = 328, Durum = true },
                    new Kitap { Ad = "Kürk Mantolu Madonna", Yazar = "Sabahattin Ali", ISBN = "9789753638029", SayfaSayisi = 160, Durum = true },
                    new Kitap { Ad = "Sefiller", Yazar = "Victor Hugo", ISBN = "9786053754974", SayfaSayisi = 1232, Durum = true },
                    new Kitap { Ad = "Beyaz Zambaklar Ülkesinde", Yazar = "Grigory Petrov", ISBN = "9786057635262", SayfaSayisi = 136, Durum = true },
                    new Kitap { Ad = "Suç ve Ceza", Yazar = "Fyodor Dostoyevski", ISBN = "9786257059920", SayfaSayisi = 688, Durum = true },
                    new Kitap { Ad = "Tutunamayanlar", Yazar = "Oğuz Atay", ISBN = "9789754700114", SayfaSayisi = 724, Durum = true },
                    new Kitap { Ad = "Harry Potter ve Felsefe Taşı", Yazar = "J.K. Rowling", ISBN = "9789750802942", SayfaSayisi = 312, Durum = true },
                    new Kitap { Ad = "Şeker Portakalı", Yazar = "José Mauro de Vasconcelos", ISBN = "9789755104034", SayfaSayisi = 200, Durum = true },
                    new Kitap { Ad = "Hayvan Çiftliği", Yazar = "George Orwell", ISBN = "9789750718533", SayfaSayisi = 152, Durum = true },
                    new Kitap { Ad = "Yeraltından Notlar", Yazar = "Fyodor Dostoyevski", ISBN = "9786053609960", SayfaSayisi = 160, Durum = true },
                    new Kitap { Ad = "Serenad", Yazar = "Zülfü Livaneli", ISBN = "9786051111021", SayfaSayisi = 481, Durum = true },
                    new Kitap { Ad = "Cesur Yeni Dünya", Yazar = "Aldous Huxley", ISBN = "9789750718534", SayfaSayisi = 300, Durum = true },
                    new Kitap { Ad = "Saatleri Ayarlama Enstitüsü", Yazar = "Ahmet Hamdi Tanpınar", ISBN = "9789750802424", SayfaSayisi = 392, Durum = true },
                    new Kitap { Ad = "Uçurtma Avcısı", Yazar = "Khaled Hosseini", ISBN = "9789750811716", SayfaSayisi = 374, Durum = true },
                    new Kitap { Ad = "Da Vinci Şifresi", Yazar = "Dan Brown", ISBN = "9789752106285", SayfaSayisi = 495, Durum = true },
                    new Kitap { Ad = "Aşk", Yazar = "Elif Şafak", ISBN = "9789752896193", SayfaSayisi = 420, Durum = true },
                    new Kitap { Ad = "Karamazov Kardeşler", Yazar = "Fyodor Dostoyevski", ISBN = "9786254052252", SayfaSayisi = 1040, Durum = true },
                    new Kitap { Ad = "Anna Karenina", Yazar = "Lev Tolstoy", ISBN = "9786053609977", SayfaSayisi = 864, Durum = true },
                    new Kitap { Ad = "Yabancı", Yazar = "Albert Camus", ISBN = "9789755101539", SayfaSayisi = 160, Durum = true },
                };

                Kaydet();
            }

            if (File.Exists(kitapDosya))
            {
                string kitapJson = File.ReadAllText(kitapDosya);
                KitapListesi = JsonSerializer.Deserialize<List<Kitap>>(kitapJson);
            }

            if (File.Exists(ogrenciDosya))
            {
                string ogrenciJson = File.ReadAllText(ogrenciDosya);
                OgrenciListesi = JsonSerializer.Deserialize<List<Ogrenci>>(ogrenciJson);
            }

            if (File.Exists(ogretmenDosya))
            {
                string ogretmenJson = File.ReadAllText(ogretmenDosya);
                OgretmenListesi = JsonSerializer.Deserialize<List<Ogretmen>>(ogretmenJson);
            }
        }

        public static void Kaydet()
        {
            var options = new JsonSerializerOptions { WriteIndented = true };

            File.WriteAllText(kitapDosya, JsonSerializer.Serialize(KitapListesi, options));
            File.WriteAllText(ogrenciDosya, JsonSerializer.Serialize(OgrenciListesi, options));
            File.WriteAllText(ogretmenDosya, JsonSerializer.Serialize(OgretmenListesi, options));
        }
    }


}
