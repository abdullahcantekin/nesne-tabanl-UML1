using System;
using System.Collections.Generic;

class Urun
{
    public string Ad { get; set; }
    public int Fiyat { get; set; }

    public Urun(string ad, int fiyat)
    {
        Ad = ad;
        Fiyat = fiyat;
    }
}

class Siparis
{
    public DateTime Tarih { get; set; }
    public decimal Toplam { get; set; }
    public List<Urun> Urunler { get; set; } = new List<Urun>();

    public Siparis(DateTime tarih)
    {
        Tarih = tarih;
    }

    public void UrunEkle(Urun urun)
    {
        Urunler.Add(urun);
        Toplam += urun.Fiyat;
    }
}
