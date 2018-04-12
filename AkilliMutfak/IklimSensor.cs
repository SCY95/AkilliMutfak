using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkilliMutfak
{
    public struct IklimOlcumler
    {
        public bool HavaTemiz;
        public float Sicaklik;
        public float Nem;
    }

    class IklimSensor : Subject
    {
        
        private IklimOlcumler Olcumler;
        private List<Observer> Gozlemciler;

        public IklimSensor()
        {
            Gozlemciler = new List<Observer>();
        }




        public void GozlemciKaydet(Observer G)
        {
            Gozlemciler.Add(G);
        }

        public void GozlemciSil(Observer G)
        {
            if (Gozlemciler.IndexOf(G) >= 0)
            {
                Gozlemciler.Remove(G);
            }
        }

        public void GozlemcilereBildir()
        {
            for (int i = 0; i < Gozlemciler.Count; i++)
            {
                Observer Gozlemci = Gozlemciler[i];
                Gozlemci.Guncelle(this.Olcumler);
            }
        }



        public void IklimDegisti()
        {
            GozlemcilereBildir();
        }



        public void setOlcumler(IklimOlcumler Olcumler)
        {
            this.Olcumler = Olcumler;
            IklimDegisti();
        }


        public bool GetO2()
        {
            return Olcumler.HavaTemiz;
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
