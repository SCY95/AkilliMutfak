using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkilliMutfak
{
    public class UzaktanKumanda
    {
        public const int komutSayisi = 10;

        IKomut[] acmaKomutlari;
        IKomut[] kapamaKomutlari;
        IKomut[] fonkKomutlari;//fonksiyon

        public UzaktanKumanda()
        {
            IKomut komutYok = new KomutYok();
            acmaKomutlari = new IKomut[komutSayisi];
            kapamaKomutlari = new IKomut[komutSayisi];
            fonkKomutlari = new IKomut[komutSayisi];

            for (int i = 0; i < komutSayisi; i++)
            {
                acmaKomutlari[i] = komutYok;
                kapamaKomutlari[i] = komutYok;
                fonkKomutlari[i] = komutYok;
            }
        }

        public void komutEkle(int yuva, IKomut fonkkomutu)
        {
            fonkKomutlari[yuva] = fonkkomutu;
        }

        public void komutEkle(int yuva, IKomut acmaKomutu, IKomut kapamakomutu)
        {
            acmaKomutlari[yuva] = acmaKomutu;
            kapamaKomutlari[yuva] = kapamakomutu;
        }

        public void komutEkle(int yuva, IKomut acmaKomutu, IKomut kapamakomutu, IKomut fonkkomutu)
        {
            acmaKomutlari[yuva] = acmaKomutu;
            kapamaKomutlari[yuva] = kapamakomutu;
            fonkKomutlari[yuva] = fonkkomutu;
        }

        public void acTusunaBas(int yuva)
        {
            acmaKomutlari[yuva].Yurut();
        }

        public void kapaTusunaBas(int yuva)
        {
            kapamaKomutlari[yuva].Yurut();
        }

        public void fonkTusunaBas(int yuva)
        {
            fonkKomutlari[yuva].Yurut();
        }


        /*public void kullanımKılavuzu()
        {
            for (int i = 0; i < komutSayisi; i++)
            {
                Console.WriteLine((i + 1) + ". komut Ac : " + acmaKomutlari[i].GetType().Name + ". komut Kapa : " + kapamaKomutlari[i].GetType().Name);
            }
        }*/

    }
}
