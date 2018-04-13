using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkilliMutfak
{
    public abstract class SicakIcecek//Decorator Patttern
    {
        protected Malzemeler mlzm;


        public abstract string aciklama();
        public abstract Malzemeler MalzemeVer();


    }

    public class TurkKahvesi : SicakIcecek
    {
        public override string aciklama()
        {
            return "Turk Kahvesi";
        }

        public override Malzemeler MalzemeVer()
        {
            mlzm = new Malzemeler();
            mlzm.MiktarCekirdek = 6;
            return mlzm;
        }
    }

    public class Espresso : SicakIcecek
    {
        public override string aciklama()
        {
            return "Espresso";
        }

        public override Malzemeler MalzemeVer()
        {
            mlzm = new Malzemeler();
            mlzm.MiktarCekirdek = 9;
            return mlzm;
        }
    }

    public class Latte : SicakIcecek
    {
        public override string aciklama()
        {
            return "Latte";
        }

        public override Malzemeler MalzemeVer()
        {
            mlzm = new Malzemeler();
            mlzm.MiktarCekirdek = 9;
            mlzm.MiktarSut = 6;
            return mlzm;
        }
    }

    public class Filtre : SicakIcecek
    {
        public override string aciklama()
        {
            return "Filtre";
        }

        public override Malzemeler MalzemeVer()
        {
            mlzm = new Malzemeler();
            mlzm.MiktarCekirdek = 9;
            return mlzm;
        }
    }


    public abstract class Cesni : SicakIcecek { }

    public class Seker : Cesni
    {
        SicakIcecek sicakicecek;

        public Seker(SicakIcecek sicakicecek)
        {
            this.sicakicecek = sicakicecek;
        }

        public override string aciklama()
        {
            return sicakicecek.aciklama()+" + Seker";
        }

        public override Malzemeler MalzemeVer()
        {
            this.sicakicecek.MalzemeVer().MiktarSeker = 1;
            return this.sicakicecek.MalzemeVer();
        }

    }

    public class Vanilya : Cesni//Cesni olarak
    {
        SicakIcecek sicakicecek;

        public Vanilya(SicakIcecek sicakicecek)
        {
            this.sicakicecek = sicakicecek;
        }

        public override string aciklama()
        {
            return sicakicecek.aciklama() + " + Vanilya";
        }

        public override Malzemeler MalzemeVer()
        {
 	        this.sicakicecek.MalzemeVer().MiktarVanilya = 2;
            return this.sicakicecek.MalzemeVer();
        }
    }

    public class Cikolata : Cesni
    {
        SicakIcecek sicakicecek;

        public Cikolata(SicakIcecek sicakicecek)
        {
            this.sicakicecek = sicakicecek;
        }

        public override string aciklama()
        {
            return sicakicecek.aciklama() + " + Cikolata";
        }

        public override Malzemeler MalzemeVer()
        {
            this.sicakicecek.MalzemeVer().MiktarCiko = 2;
            return this.sicakicecek.MalzemeVer();
        }
    }

}
