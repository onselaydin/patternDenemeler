using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using onsel = System.String;
namespace patternDenemeler
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Creater creater = new Creater();
            //Oyun atariOyunu = creater.FactoryMethod(Oyunlar.Atari);
            //Oyun pcOyunu = creater.FactoryMethod(Oyunlar.PC);
            //Oyun psOyunu = creater.FactoryMethod(Oyunlar.PS);

            //atariOyunu.Platform();
            //pcOyunu.Platform();
            //psOyunu.Platform();

            //Opel o = new Opel();
            //o.Otomobil();

            //onsel o = "Onsel AYDIN";
            //Console.WriteLine(o);

            //Game g1 = new Game(1, "Soccer Star", "Futbol", true);
            //Game g2 = (Game)g1.Clone();

            //Console.WriteLine(g1.OyunAdi+g1.OyunID+g1.OyunTuru+g1.Durum);
            //Console.WriteLine(g2.OyunAdi + g2.OyunID + g2.OyunTuru + g2.Durum);
            //if(g1.Equals(g2))
            //{
            //    Console.WriteLine("Eşit");
            //}
            //else
            //{
            //    Console.WriteLine("Değil");
            //}
            //Uretici uret = new Uretici();//strategy design


            //Observe gözlemci dizay
            //Ogrenci o = new Ogrenci();
            //o.AboneEkle(new BabaObserver());
            //o.AboneEkle(new AnneObserver());
            //o.AboneEkle(new OgretmenObserver());

            //o.Adi = "Önsel";
            //o.SoyAdi = "Aydın";
            //o.Memleket = "Artvin";
            //o.Sinif = 42;
            //o.DersiAstiMi = false;

            //Console.ReadKey(false);

            //observe bitiş


            //Momento başlangı.
            //Seksek oyun = new Seksek();
            //oyun.Level = 1;
            //oyun.BolumAdi = "Mağara";
            //Console.WriteLine(oyun.ToString());

            //SekSekCareTaker Taker = new SekSekCareTaker();
            ////T anında ilgili SekSek nesnesini kopyalıyoruz ve
            ////CareTaker nesnesi içerisindeki Memento'ya bağlıyoruz.
            //Taker.Memento = oyun.Kaydet();

            //oyun.Level = 2;
            //oyun.BolumAdi = "Karayip Adaları";
            //Console.WriteLine(oyun.ToString());

            ////T anında kopyaladığımız nesneye CareTaker üzerinden erişiyor
            ////ve ilgili Originator nesnemize load ediyoruz.
            //oyun.OncekiniYukle(Taker.Memento);

            //Console.WriteLine(oyun.ToString());
            //Momento Bitiş

            //facede başlangıç
            //FacadeUretici uretici = new FacadeUretici();
            //uretici.ArabaUret();
            //facede bitiş

            //NinjectDesign başlangıç
            #region Ninject İle Dependency Injection Kullanımı

            //Ninject çekirdeği oluşturuyoruz.
            //IKernel kernel = new StandardKernel();
            //kernel.Bind<ITasit>().To<Otobus>();
            //var Vasita = kernel.Get<Vasita>();
            //Vasita.Kullan();

            //IKernel kernel = new StandardKernel();

            //kernel.Bind<ITasit>().To<Otobus>();
            //kernel.Bind<IDurak>().To<ADurak>();

            //var Vasita = kernel.Get<Vasita>();

            //Vasita.Kullan();


            #endregion
            //Ninject bitiş

            //Fluent desing
            //Asker asker = new Asker();
            //asker.Kos();
            //asker.SagaKos();
            //asker.Kos();
            //asker.Dur();
            //asker.GeriGel();
            //asker.SolaKos();
            //asker.Kos();

            //Asker asker = new Asker();
            //asker.Kos()
            //    .SagaKos()
            //    .Kos()
            //    .Dur()
            //    .GeriGel()
            //    .SolaKos()
            //    .Kos();

            //Tank tank = new Tank();
            //tank.SetSeviye(Seviye.Kolay)
            //    .SetKoordinat(new Koordinat() { X = 3, Y = 5 })
            //    .SetTankAdi("Önsel")
            //    .SetTankResmi("onsel.png")
            //    .SetToplamPuan(145)
            //    .Yazdir();

            //fluent bitiş.


            //Proxy Design
            //string KullaniciAdi = "", Sifre = "";
            //double Tutar = 0;
            //while (true)
            //{
            //    Console.WriteLine("Lütfen kullanıcı adınızı giriniz.");
            //    KullaniciAdi = Console.ReadLine();

            //    Console.WriteLine("Lütfen şifrenizi giriniz.");
            //    Sifre = Console.ReadLine();

            //    Console.WriteLine("Lütfen ödenecek miktarı giriniz.");
            //    Tutar = Convert.ToInt32(Console.ReadLine());

            //    IBanka banka = new ProxyBanka(KullaniciAdi, Sifre);
            //    banka.OdemeYap(Tutar);

            //    Console.WriteLine("************");
            //}
            //Proxy bitiş

            //Builder Design Başla
            //IArabaBuilder araba = new OpelConcreteBuilder();
            //ArabaUret uret = new ArabaUret();
            //uret.Uret(araba);

            //Console.WriteLine(araba.Araba.ToString());

            //araba = new ToyotaConcreteBuilder();
            //uret.Uret(araba);
            //Console.WriteLine(araba.Araba.ToString());
            //Builder biti


            //TemplateMethod
            //Alisveris a1 = new Televizyon();
            //a1.TemplateMethod();
            //Console.WriteLine("***********");
            //Alisveris a2 = new Buzdolabi();
            //a2.TemplateMethod();
            //template bitiş

            //iterator başla
            //PersonelAggregate aggregate = new PersonelAggregate();
            //aggregate.Add(new Personel { Id = 1, Adi = "Gençay", SoyAdi = "Yıldız" });
            //aggregate.Add(new Personel { Id = 2, Adi = "Ahmet", SoyAdi = "Çakmak" });
            //aggregate.Add(new Personel { Id = 3, Adi = "Mehmet", SoyAdi = "Aslıbay" });
            //aggregate.Add(new Personel { Id = 4, Adi = "Ayşe", SoyAdi = "Solmaz" });
            //aggregate.Add(new Personel { Id = 5, Adi = "Fatma", SoyAdi = "Nurgül" });

            //IIterator iterasyon = aggregate.CreateIterator();
            //while (iterasyon.HasItem())
            //{
            //    Console.WriteLine($"ID : {iterasyon.CurrentItem().Id}\nAdı : {iterasyon.CurrentItem().Adi}\nSoyadı : {iterasyon.CurrentItem().SoyAdi}\n*****");
            //    iterasyon.NextItem();
            //}
            //iterator bitir

            //abstract factory design

            //Olusturucu create = new Olusturucu(new SqlDatabase());
            //Console.WriteLine("**********");
            //create = new Olusturucu(new MySqlDatabase());
            //
            //Veritabani ver = Veritabani.veritabaniniAl;

            //singletone
            //Console.WriteLine(ver.ToString());
            //singleton bitiş

            //inheritace başla
            //Rectangle Rect = new Rectangle();
            //Rect.setWidth(5);
            //Rect.setHeight(7);
            //Console.WriteLine("Total area: {0}", Rect.getArea());
            //Console.ReadKey();
            //inheritance bitiş


            //Overloading test
            //overloading ov = new overloading();
            //int a;
            //double b;

            //// Tüm metotları çağırıyoruz
            //ov.OverOrnek();
            //Console.WriteLine();

            //ov.OverOrnek(2);
            //Console.WriteLine();

            //a = ov.OverOrnek(3, 5);
            //Console.WriteLine("Toplam: " + a.ToString());
            //Console.WriteLine();

            //b = ov.OverOrnek(1.3, 10.5);
            //Console.WriteLine("Toplam: " + b.ToString());

            //overloading test bitiş

            //interface başlangıç
            //Automobile a = new Automobile();
            //a.Calistir();
            //a.VitesDegistir(2);
            //a.Sur();
            //a.Parket();
            //a.Durdur();
            //Console.ReadKey();
            //interface bitişi

            //constructor başla
            //Urun u1 = new Urun(1, "onsel", 5);
            //Urun u2 = new Urun();
            //constructor bitiş

            //atrribute testleri

            AlisVeris alisVeris = new AlisVeris(150);
            AlisVeris alisVeris2 = new AlisVeris(10);

            //attribute bitiş

            Console.Read();
        }
    }
    
    enum Oyunlar
    {
        Atari,
        PC,
        PS
    }

    abstract class Oyun
    {
        public abstract void Platform();
    }

    class Atari : Oyun
    {
        public override void Platform()
        {
            Console.WriteLine("Bu oyun ATARİ platformunda çalışmaktadır.");
        }
    }

    class PC : Oyun
    {
        public override void Platform()
        {
            Console.WriteLine("Bu oyun PC platformunda çalışmaktadır.");
        }
    }

    class PS : Oyun
    {
        public override void Platform()
        {
            Console.WriteLine("Bu oyun PS platformunda çalışmaktadır.");
        }
    }


    class Creater
    {
        public Oyun FactoryMethod(Oyunlar OyunTipi)
        {
            Oyun oyun = null;
            switch (OyunTipi)
            {
                case Oyunlar.Atari:
                    oyun = new Atari();
                    break;
                case Oyunlar.PC:
                    oyun = new PC();
                    break;
                case Oyunlar.PS:
                    oyun = new PS();
                    break;
            }
            return oyun;
        }
    }

}
