using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkilliMutfak
{
    public abstract class Yemek
    {
        public virtual void Hazirla()
        {
            Console.WriteLine("Malzeme hazirla");
        }

        public virtual void Pisir()
        {
            Console.WriteLine("Pisir");
        }

        public virtual void Bol()
        {
            Console.WriteLine("Bol");
        }

        public virtual void Servis()
        {
            Console.WriteLine("Servis et");
        }
    }



    class FirindaSebzeliYemek : Yemek
    {
        public override void Hazirla()
        {
            Console.WriteLine("Sebzeleri hazirla");
        }

        public override void Pisir()
        {
            Console.WriteLine("Firinda pisir");
        }

        public override void Bol()
        {
            Console.WriteLine("Tabaklara koy");
        }

        public override void Servis()
        {
            Console.WriteLine("Servis et");
        }
    }


    class FirindaBalik : Yemek
    {
        public override void Hazirla()
        {
            Console.WriteLine("Baliklari ve cesnileri hazirla");
        }

        public override void Pisir()
        {
            Console.WriteLine("Firinda pisir");
        }

        public override void Bol()
        {
            Console.WriteLine("Tabaklara koy");
        }

        public override void Servis()
        {
            Console.WriteLine("Servis et");
        }
    }

    
    class FirindaDomatesCorbasi : Yemek
    {
        public override void Hazirla()
        {
            Console.WriteLine("Domatesleri hazirla");
        }

        public override void Pisir()
        {
            Console.WriteLine("Firinda Pisir");
        }

        public override void Bol()
        {
            Console.WriteLine("Kaselere koy");
        }

        public override void Servis()
        {
            Console.WriteLine("Servis et");
        }
    }



    //----------------------------------------------------------------------------------------------------------------


    class OcaktaSebzeliYemek : Yemek
    {
        public override void Hazirla()
        {
            Console.WriteLine("Sebzeleri hazirla");
        }

        public override void Pisir()
        {
            Console.WriteLine("Ocakta pisir");
        }

        public override void Bol()
        {
            Console.WriteLine("Tabaklara koy");
        }

        public override void Servis()
        {
            Console.WriteLine("Servis et");
        }
    }


    class OcaktaBalik : Yemek
    {
        public override void Hazirla()
        {
            Console.WriteLine("Baliklari ve cesnileri hazirla");
        }

        public override void Pisir()
        {
            Console.WriteLine("Ocakta pisir");
        }

        public override void Bol()
        {
            Console.WriteLine("Tabaklara koy");
        }

        public override void Servis()
        {
            Console.WriteLine("Servis et");
        }
    }


    class OcaktaCorba : Yemek
    {
        public override void Hazirla()
        {
            Console.WriteLine("Corba malzemelerini hazirla");
        }

        public override void Pisir()
        {
            Console.WriteLine("Ocakta Pisir");
        }

        public override void Bol()
        {
            Console.WriteLine("Kaselere koy");
        }

        public override void Servis()
        {
            Console.WriteLine("Servis et");
        }
    }







}
