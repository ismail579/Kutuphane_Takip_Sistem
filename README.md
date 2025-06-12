# 📚 Kütüphane Takip Sistemi

Windows Forms (C#) kullanılarak geliştirilmiş temel bir **Kütüphane Takip Sistemi**. Öğrenciler sisteme giriş yaparak kitap ödünç alabilir, iade edebilir ve mevcut kitapları görüntüleyebilirler.

## 🚀 Özellikler

- Öğrenci kayıt ve giriş sistemi
- Kitap listesi görüntüleme
- Kitap ödünç alma ve iade işlemleri
- Ödünç alınan kitapların listelenmesi
- Kalıcı veri saklama (JSON dosyaları ile)
- Kullanıcı dostu arayüz (Windows Forms)

## 🧩 Kullanılan Teknolojiler

- C# (Windows Forms)
- .NET Framework
- JSON ile veri kalıcılığı (`System.Text.Json`)
- ListView kontrolü ile görsel veri sunumu

## 📁 JSON Tabanlı Kalıcı Veri Saklama

Program, uygulamayı her kapatışta ya da yeni bir işlem sonrası verileri aşağıdaki dosyalara yazar ve açılışta geri yükler:

- `kitaplar.json` → Kayıtlı kitaplar
- `ogrenciler.json` → Öğrenci bilgileri
- `ogretmenler.json` → Öğretmen bilgileri (şu an kullanılmasa da hazır)

Veritabanı işlemleri `Veritabani.cs` içinde tanımlıdır ve `Yukle()` / `Kaydet()` metodları ile veri işlenir.

## 🧑‍💻 Projenin Yapısı

Kutuphane_Takip_Sistem/
├── Veritabani.cs # JSON üzerinden veri yükleme ve kaydetme
├── Form1.cs # Giriş ekranı (login form)
├── Form2.cs # Öğrenci kayıt ekranı
├── OgrenciEkran.cs # Kitap listeleme, ödünç alma, iade ekranı
├── Kitap.cs # Kitap modeli
├── Ogrenci.cs # Öğrenci modeli
├── Ogretmen.cs # (Geliştirilmeye açık)
├── kitaplar.json # Uygulama çalıştıkça oluşur
├── ogrenciler.json # Uygulama çalıştıkça oluşur
├── ogretmenler.json # Uygulama çalıştıkça oluşur
├── Kutuphane_Takip_Sistem.sln # Visual Studio çözüm dosyası


## 📷 Ekran Görüntüleri

>
> ```markdown
>![Screenshot 2025-06-12 204839](https://github.com/user-attachments/assets/f5e04cf4-4952-405c-b1c8-6ad8809479e4)
> 
> ![Screenshot 2025-06-12 204904](https://github.com/user-attachments/assets/eb133c41-202d-46e9-be92-2d4cd858bfba)
> 
> ![Screenshot 2025-06-12 204934](https://github.com/user-attachments/assets/03d298c6-9a77-444e-9832-e92faeab7d7c)
> ```

## 🔧 Kurulum

1. Bu projeyi klonlayın:

```bash
git clone https://github.com/kullanici-adi/Kutuphane_Takip_Sistem.git
