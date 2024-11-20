using System;
using System.Collections.Generic;

class Siparis
{
    public DateTime Tarih { get; set; }
    public string Durum { get; set; }

    public Siparis(DateTime tarih, string durum)
    {
        Tarih = tarih;
        Durum = durum;
    }
}

class Musteri
{
    public string Ad { get; set; }
    public string Telefon { get; set; }
    public List<Siparis> Siparisler { get; set; } = new List<Siparis>();

    public Musteri(string ad, string telefon)
    {
        Ad = ad;
        Telefon = telefon;
    }

    public void SiparisVer(Siparis siparis)
    {
        Siparisler.Add(siparis);
    }
}

// Kullanım
class Program
{
    static void Main(string[] args)
    {
        // Yeni bir müşteri oluştur
        Musteri musteri = new Musteri("Ahmet Yılmaz", "555-123-4567");

        // Siparişler oluştur ve müşteriye ekle
        Siparis siparis1 = new Siparis(DateTime.Now, "Hazırlanıyor");
        Siparis siparis2 = new Siparis(DateTime.Now.AddDays(1), "Kargoya Verildi");

        musteri.SiparisVer(siparis1);
        musteri.SiparisVer(siparis2);

        // Müşteri bilgilerini yazdır
        Console.WriteLine($"Müşteri: {musteri.Ad}, Telefon: {musteri.Telefon}");
        foreach (var siparis in musteri.Siparisler)
        {
            Console.WriteLine($"Sipariş Tarihi: {siparis.Tarih}, Durum: {siparis.Durum}");
        }
    }
}
