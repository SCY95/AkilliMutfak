using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkilliMutfak
{
    interface Observer
    {
        void Guncelle();
    }

    interface Subject
    {
        void GozlemciKaydet();
        void GozlemciSil();
        void GozlemcilereBildir();
    }
}
