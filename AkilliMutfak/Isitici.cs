using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkilliMutfak
{
    public class Isitici : Observer
    {
        private IklimOlcumler Olcumler;
        public bool calisiyor;
        public bool otomatik;

        public Isitici()
        {
            calisiyor = false;
            otomatik = true;
        }



        public void Guncelle(IklimOlcumler Olcumler)
        {
            this.Olcumler = Olcumler;

            if (otomatik == true && Olcumler.Sicaklik < 21 )
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

        public void Otomatik()
        {
            if (otomatik == true)
                otomatik = false;
            else
                otomatik = true;
        }
    
    }
}
