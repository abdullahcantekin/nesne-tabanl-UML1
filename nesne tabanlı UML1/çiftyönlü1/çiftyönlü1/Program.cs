using System;
using System.Collections.Generic;

class Yazar
{
    public string Ad { get; set; }
    public string Ulke { get; set; }
    public List<Kitap> Kitaplar { get; set; }

    public Yazar(string ad, string ulke)
    {
        Ad = ad;
        Ulke = ulke;
        Kitaplar = new List<Kitap>();
    }

    public void KitapEkle(Kitap kitap)
    {
        if (!Kitaplar.Contains(kitap))
        {
            Kitaplar.Add(kitap);
            kitap.YazarAtama(this);
        }
    }
}

class Kitap
{
    public string Baslik { get; set; }
    public DateTime YayinTarihi { get; set; }
    public Yazar Yazar { get; private set; }

    public Kitap(string baslik, DateTime yayinTarihi)
    {
        Baslik = baslik;
        YayinTarihi = yayinTarihi;
    }

    public void YazarAtama(Yazar yazar)
    {
        if (Yazar == null)
        {
            Yazar = yazar;
            yazar.KitapEkle(this);
        }
    }
}
