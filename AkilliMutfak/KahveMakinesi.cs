using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkilliMutfak
{
    class KahveMakinesi
    {
        private static KahveMakinesi BKahveMakinesi = new KahveMakinesi();
        enum Miktar { Bos = 0, Dusuk = 10, Orta = 20, Dolu = 30 };

        //KahveCekirdekleri
        Miktar C_Arabistan;
        Miktar C_Afrika;
        Miktar C_Kolombiya;
        Miktar C_Turk;

        Miktar MiktarSut;
        Miktar MiktarCiko;//Cikolata Miktari
        Miktar MiktarVanilya;

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
            SutYenile();
            CikoYenile();
            VanilyaYenile();
        }

    

        private void SutYenile()
        {
            MiktarSut = Miktar.Dolu;
        }

        private void CikoYenile()
        {
            MiktarCiko = Miktar.Dolu;
        }

        private void VanilyaYenile()
        {
            MiktarVanilya = Miktar.Dolu;
        }




    }
}
