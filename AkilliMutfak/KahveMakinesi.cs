using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkilliMutfak
{
    enum Miktar { Bos = 0, Dusuk = 10, Orta = 20, Dolu = 30 };
    class KahveMakinesi//Singleton
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

    
        public void IcecekHazirla(SicakIcecek sicakicecek)
        {
            Depo = Depo - sicakicecek.MalzemeVer();
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

        public Malzemeler(int C_Afrika, int C_Arabistan, int C_Kolombiya, int C_Turk, int MiktarSut, int MiktarCiko, int MiktarVanilya, int MiktarSeker)
        {
            this.C_Afrika = C_Afrika;
            this.C_Arabistan = C_Arabistan;
            this.C_Kolombiya = C_Kolombiya;
            this.C_Turk = C_Turk;

            this.MiktarSut = MiktarSut;
            this.MiktarCiko = MiktarCiko;
            this.MiktarVanilya = MiktarVanilya;
            this.MiktarSeker = MiktarSeker;
        }


        public static Malzemeler operator -(Malzemeler mlzm1, Malzemeler mlzm2)
        {
            Malzemeler mlzm3 = new Malzemeler(mlzm1.C_Afrika - mlzm2.C_Afrika, mlzm1.C_Arabistan - mlzm2.C_Arabistan, mlzm1.C_Kolombiya - mlzm2.C_Kolombiya,
                mlzm1.C_Turk - mlzm2.C_Turk, mlzm1.MiktarSut - mlzm2.MiktarSut, mlzm1.MiktarCiko - mlzm2.MiktarCiko, mlzm1.MiktarVanilya - mlzm2.MiktarVanilya,
                mlzm1.MiktarSeker - mlzm2.MiktarSeker);
            return mlzm3;
        }
    }





}
