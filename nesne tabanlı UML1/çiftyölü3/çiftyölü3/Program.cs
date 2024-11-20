using System;
using System.Collections.Generic;

class Ebeveyn
{
    public string Ad { get; set; }
    public int Yas { get; set; }
    public List<Cocuk> Cocuklar { get; set; }

    public Ebeveyn(string ad, int yas)
    {
        Ad = ad;
        Yas = yas;
        Cocuklar = new List<Cocuk>();
    }

    public void CocukEkle(Cocuk cocuk)
    {
        if (!Cocuklar.Contains(cocuk))
        {
            Cocuklar.Add(cocuk);
            cocuk.EbeveynAtama(this);
        }
    }
}

class Cocuk
{
    public string Ad { get; set; }
    public int Yas { get; set; }
    public Ebeveyn Ebeveyn { get; private set; }

    public Cocuk(string ad, int yas)
    {
        Ad = ad;
        Yas = yas;
    }

    public void EbeveynAtama(Ebeveyn ebeveyn)
    {
        if (Ebeveyn == null)
        {
            Ebeveyn = ebeveyn;
            ebeveyn.CocukEkle(this);
        }
    }
}
