using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkilliMutfak
{
    public abstract class Isik
    {
        IRenkDavranisi renk;
        ITipDavranisi tip;

        public virtual void RenkSec()
        {
            this.renk.Renk();
        }

        public virtual void RenkAta(IRenkDavranisi gelenRenk)
        {
            this.renk = gelenRenk;
        }

        public virtual void TipSec()
        {
            this.tip.Tip();
        }

        public virtual void TipAta(ITipDavranisi gelenTip)
        {
            this.tip = gelenTip;
        }

        public virtual void Ac()
        {
            Console.WriteLine("Acildi.");
        }

        public virtual void Kapa()
        {
            Console.WriteLine("Kapandi.");
        }
    }

    public class TavanLambasi : Isik
    {
        public TavanLambasi()
        {
            Console.WriteLine("Tavan");
            RenkAta(new BeyazYan());
            TipAta(new Tavan());
        }
    }

    public class DolapLambasi : Isik
    {
        public DolapLambasi()
        {
            Console.WriteLine("Dolap Lambasi");
            RenkAta(new MaviYan());
            TipAta(new Dolaplar());
        }
    }

    public class YemekMasasiLambasi : Isik
    {
        public YemekMasasiLambasi()
        {
            Console.WriteLine("Yemek Masasi Lambasi");
            RenkAta(new KırmızıYan());
            TipAta(new YemekMasasi());
        }
    }
}
