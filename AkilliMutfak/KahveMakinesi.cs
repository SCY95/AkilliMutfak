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

        Miktar MiktarKahve;
        Miktar MiktarSut;
        Miktar MiktarCiko;//Cikolata Miktari


        private KahveMakinesi()
        {
            HepsiniYenile();
        }

        public static KahveMakinesi GetKahveMakinesi()
        {
            return BKahveMakinesi;
        }

        private void HepsiniYenile()
        {
            KahveYenile();
            SutYenile();
            CikoYenile();
        }

        private void KahveYenile()
        {
            MiktarKahve = Miktar.Dolu;
        }

        private void SutYenile()
        {
            MiktarSut = Miktar.Dolu;
        }

        private void CikoYenile()
        {
            MiktarCiko = Miktar.Dolu;
        }
    }
}
