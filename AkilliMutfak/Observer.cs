using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkilliMutfak
{
    interface Observer
    {
        void Guncelle(IklimOlcumler Olcumler);
    }

    interface Subject
    {
        void GozlemciKaydet(Observer G);
        void GozlemciSil(Observer G);
        void GozlemcilereBildir();
    }
}
