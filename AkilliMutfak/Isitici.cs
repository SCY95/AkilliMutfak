using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkilliMutfak
{
    class Isitici
    {
        private IklimOlcumler Olcumler;

        public Isitici()
        {
            
        }



        public void Guncelle(IklimOlcumler Olcumler)
        {
            this.Olcumler = Olcumler;

            if (Olcumler.Sicaklik < 21)
            {
                Calistir();
            }
        }


        public void Calistir()
        {

        }
 

    }
}
