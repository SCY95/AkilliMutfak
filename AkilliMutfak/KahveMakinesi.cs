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
            SekerYenile();
        }


        private void C_AfrikaYenile()
        {
            Depo.MiktarSut = 30;
        }
        
        private void C_ArabistanYenile()
        {
            Depo.C_Arabistan = 30;
        }

        private void C_KolombiyaYenile()
        {
            Depo.C_Arabistan = 30;
        }

        private void C_TurkYenile()
        {
            Depo.MiktarSut = 30;
        }

        private void SutYenile()
        {
            Depo.MiktarSut = 30;
        }

        private void CikoYenile()
        {
            Depo.MiktarCiko = 30;
        }

        private void VanilyaYenile()
        {
            Depo.MiktarVanilya = 30;
        }

        private void SekerYenile()
        {
            Depo.MiktarSeker = 30;
        }



    }



    public class Malzemeler 
    {
        //KahveCekirdekleri
        public int C_Afrika;
        public int C_Arabistan;
        public int C_Kolombiya;
        public int C_Turk;

        public int MiktarSut;
        public int MiktarCiko;//Cikolata Miktari
        public int MiktarVanilya;
        public int MiktarSeker;

        public Malzemeler()
        {
            C_Afrika = 0;
            C_Arabistan = 0;
            C_Kolombiya = 0;
            C_Turk = 0;

            MiktarSut = 0;
            MiktarCiko = 0;
            MiktarVanilya = 0;
            MiktarSeker = 0;
        }

    }





}
