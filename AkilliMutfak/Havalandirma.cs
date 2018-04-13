using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkilliMutfak
{
    public class Havalandirma
    {
        private IklimOlcumler Olcumler;
        public bool calisiyor;
        public bool otomatik;

        public Havalandirma()
        {
            calisiyor = false;
            otomatik = true;
        }



        public void Guncelle(IklimOlcumler Olcumler)
        {
            this.Olcumler = Olcumler;

            if (otomatik == true && Olcumler.Nem < 45 || Olcumler.Nem > 55 || Olcumler.HavaTemiz == false)
            {
                Calistir();
            }
            else
            {
                Durdur();
            }
        }

        public void Calistir()
        {
            calisiyor = true;
        }

        public void Durdur()
        {
            calisiyor = false;
        }
    }
}
