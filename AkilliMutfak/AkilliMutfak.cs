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

        private AkilliMutfak()
        {
           
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
