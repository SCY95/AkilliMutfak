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
        public virtual void Hazirla()
        {
            Console.WriteLine("Sebzeleri hazirla");
        }

        public virtual void Pisir()
        {
            Console.WriteLine("Firinda pisir");
        }

        public virtual void Bol()
        {
            Console.WriteLine("Tabaklara koy");
        }

        public virtual void Servis()
        {
            Console.WriteLine("Servis et");
        }
    }


    class FirindaBalik : Yemek
    {
        public virtual void Hazirla()
        {
            Console.WriteLine("Baliklari ve cesnileri hazirla");
        }

        public virtual void Pisir()
        {
            Console.WriteLine("Firinda pisir");
        }

        public virtual void Bol()
        {
            Console.WriteLine("Tabaklara koy");
        }

        public virtual void Servis()
        {
            Console.WriteLine("Servis et");
        }
    }

    
    class FirindaDomatesCorbasi : Yemek
    {
        public virtual void Hazirla()
        {
            Console.WriteLine("Domatesleri hazirla");
        }

        public virtual void Pisir()
        {
            Console.WriteLine("Firinda Pisir");
        }

        public virtual void Bol()
        {
            Console.WriteLine("Kaselere koy");
        }

        public virtual void Servis()
        {
            Console.WriteLine("Servis et");
        }
    }



    //----------------------------------------------------------------------------------------------------------------


    class OcaktaSebzeliYemek : Yemek
    {
        public virtual void Hazirla()
        {
            Console.WriteLine("Sebzeleri hazirla");
        }

        public virtual void Pisir()
        {
            Console.WriteLine("Ocakta pisir");
        }

        public virtual void Bol()
        {
            Console.WriteLine("Tabaklara koy");
        }

        public virtual void Servis()
        {
            Console.WriteLine("Servis et");
        }
    }


    class OcaktaBalik : Yemek
    {
        public virtual void Hazirla()
        {
            Console.WriteLine("Baliklari ve cesnileri hazirla");
        }

        public virtual void Pisir()
        {
            Console.WriteLine("Ocakta pisir");
        }

        public virtual void Bol()
        {
            Console.WriteLine("Tabaklara koy");
        }

        public virtual void Servis()
        {
            Console.WriteLine("Servis et");
        }
    }


    class OcaktaCorba : Yemek
    {
        public virtual void Hazirla()
        {
            Console.WriteLine("Corba malzemelerini hazirla");
        }

        public virtual void Pisir()
        {
            Console.WriteLine("Ocakta Pisir");
        }

        public virtual void Bol()
        {
            Console.WriteLine("Kaselere koy");
        }

        public virtual void Servis()
        {
            Console.WriteLine("Servis et");
        }
    }







}
