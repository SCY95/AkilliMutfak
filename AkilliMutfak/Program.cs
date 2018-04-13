using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkilliMutfak
{
    class Program
    {
        static void Main(string[] args)
        {
            AkilliMutfak akillimutfak = new AkilliMutfak();

            Arayuz arayuz = new Arayuz(akillimutfak);

            arayuz.Calistir();
            














            Console.ReadLine();
        }
    }
}
