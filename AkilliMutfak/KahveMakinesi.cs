using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkilliMutfak
{
    enum Miktar { Bos = 0, Dusuk = 10, Orta = 20, Dolu = 30 };
    public class KahveMakinesi//Singleton Pattern
    {
        private static KahveMakinesi BKahveMakinesi;


        Malzemeler Depo;

        int BardakSayisi;

        private KahveMakinesi()
        {
            Depo = new Malzemeler();
            HepsiniYenile();
            BardakSayisi = 30;
        }

        public static KahveMakinesi GetKahveMakinesi()
        {
            if (BKahveMakinesi == null)
            {
                return BKahveMakinesi = new KahveMakinesi();
            }
            return BKahveMakinesi;
        }

        private void HepsiniYenile()
        {
            CekirdekYenile();

            SutYenile();
            CikoYenile();
            VanilyaYenile();
            SekerYenile();
        }


        private void CekirdekYenile()
        {
            Depo.MiktarCekirdek = 30;
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




    
        public void IcecekHazirla(SicakIcecek sicakicecek)//TODO icecek uretimi yaptirilacak
        {
            Depo = Depo - sicakicecek.MalzemeVer();
        }

    }



    public class Malzemeler 
    {
        //KahveCekirdekleri
        public int MiktarCekirdek;

        public int MiktarSut;
        public int MiktarCiko;//Cikolata Miktari
        public int MiktarVanilya;
        public int MiktarSeker;


        public Malzemeler()
        {

            MiktarCekirdek = 0;

            MiktarSut = 0;
            MiktarCiko = 0;
            MiktarVanilya = 0;
            MiktarSeker = 0;
        }

        public Malzemeler(int MiktarCekirdek, int MiktarSut, int MiktarCiko, int MiktarVanilya, int MiktarSeker)
        {
            this.MiktarCekirdek = MiktarCekirdek;

            this.MiktarSut = MiktarSut;
            this.MiktarCiko = MiktarCiko;
            this.MiktarVanilya = MiktarVanilya;
            this.MiktarSeker = MiktarSeker;
        }


        public static Malzemeler operator -(Malzemeler mlzm1, Malzemeler mlzm2)
        {
            Malzemeler mlzm3 = new Malzemeler(mlzm1.MiktarCekirdek - mlzm2.MiktarCekirdek, mlzm1.MiktarSut - mlzm2.MiktarSut, mlzm1.MiktarCiko - mlzm2.MiktarCiko, mlzm1.MiktarVanilya - mlzm2.MiktarVanilya,
                mlzm1.MiktarSeker - mlzm2.MiktarSeker);
            return mlzm3;
        }
    }





}
