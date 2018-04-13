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











    public class KomutYok : IKomut
    {
        public void Yurut() { }
    }

}
