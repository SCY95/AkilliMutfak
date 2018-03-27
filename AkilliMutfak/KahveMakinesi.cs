using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkilliMutfak
{
    enum Miktar { Bos = 0, Dusuk = 10, Orta = 20, Dolu = 30 };
    class KahveMakinesi
    {
        private static KahveMakinesi BKahveMakinesi = new KahveMakinesi();


        Malzemeler Depo;

        int BardakSayisi;

        private KahveMakinesi()
        {
            HepsiniYenile();
            BardakSayisi = 30;
        }

        public static KahveMakinesi GetKahveMakinesi()
        {
            return BKahveMakinesi;
        }

        private void HepsiniYenile()
        {
            C_AfrikaYenile();
            C_ArabistanYenile();
            C_KolombiyaYenile();
            C_TurkYenile();

            SutYenile();
            CikoYenile();
            VanilyaYenile();
        }


        private void C_AfrikaYenile()
        {
            Depo.MiktarSut = Miktar.Dolu;
        }
        


        private void C_ArabistanYenile()
        {
            Depo.C_Arabistan = Miktar.Dolu;
        }

        private void C_KolombiyaYenile()
        {
            Depo.C_Arabistan = Miktar.Dolu;
        }

        private void C_TurkYenile()
        {
            Depo.MiktarSut = Miktar.Dolu;
        }

        private void SutYenile()
        {
            Depo.MiktarSut = Miktar.Dolu;
        }

        private void CikoYenile()
        {
            Depo.MiktarCiko = Miktar.Dolu;
        }

        private void VanilyaYenile()
        {
            Depo.MiktarVanilya = Miktar.Dolu;
        }




    }



    struct Malzemeler 
    {
        //KahveCekirdekleri
        public Miktar C_Afrika;
        public Miktar C_Arabistan;
        public Miktar C_Kolombiya;
        public Miktar C_Turk;

        public Miktar MiktarSut;
        public Miktar MiktarCiko;//Cikolata Miktari
        public Miktar MiktarVanilya;
    }





}
