using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patternDenemeler
{
    class Constructortest
    {
    }

    // Burada püf nokta sıfın ile metodun isminin aynı olması. new ile çağırığımuzda parametleri girilmeden nesne oluşturulamaz.
    class Urun
    {
        public int Id;
        public string Ad;
        public double Fiyat;

        public Urun(int id,string ad,double fiyat)
        {
            Id = id;
            Ad = ad;
            Fiyat = fiyat;

            Console.Write(id + " " + ad + " " + fiyat);

        }

    }
}
