using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkilliMutfak
{
    public struct IklimOlcumler
    {
        public float O2;
        public float Sicaklik;
        public float Nem;
    }

    class IklimSensor : Subject
    {
        
        private IklimOlcumler Olcumler;



        public void GozlemciKaydet()
        {

        }

        public void GozlemciSil()
        {

        }

        public void GozlemcilereBildir()
        {

        }




        public float GetO2()
        {
            return Olcumler.O2;
        }

        public float GetSicaklik()
        {
            return Olcumler.Sicaklik;
        }

        public float GetNem()
        {
            return Olcumler.Nem;
        }

    }
}
