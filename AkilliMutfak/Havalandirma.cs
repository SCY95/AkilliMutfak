using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkilliMutfak
{
    class Havalandirma
    {
        private IklimOlcumler Olcumler;

        public Havalandirma()
        {

        }



        public void Guncelle(IklimOlcumler Olcumler)
        {
            this.Olcumler = Olcumler;

            if (Olcumler.Nem < 45 || Olcumler.Nem > 55 || Olcumler.HavaTemiz == false)
            {
                Calistir();
            }
        }

        public void Calistir()
        {

        }

    }
}
