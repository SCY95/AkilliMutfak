using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkilliMutfak
{
    public abstract class Pisirici
    {
        public Yemek YemekIste(string yemekTuru)
        {
            Yemek yemek = YemekYap(yemekTuru);

            yemek.Hazirla();
            yemek.Pisir();
            yemek.Bol();
            yemek.Servis();

            return yemek;
        }

        protected abstract Yemek YemekYap(string yemekTuru);
    }

    public class Firin : Pisirici
    {
        protected override Yemek YemekYap(string yemekTuru)
        {
            Yemek yemek = null;

            if (yemekTuru == "Sebze")
                yemek = new FirindaSebzeliYemek();
            else if (yemekTuru == "Balik")
                yemek = new FirindaBalik();
            else if (yemekTuru == "Corba")
                yemek = new FirindaDomatesCorbasi();

            return yemek;
        }
    }

    public class Ocak : Pisirici
    {
        protected override Yemek YemekYap(string yemekTuru)
        {
            Yemek yemek = null;

            if (yemekTuru == "Sebze")
                yemek = new OcaktaSebzeliYemek();
            else if (yemekTuru == "Balik")
                yemek = new OcaktaBalik();
            else if (yemekTuru == "Corba")
                yemek = new OcaktaCorba();

            return yemek;
        }
    }

}
