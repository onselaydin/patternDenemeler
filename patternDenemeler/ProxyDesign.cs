using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patternDenemeler
{
    //http://www.gencayyildiz.com/blog/c-proxy-design-patternproxy-tasarim-deseni/
    class ProxyDesign
    {
    }

    //Subject Class
    interface IBanka
    {
        bool OdemeYap(double Tutar);
    }

    //Real Subject Class
    class Banka : IBanka
    {
        public bool OdemeYap(double Tutar)
        {
            if (Tutar < 100)
                Console.WriteLine($"Ödeyeceğiniz tutar 100 TL'den az olamaz. Fark -> { 100 - Tutar }");
            else if (Tutar > 100)
                Console.WriteLine($"Ödeyeceğiniz tutar 100 TL'den fazla olamaz. Fark -> { Tutar - 100 }");
            else
            {
                Console.WriteLine($"Ödeme başarıyla gerçekleştirildi. -> { Tutar }");
                return true;
            }

            return false;
        }
    }

    //Proxy Class
    class ProxyBanka : IBanka
    {
        Banka banka;
        bool Login;
        string KullaniciAdi, Sifre;
        public ProxyBanka(string KullaniciAdi, string Sifre)
        {
            this.KullaniciAdi = KullaniciAdi;
            this.Sifre = Sifre;
        }

        bool GirisYap()
        {
            if (KullaniciAdi.Equals("oncell") && Sifre.Equals("1234"))
            {
                banka = new Banka();
                Login = true;
                Console.WriteLine("Hesaba giriş yapıldı.");
                return true;
            }
            else
                Console.WriteLine("Lütfen kullanıcı adı ve şifreinizi doğru girdiğinize emin olunuz.");

            Login = false;
            return false;
        }

        public bool OdemeYap(double Tutar)
        {
            GirisYap();

            if (!Login)
            {
                Console.WriteLine("Hesaba giriş yapılmadığından dolayı ödeme alamıyoruz.");
                return false;
            }

            banka.OdemeYap(Tutar);
            return true;
        }
    }

}
