using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patternDenemeler
{

    public interface IArabaSur
    {
        void Calistir();
        void Sur();
        void Parket();
        void VitesDegistir(int vites);
        void Durdur();
    }
    class Interfacetest
    {
        
               

    }

    public class Automobile : IArabaSur
    {
        public void Calistir()
        {
            Console.WriteLine("Araba Çalıştırıldı.. Haydi Bismillah ");
        }
        public void Sur()
        {
            Console.WriteLine("Fazla Hız Yapmadan Sürmeye Devam");
        }
        public void Parket()
        {
            Console.WriteLine("Park Etme İşlemi Yapılıyor Dikkat Edin");
        }
        public void VitesDegistir(int vites)
        {
            Console.WriteLine(vites.ToString() + " . vitese geçildi hızını ona göre ayarla ");
        }
        public void Durdur()
        {
            Console.WriteLine("Okula geldik : ) hadi geçmiş olsun....");
        }
    }
}
