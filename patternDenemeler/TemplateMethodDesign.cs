using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patternDenemeler
{
    class TemplateMethodDesign
    {
    }

    //http://www.gencayyildiz.com/blog/c-template-method-design-patterntemplate-method-tasarim-deseni/

    enum OdemeTipi
    {
        Pesin, Taksit
    }

    abstract class Alisveris
    {
        protected string UrunAdi;
        protected OdemeTipi odemeTipi;

        void Baslat() => Console.WriteLine("Alışveriş başladı.");
        void Bitir() => Console.WriteLine($"Alışveriş bitti.{UrunAdi} {odemeTipi} yöntemiyle alınmıştır.");
        abstract public void Urun();
        abstract public void OdemeSekli();

        public void TemplateMethod()
        {
            Baslat();
            Urun();
            OdemeSekli();
            Bitir();
        }
    }


    class Televizyon : Alisveris
    {
        public override void OdemeSekli()
        {
            odemeTipi = OdemeTipi.Pesin;
        }

        public override void Urun()
        {
            UrunAdi = "Televizyon";
        }
    }

    class Buzdolabi : Alisveris
    {
        public override void OdemeSekli()
        {
            odemeTipi = OdemeTipi.Taksit;
        }

        public override void Urun()
        {
            UrunAdi = "Buzdolabı";
        }
    }

}
