using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patternDenemeler
{
    class attributeTest
    {
    }


    [AttributeUsage(AttributeTargets.Property)]
    class KontrolAttribute : Attribute
    {
        public int Para { get; set; }
    }

    class AlisVeris
    {
        public AlisVeris(int Fiyat)
        {
            this.Fiyat = Fiyat;
            foreach (var property in typeof(AlisVeris).GetProperties())
            {
                foreach (var attr in property.GetCustomAttributes(false))
                {
                    if (property.Name == "Fiyat")
                    {
                        KontrolAttribute kontrolAttribute = (KontrolAttribute)attr;
                        if ((int)property.GetValue(this) > kontrolAttribute.Para)
                            Console.WriteLine("Alışveriş yapıldı.");
                        else
                            Console.WriteLine("Para eksik");
                    }
                }
            }
        }


        [Kontrol(Para = 100)]
        public int Fiyat { get; set; }
    }



    //[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Method)]  
    [AttributeUsage(AttributeTargets.Class)]
    //Class yaparsak sadece classda kullanabiliriz.
    public class OrnekAttribute:Attribute
    {
        public string Name { get; set; }
        public int Version { get; set; }

    }

    [Ornek(Name ="Yagmur",Version =1)]
    public class deneme
    {
        public int deger { get; set; }
        public void metod() { }
    }


    public class TREN
    {
        [Conditional("TURKCE")]
        public void Turkce()
        {
            Console.WriteLine("Bu program Türkçedir.");
        }

        [Conditional("ENGLISH")]
        public void English()
        {
            Console.WriteLine("Bu program İngilizcedir.");
        }
    }

}
