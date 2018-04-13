using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkilliMutfak
{
    public abstract class Pisirici
    {
        public Yemek YemekIste()
        {
            Yemek yemek = YemekYap();

            yemek.Hazirla();
            yemek.Pisir();
            yemek.Bol();
            yemek.Servis();

            return yemek;
        }

        protected abstract Yemek YemekYap();
    }

    public class Firin : Pisirici
    {
        protected override Yemek YemekYap()
        {
            
            Yemek yemek = null;

            int secim;
            Console.WriteLine("1-)Firinda sebze yemegi yap\n2-)Firinda balik yap\n3-)Firinda domates corbasi yap");
            secim = (Convert.ToInt32(Console.ReadLine()));
            switch (secim)
            {
                case 1:
                    yemek = new FirindaSebzeliYemek();
                    return yemek;
                case 2:
                    yemek = new FirindaBalik();
                    return yemek;
                case 3:
                    yemek = new FirindaDomatesCorbasi();
                    return yemek;
                default:
                    yemek = new FirindaSebzeliYemek();
                    return yemek;
            }
        }



    }

    public class Ocak : Pisirici
    {
        protected override Yemek YemekYap()
        {
            System.Console.Clear();
            Yemek yemek = null;

            int secim;
            Console.WriteLine("1-)Ocakta sebze yemegi yap\n2-)Ocakta balik yap\n3-)Ocakta corba yap");
            secim = (Convert.ToInt32(Console.ReadLine()));
            switch (secim)
            {
                case 1:
                    yemek = new OcaktaSebzeliYemek();
                    return yemek;
                case 2:
                    yemek = new OcaktaBalik();
                    return yemek;
                case 3:
                    yemek = new OcaktaCorba();
                    return yemek;
                default:
                    yemek = new OcaktaSebzeliYemek();
                    return yemek;
            }
        }
    }

}
