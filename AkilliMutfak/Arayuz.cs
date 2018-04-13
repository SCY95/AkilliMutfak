using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkilliMutfak
{
    public class Arayuz
    {
        AkilliMutfak akillimutfak;

        public Arayuz(AkilliMutfak akillimutfak)
        {
            this.akillimutfak = akillimutfak;
        }

        public void Calistir()
        {

            int secim = 1;
            while(secim != 7)
            {
                System.Console.Clear();
                Console.WriteLine("AkilliMutfak\n-------------\n" + "1-)Yemek yap\n2-)SicakIcecek hazirla\n3-)Havalandirma\n" + 
                    "4-)Klima\n5-)Isitici\n6-)Isiklar\n7-)Cikis"
                    );
                secim = (Convert.ToInt32(Console.ReadLine()));

                switch (secim)
                {
                    case 1:
                        YemekArayuz();
                        break;
                    case 2:
                        akillimutfak.uzaktankumanda.fonkTusunaBas(3);
                        break;
                    case 3:
                        HavalandirmaArayuz();
                        break;
                    case 4:
                        KlimaArayuz();
                        break;
                    case 5:
                        IsiticiArayuz();
                        break;
                    case 6:
                        IsikArayuz();
                        break;
                    default:
                        secim = 7;
                        break;
                }
                
                
            }
        }





        public void YemekArayuz()
        {
            System.Console.Clear();
            int secim;
            Console.WriteLine("1-)Firinda yemek yap\n2-)Ocakta yemek yap\n3-)Cikis");
            secim = (Convert.ToInt32(Console.ReadLine()));
            while (secim != 3)
            {
                switch (secim)
                {
                    case 1:
                        akillimutfak.uzaktankumanda.fonkTusunaBas(7);
                        break;
                    case 2:
                        akillimutfak.uzaktankumanda.fonkTusunaBas(8);
                        break;
                    default:
                        secim = 3;
                        break;
                }
            }
        }


        

       



        public void HavalandirmaArayuz()
        {
            System.Console.Clear();
            int secim;
            if (akillimutfak.havalandirma.calisiyor == true) Console.Write("Havalandirma calisiyor");
            else Console.WriteLine("Havalandirma calismiyor");
            if (akillimutfak.havalandirma.otomatik == true) Console.WriteLine("Otomatik havalandirma acik");
            else Console.WriteLine("Otomatik havalandirma kapali\n\n");

            Console.WriteLine("1-)Ac\n2-)Kapa\n3-)Otomatik havalandirmayi ac/kapa\n4-)Cikis");
            secim = (Convert.ToInt32(Console.ReadLine()));
            while (secim !=4)
            {

                if (akillimutfak.havalandirma.calisiyor == true) Console.Write("Havalandirma calisiyor");
            else Console.WriteLine("Havalandirma calismiyor");
            if (akillimutfak.havalandirma.otomatik == true) Console.WriteLine("Otomatik havalandirma acik");
            else Console.WriteLine("Otomatik havalandirma kapali\n\n");

            Console.WriteLine("1-)Ac\n2-)Kapa\n3-)Otomatik havalandirmayi ac/kapa\n4-)Cikis");
            secim = (Convert.ToInt32(Console.ReadLine()));

                switch (secim)
                {
                    case 1:
                        akillimutfak.uzaktankumanda.acTusunaBas(0);
                        break;
                    case 2:
                        akillimutfak.uzaktankumanda.kapaTusunaBas(0);
                        break;
                    case 3:
                        akillimutfak.uzaktankumanda.fonkTusunaBas(0);
                        break;
                    default:
                        secim = 4;
                        break;
                }
            }
        }

        public void KlimaArayuz()
        {
            System.Console.Clear();
            int secim;
            if (akillimutfak.klima.calisiyor == true) Console.Write("Klima calisiyor");
            else Console.WriteLine("Klima calismiyor");
            if (akillimutfak.klima.calisiyor == true) Console.WriteLine("Otomatik sogutma acik");
            else Console.WriteLine("Otomatik sogutma kapali\n\n");

            Console.WriteLine("1-)Ac\n2-)Kapa\n3-)Otomatik sogutmayi ac/kapa\n4-)Cikis");
            secim = (Convert.ToInt32(Console.ReadLine()));
            while (secim != 4)
            {

                if (akillimutfak.klima.calisiyor == true) Console.Write("Klima calisiyor");
                else Console.WriteLine("Klima calismiyor");
                if (akillimutfak.klima.calisiyor == true) Console.WriteLine("Otomatik sogutma acik");
                else Console.WriteLine("Otomatik sogutma kapali\n\n");

                Console.WriteLine("1-)Ac\n2-)Kapa\n3-)Otomatik sogutmayi ac/kapa\n4-)Cikis");
                secim = (Convert.ToInt32(Console.ReadLine()));

                switch (secim)
                {
                    case 1:
                        akillimutfak.uzaktankumanda.acTusunaBas(1);
                        break;
                    case 2:
                        akillimutfak.uzaktankumanda.kapaTusunaBas(1);
                        break;
                    case 3:
                        akillimutfak.uzaktankumanda.fonkTusunaBas(1);
                        break;
                    default:
                        secim = 4;
                        break;
                }
            }
        }

        public void IsiticiArayuz()
        {
            System.Console.Clear();
            int secim;
            if (akillimutfak.isitici.calisiyor == true) Console.Write("Isitici calisiyor");
            else Console.WriteLine("Isitici calismiyor");
            if (akillimutfak.isitici.otomatik == true) Console.WriteLine("Otomatik isitma acik");
            else Console.WriteLine("Otomatik isitma kapali\n\n");

            Console.WriteLine("1-)Ac\n2-)Kapa\n3-)Otomatik isitmayi ac/kapa\n4-)Cikis");
            secim = (Convert.ToInt32(Console.ReadLine()));
            while (secim != 4)
            {

                if (akillimutfak.isitici.calisiyor == true) Console.Write("Isitici calisiyor");
                else Console.WriteLine("Isitici calismiyor");
                if (akillimutfak.isitici.otomatik == true) Console.WriteLine("Otomatik isitma acik");
                else Console.WriteLine("Otomatik havalandirma kapali\n\n");

                Console.WriteLine("1-)Ac\n2-)Kapa\n3-)Otomatik isitmayi ac/kapa\n4-)Cikis");
                secim = (Convert.ToInt32(Console.ReadLine()));

                switch (secim)
                {
                    case 1:
                        akillimutfak.uzaktankumanda.acTusunaBas(2);
                        break;
                    case 2:
                        akillimutfak.uzaktankumanda.kapaTusunaBas(2);
                        break;
                    case 3:
                        akillimutfak.uzaktankumanda.fonkTusunaBas(2);
                        break;
                    default:
                        secim = 4;
                        break;
                }
            }
        }

        public void IsikArayuz()
        {
            System.Console.Clear();
            int secim;
            Console.WriteLine("1-)Tavan lambasini yak \t2-)Tavan lambasini kapa\n"+
                "3-)Dolap lambalarini ac \t4-)Dolap lambalarini kapa\n"+
                "5-)Yemek masasi lambasini ac \t6-)Yemek masasi lambasini kapa\n"
                +"7-)Cikis ");
            secim = (Convert.ToInt32(Console.ReadLine()));
            while (secim !=7)
            switch (secim)
            {
                case 1:
                    akillimutfak.uzaktankumanda.acTusunaBas(4);
                    break;
                case 2:
                    akillimutfak.uzaktankumanda.kapaTusunaBas(4);
                    break;
                case 3:
                    akillimutfak.uzaktankumanda.acTusunaBas(5);
                    break;
                case 4:
                    akillimutfak.uzaktankumanda.kapaTusunaBas(5);
                    break;
                case 5:
                    akillimutfak.uzaktankumanda.acTusunaBas(6);
                    break;
                case 6:
                    akillimutfak.uzaktankumanda.kapaTusunaBas(6);
                    break;
                default:
                    secim = 7;
                    break;
            }
        }




    }
}
