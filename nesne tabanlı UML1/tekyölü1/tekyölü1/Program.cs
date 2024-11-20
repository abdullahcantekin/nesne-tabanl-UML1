using System;
using System.Collections.Generic;

class Kitap
{
    public string Baslik { get; set; }
    public string ISBN { get; set; }

    public Kitap(string baslik, string isbn)
    {
        Baslik = baslik;
        ISBN = isbn;
    }
}

class Yazar
{
    public string Ad { get; set; }
    public string Ulke { get; set; }
    public List<Kitap> Kitaplar { get; set; } = new List<Kitap>();

    public Yazar(string ad, string ulke)
    {
        Ad = ad;
        Ulke = ulke;
    }

    public void KitapEkle(Kitap kitap)
    {
        Kitaplar.Add(kitap);
    }
}
