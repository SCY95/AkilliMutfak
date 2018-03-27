using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkilliMutfak
{
    public abstract class SicakIcecek
    {
        public Malzemeler mlzm;

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



}
