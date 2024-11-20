
using System;
using System.Collections.Generic;

class Doktor
{
    public string Ad { get; set; }
    public string Brans { get; set; }
    public List<Hasta> Hastalar { get; set; }

    public Doktor(string ad, string brans)
    {
        Ad = ad;
        Brans = brans;
        Hastalar = new List<Hasta>();
    }

    public void HastaEkle(Hasta hasta)
    {
        if (!Hastalar.Contains(hasta))
        {
            Hastalar.Add(hasta);
            hasta.DoktorAtama(this);
        }
    }
}

class Hasta
{
    public string Ad { get; set; }
    public string TCNo { get; set; }
    public Doktor Doktor { get; private set; }

    public Hasta(string ad, string tcNo)
    {
        Ad = ad;
        TCNo = tcNo;
    }

    public void DoktorAtama(Doktor doktor)
    {
        if (Doktor == null)
        {
            Doktor = doktor;
            doktor.HastaEkle(this);
        }
    }
}
