using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkilliMutfak
{
    public abstract class SicakIcecek
    {
        protected Malzemeler mlzm;

        public abstract Malzemeler MalzemeVer();


    }

    public class TurkKahvesi : SicakIcecek
    {
        public override Malzemeler MalzemeVer()
        {
            mlzm.C_Turk = 2;
            return mlzm;
        }
    }



    public abstract class Cesni : SicakIcecek { }

    public class Seker : Cesni
    {
        SicakIcecek sicakicecek;

        public Seker(SicakIcecek sicakicecek)
        {
            this.sicakicecek = sicakicecek;
        }

        public override Malzemeler MalzemeVer()
        {
            this.sicakicecek.MalzemeVer().MiktarSeker = 1;
            return this.sicakicecek.MalzemeVer();
        }

    }

}
