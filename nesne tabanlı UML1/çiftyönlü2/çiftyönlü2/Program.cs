using System;
using System.Collections.Generic;

class Sirket
{
    public string Ad { get; set; }
    public string Konum { get; set; }
    public List<Calisan> Calisanlar { get; set; }

    public Sirket(string ad, string konum)
    {
        Ad = ad;
        Konum = konum;
        Calisanlar = new List<Calisan>();
    }

    public void CalisanEkle(Calisan calisan)
    {
        if (!Calisanlar.Contains(calisan))
        {
            Calisanlar.Add(calisan);
            calisan.SirketAtama(this);
        }
    }
}

class Calisan
{
    public string Ad { get; set; }
    public string Pozisyon { get; set; }
    public Sirket Sirket { get; private set; }

    public Calisan(string ad, string pozisyon)
    {
        Ad = ad;
        Pozisyon = pozisyon;
    }

    public void SirketAtama(Sirket sirket)
    {
        if (Sirket == null)
        {
            Sirket = sirket;
            sirket.CalisanEkle(this);
        }
    }
}
