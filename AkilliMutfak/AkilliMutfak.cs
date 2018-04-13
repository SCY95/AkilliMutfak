using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkilliMutfak
{
    class AkilliMutfak
    {
        private static AkilliMutfak BAkilliMutfak;
        public KahveMakinesi kahvemakinesi;
        public Havalandirma havalandirma;
        public Klima klima;
        public Isitici isitici;
        public Firin firin;
        public Ocak ocak;
        public UzaktanKumanda uzaktankumanda;

        private AkilliMutfak()
        {
            kahvemakinesi = KahveMakinesi.GetKahveMakinesi();
            havalandirma = new Havalandirma();
            klima = new Klima();
            isitici = new Isitici();
            firin = new Firin();
            ocak = new Ocak();
            uzaktankumanda = new UzaktanKumanda();

            HavalandirmaAc havalandirmaac = new HavalandirmaAc(havalandirma);
            HavalandirmaKapa havalandirmakapa = new HavalandirmaKapa(havalandirma);

            KlimaAc klimaac = new KlimaAc(klima);
            KlimaKapa klimakapa = new KlimaKapa(klima);

            IsiticiAc isiticiac = new IsiticiAc(isitici);
            IsiticiKapa isiticikapa = new IsiticiKapa(isitici);

            uzaktankumanda.komutEkle(0, havalandirmaac, havalandirmakapa);
            uzaktankumanda.komutEkle(1, klimaac, klimakapa);
            uzaktankumanda.komutEkle(2, isiticiac, isiticikapa);

           


        }


        public static AkilliMutfak GetAkilliMutfak()
        {
            if (BAkilliMutfak == null)
            {
                return BAkilliMutfak = new AkilliMutfak();
            }
            return BAkilliMutfak;
        }





    }
}
