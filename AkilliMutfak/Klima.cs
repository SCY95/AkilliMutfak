using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkilliMutfak
{
    class Klima : Observer
    {
        private IklimOlcumler Olcumler;

        public Klima()
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
