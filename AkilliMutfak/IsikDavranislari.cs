using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkilliMutfak
{
    public class BeyazYan : IRenkDavranisi
    {
        public void Renk()
        {
            Console.WriteLine("Beyaz");
        }
    }

    public class KırmızıYan : IRenkDavranisi
    {
        public void Renk()
        {
            Console.WriteLine("Kirmizi");
        }
    }

    public class YesilYan : IRenkDavranisi
    {
        public void Renk()
        {
            Console.WriteLine("Yesil");
        }
    }

    public class MaviYan : IRenkDavranisi
    {
        public void Renk()
        {
            Console.WriteLine("Mavi");
        }
    }

    public class Dolaplar : ITipDavranisi
    {
        public void Tip()
        {
            Console.WriteLine("Dolap isigi gibi yandi");
        }
    }

    public class Tavan : ITipDavranisi
    {
        public void Tip()
        {
            Console.WriteLine("Tavan isigi gibi yandi.");
        }
    }

    public class YemekMasasi : ITipDavranisi
    {
        public void Tip()
        {
            Console.WriteLine("Yemek masasi isigi gibi yandi.");
        }
    }
}
