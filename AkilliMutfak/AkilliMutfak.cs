using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkilliMutfak
{
    public class AkilliMutfak
    {

        public KahveMakinesi kahvemakinesi;
        public Havalandirma havalandirma;
        public Klima klima;
        public Isitici isitici;
        public Firin firin;
        public Ocak ocak;
        public UzaktanKumanda uzaktankumanda;
        public TavanLambasi Ltavan;
        public DolapLambasi Ldolap;
        public YemekMasasiLambasi Lyemekmasasi; 





        public AkilliMutfak()
        {
            kahvemakinesi = KahveMakinesi.GetKahveMakinesi();
            havalandirma = new Havalandirma();
            klima = new Klima();
            isitici = new Isitici();
            firin = new Firin();
            ocak = new Ocak();
            uzaktankumanda = new UzaktanKumanda();
            Ltavan = new TavanLambasi();
            Ldolap = new DolapLambasi();
            Lyemekmasasi = new YemekMasasiLambasi();


            HavalandirmaAc havalandirmaac = new HavalandirmaAc(havalandirma);
            HavalandirmaKapa havalandirmakapa = new HavalandirmaKapa(havalandirma);
            OtomatikHavalandirma otohavalandirma = new OtomatikHavalandirma(havalandirma); 

            KlimaAc klimaac = new KlimaAc(klima);
            KlimaKapa klimakapa = new KlimaKapa(klima);
            OtoSogutma otosogutma = new OtoSogutma(klima);


            IsiticiAc isiticiac = new IsiticiAc(isitici);
            IsiticiKapa isiticikapa = new IsiticiKapa(isitici);
            OtoIsitici otoisitici = new OtoIsitici(isitici);

            IsikAc Ltavanac = new IsikAc(Ltavan);
            IsikAc Ldolapac = new IsikAc(Ldolap);
            IsikAc Lyemekmasasiac = new IsikAc(Lyemekmasasi);

            IsikKapa Ltavankapa = new IsikKapa(Ltavan);
            IsikKapa Ldolapkapa = new IsikKapa(Ldolap);
            IsikKapa Lyemekmasasikapa = new IsikKapa(Lyemekmasasi);
            

            YemekYap firinda = new YemekYap(firin);
            YemekYap ocakta = new YemekYap(ocak);
            IcecekYap icecekyap = new IcecekYap();

            uzaktankumanda.komutEkle(0, havalandirmaac, havalandirmakapa, otohavalandirma);
            uzaktankumanda.komutEkle(1, klimaac, klimakapa, otosogutma);
            uzaktankumanda.komutEkle(2, isiticiac, isiticikapa, otoisitici);
            uzaktankumanda.komutEkle(3, icecekyap);
            uzaktankumanda.komutEkle(4, Ltavanac, Ltavankapa);
            uzaktankumanda.komutEkle(5, Ldolapac, Ldolapkapa);
            uzaktankumanda.komutEkle(6, Lyemekmasasiac, Lyemekmasasikapa);
            uzaktankumanda.komutEkle(7, firinda);
            uzaktankumanda.komutEkle(8, ocakta);

        }








    }
}
