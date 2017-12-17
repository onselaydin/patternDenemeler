using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patternDenemeler
{
    public abstract class test
    {

    }
        enum Otomobiller
        {
            Reno,
            Fiat,
            Opel
        }

        interface IOtomatikArac
        {
            void Otomobil();
        }
        interface IDuzVitestArac
        {
            void Otomobil();
        }
    

    public class Reno : IOtomatikArac
    {
        public void Otomobil()
        {
            Console.WriteLine("Bu reno megane araç otomatiktir...");
        }
    }
    public class Fiat : IDuzVitestArac
    {
        public void Otomobil()
        {
            Console.WriteLine("Bu Fiyat araç düz vites bir araçtır");
        }
    }

    public class Opel : IOtomatikArac
    {
        public void Otomobil()
        {
            Console.WriteLine("Bu opel araç otomaiktir....");
        }
    }
    
}
