using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkilliMutfak
{
    enum Miktar { Bos = 0, Dusuk = 10, Orta = 20, Dolu = 30 };
    public class KahveMakinesi//Singleton Pattern
    {
        private static KahveMakinesi BKahveMakinesi;


        Malzemeler Depo;

        int BardakSayisi;

        private KahveMakinesi()
        {
            Depo = new Malzemeler();
            HepsiniYenile();
            BardakSayisi = 30;
        }

        public static KahveMakinesi GetKahveMakinesi()
        {
            if (BKahveMakinesi == null)
            {
                return BKahveMakinesi = new KahveMakinesi();
            }
            return BKahveMakinesi;
        }

        private void HepsiniYenile()
        {
            CekirdekYenile();

            SutYenile();
            CikoYenile();
            VanilyaYenile();
            SekerYenile();
        }


        private void CekirdekYenile()
        {
            Depo.MiktarCekirdek = 30;
        }

        private void SutYenile()
        {
            Depo.MiktarSut = 30;
        }

        private void CikoYenile()
        {
            Depo.MiktarCiko = 30;
        }

        private void VanilyaYenile()
        {
            Depo.MiktarVanilya = 30;
        }

        private void SekerYenile()
        {
            Depo.MiktarSeker = 30;
        }

        public bool yeterliMi(SicakIcecek sicakicecek)
        {
            Depo = Depo - sicakicecek.MalzemeVer();
            if (Depo.MiktarCekirdek > 0 && Depo.MiktarSut > 0 && Depo.MiktarCiko > 0 && Depo.MiktarVanilya > 0 && Depo.MiktarSeker > 0)
                return true;
            else
                return false;
        }


    
        public SicakIcecek IcecekHazirla()//TODO icecek uretimi yaptirilacak
        {
            System.Console.Clear();

            int secim;
            SicakIcecek sicakicecek;

            Console.WriteLine("Icecegi secin\n" +
            "1-) TurkKahvesi\n2-) Espresso\n3-) Latte \n4-) Filtre "
            );
            secim = (Convert.ToInt32(Console.ReadLine()));


            
                switch (secim)
                {
                case 1:
                   if (yeterliMi(new TurkKahvesi()))
                    sicakicecek = new TurkKahvesi();
                    else 
                    {
                        Console.WriteLine("TurkKahvesi icin yeterli malzeme yok!\n" +
                            "Malzemeleri yenile?"
                            );
                        Console.ReadLine();
                        HepsiniYenile();
                        Console.WriteLine("Malzemeler yenilendi");
                        sicakicecek = new TurkKahvesi();
                    }
                    
             
                    break;
                case 2:
                    if (yeterliMi(new Espresso()))
                    sicakicecek = new Espresso();
                    else 
                    {
                        Console.WriteLine("Espresso icin yeterli malzeme yok!\n" +
                            "Malzemeleri yenile?"
                            );
                        Console.ReadLine();
                        HepsiniYenile();
                        Console.WriteLine("Malzemeler yenilendi");
                        sicakicecek = new Espresso();
                    }
                    
              
                    break;
                case 3:
                    if (yeterliMi(new Latte()))
                    sicakicecek = new Latte();
                    else 
                    {
                        Console.WriteLine("Latte icin yeterli malzeme yok!\n" +
                            "Malzemeleri yenile?"
                            );
                        Console.ReadLine();
                        HepsiniYenile();
                        Console.WriteLine("Malzemeler yenilendi");
                        sicakicecek = new Latte();
                    }
                    
               
                    break;
                case 4:
                    if (yeterliMi(new Filtre()))
                    sicakicecek = new Filtre();
                    else 
                    {
                        Console.WriteLine("Filtre icin yeterli malzeme yok!\n" +
                            "Malzemeleri yenile?"
                            );
                        Console.ReadLine();
                        HepsiniYenile();
                        Console.WriteLine("Malzemeler yenilendi");
                        sicakicecek = new Filtre();
                    }
                    
                
                    break;
                default:
                    if (yeterliMi(new TurkKahvesi()))
                    sicakicecek = new TurkKahvesi();
                    else 
                    {
                        Console.WriteLine("TurkKahvesi icin yeterli malzeme yok!\n" +
                            "Malzemeleri yenile?"
                            );
                        Console.ReadLine();
                        HepsiniYenile();
                        Console.WriteLine("Malzemeler yenilendi");
                        sicakicecek = new TurkKahvesi();
                    }
                    
                   
                    break;
                }
            
        


            Console.WriteLine(sicakicecek.aciklama()
                +"\nCesniyi secin\n" +
           "1-) Seker\n2-) Vanilya\n3-) Cikolata \n4-) Yeterli");
         

            secim = (Convert.ToInt32(Console.ReadLine()));

            while (secim != 4)
            {

                Console.WriteLine(sicakicecek.aciklama()
               + "\nCesniyi secin\n" +
                  "1-) Seker\n2-) Vanilya\n3-) Cikolata \n4-) Yeterli");
          

                secim = (Convert.ToInt32(Console.ReadLine()));

                switch (secim)
                {
                    case 1:
                        if (yeterliMi(sicakicecek))
                            sicakicecek = new Seker(sicakicecek);
                        else
                        {
                            Console.WriteLine(sicakicecek.aciklama() + " icin yeterli malzeme yok!\n" +
                                "Malzemeleri yenile?"
                                );
                            Console.ReadLine();
                            HepsiniYenile();
                            Console.WriteLine("Malzemeler yenilendi");
                            sicakicecek = new Seker(sicakicecek);
                        }
                        break;
                    case 2:
                        if (yeterliMi(sicakicecek))
                            sicakicecek = new Vanilya(sicakicecek);
                        else
                        {
                            Console.WriteLine(sicakicecek.aciklama() + " icin yeterli malzeme yok!\n" +
                                "Malzemeleri yenile?"
                                );
                            Console.ReadLine();
                            HepsiniYenile();
                            Console.WriteLine("Malzemeler yenilendi");
                            sicakicecek = new Vanilya(sicakicecek);
                        }
                        break;
                    case 3:
                        if (yeterliMi(sicakicecek))
                            sicakicecek = new Cikolata(sicakicecek);
                        else
                        {
                            Console.WriteLine(sicakicecek.aciklama() + " icin yeterli malzeme yok!\n" +
                                "Malzemeleri yenile?"
                                );
                            Console.ReadLine();
                            HepsiniYenile();
                            Console.WriteLine("Malzemeler yenilendi");
                            sicakicecek = new Cikolata(sicakicecek);
                        }
                        break;
                    default:
                        secim = 4;
                        break;
                }
            }


            return sicakicecek;

            
        }

    }



    public class Malzemeler 
    {
        //KahveCekirdekleri
        public int MiktarCekirdek;

        public int MiktarSut;
        public int MiktarCiko;//Cikolata Miktari
        public int MiktarVanilya;
        public int MiktarSeker;


        public Malzemeler()
        {

            MiktarCekirdek = 0;

            MiktarSut = 0;
            MiktarCiko = 0;
            MiktarVanilya = 0;
            MiktarSeker = 0;
        }

        public Malzemeler(int MiktarCekirdek, int MiktarSut, int MiktarCiko, int MiktarVanilya, int MiktarSeker)
        {
            this.MiktarCekirdek = MiktarCekirdek;

            this.MiktarSut = MiktarSut;
            this.MiktarCiko = MiktarCiko;
            this.MiktarVanilya = MiktarVanilya;
            this.MiktarSeker = MiktarSeker;
        }


        public static Malzemeler operator -(Malzemeler mlzm1, Malzemeler mlzm2)
        {
            Malzemeler mlzm3 = new Malzemeler(mlzm1.MiktarCekirdek - mlzm2.MiktarCekirdek, mlzm1.MiktarSut - mlzm2.MiktarSut, mlzm1.MiktarCiko - mlzm2.MiktarCiko, mlzm1.MiktarVanilya - mlzm2.MiktarVanilya,
                mlzm1.MiktarSeker - mlzm2.MiktarSeker);
            return mlzm3;
        }
    }





}
