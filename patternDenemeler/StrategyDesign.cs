using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patternDenemeler
{
    class StrategyDesign
    {
    }

    //http://www.gencayyildiz.com/blog/c-strategy-design-patternstrateji-tasarim-deseni/
    class Ford
    {
        public Ford(string UretimTipi)
        {
            Console.WriteLine($"Ford {UretimTipi} üretilmiştir.");
        }
        public string Marka { get; set; }
        public string Model { get; set; }
        public int KM { get; set; }
    }


    class SeriUret
    {
        public Ford Uret()
        {
            return new Ford("seri");
        }
    }
    class OzelYapimUret
    {
        public Ford Uret()
        {
            return new Ford("özel yapım");
        }
    }

    class SiparisUzerineUret
    {
        public Ford Uret()
        {
            return new Ford("sipariş üzerine");
        }
    }

    class Uretici
    {
        public Uretici()
        {
            SeriUret sUret = new SeriUret();
            sUret.Uret();
        }
    }


}
