using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patternDenemeler
{
    class overloading
    {

        public void OverOrnek()
        {
            Console.WriteLine("Parametre yok");
        }

        // Tek sayı parametre için aşırı yüklenen metot
        public void OverOrnek(int a)
        {
            Console.WriteLine("Bir parametresi var: " + a);
        }

        // İki parametre için aşırı yüklenen metot
        public int OverOrnek(int a, int b)
        {
            Console.WriteLine("İki int parametresi var: " + a + " " + b);
            return a + b;
        }
        public double OverOrnek(double a, double b)
        {
            Console.WriteLine("İki double parametresi var: " + a + " " + b);
            return a + b;
        }


    }
}
