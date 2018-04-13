using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkilliMutfak
{
    //Havalandirma
    public class HavalandirmaAc : IKomut
    {
        Havalandirma havalandirma;

        public HavalandirmaAc(Havalandirma havalandirma)
        {
            this.havalandirma= havalandirma;
        }

        public void Yurut()
        {
            havalandirma.Calistir();
        }
    }

    public class HavalandirmaKapa : IKomut
    {
        Havalandirma havalandirma;

        public HavalandirmaKapa(Havalandirma havalandirma)
        {
            this.havalandirma = havalandirma;
        }

        public void Yurut()
        {
            havalandirma.Durdur();
        }
    }

    public class OtomatikHavalandirma : IKomut
    {
        Havalandirma havalandirma;

        public OtomatikHavalandirma(Havalandirma havalandirma)
        {
            this.havalandirma = havalandirma;
        }

        public void Yurut()
        {
            havalandirma.Otomatik();
        }
    }
    //---------------------------------------------------------------------------------------------
    //Klima
    public class KlimaAc : IKomut
    {
        Klima klima;

        public KlimaAc(Klima klima)
        {
            this.klima = klima;
        }

        public void Yurut()
        {
            klima.Calistir();
        }
    }

    public class KlimaKapa : IKomut
    {
        Klima klima;

        public KlimaKapa(Klima klima)
        {
            this.klima = klima;
        }

        public void Yurut()
        {
            klima.Durdur();
        }
    }

    public class OtoSogutma : IKomut
    {
        Klima klima;

        public OtoSogutma(Klima klima)
        {
            this.klima = klima;
        }

        public void Yurut()
        {
            klima.Otomatik();
        }
    }

    //---------------------------------------------------------------------------------------------
    //Isıtıcı
    public class IsiticiAc : IKomut
    {
        Isitici isitici;

        public IsiticiAc(Isitici isitici)
        {
            this.isitici= isitici;
        }

        public void Yurut()
        {
            isitici.Calistir();
        }
    }

    public class IsiticiKapa : IKomut
    {
        Isitici isitici;

        public IsiticiKapa(Isitici isitici)
        {
            this.isitici = isitici;
        }

        public void Yurut()
        {
            isitici.Durdur();
        }
    }

    public class OtoIsitici : IKomut
    {
        Isitici isitici;

        public OtoIsitici(Isitici isitici)
        {
            this.isitici = isitici;
        }

        public void Yurut()
        {
            isitici.Otomatik();
        }
    }
    //---------------------------------------------------------------------------------------------
    //KahveMakinesi
    public class IcecekYap : IKomut
    {
        KahveMakinesi kahvemakinesi;
        
        public IcecekYap()
        {
            kahvemakinesi = KahveMakinesi.GetKahveMakinesi();
        }

        public void Yurut()
        {
            kahvemakinesi.IcecekHazirla();
        }


    }
    //---------------------------------------------------------------------------------------------
    //Isiklar
    public class IsikAc : IKomut
    {
        Isik isik;

        public IsikAc(Isik isik)
        {
            this.isik = isik;
        }

        public void Yurut()
        {
            isik.Ac();
        }
    }

    public class IsikKapa : IKomut
    {
        Isik isik;

        public IsikKapa(Isik isik)
        {
            this.isik = isik;
        }

        public void Yurut()
        {
            isik.Kapa();
        }
    }
    //---------------------------------------------------------------------------------------------
    //Yemekpisir
    public class YemekYap : IKomut
    {
        Pisirici pisirici;
        
        public YemekYap(Pisirici pisirici)
        {
            this.pisirici = pisirici;
        }

        public void Yurut()
        {
            pisirici.YemekIste();
        }
    }










    public class KomutYok : IKomut
    {
        public void Yurut() { }
    }

}
