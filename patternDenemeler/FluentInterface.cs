using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patternDenemeler
{
    //http://www.gencayyildiz.com/blog/fluent-interface-nedir-nasil-kullanilir/
    class FluentInterface
    {

    }

    //class Asker
    //{
    //    public void Kos() => Console.WriteLine("Asker düz koşuyor...");
    //    public void SagaKos() => Console.WriteLine("Asker sağa koşuyor...");
    //    public void SolaKos() => Console.WriteLine("Asker sola koşuyor...");
    //    public void Dur() => Console.WriteLine("Asker duruyor...");
    //    public void GeriGel() => Console.WriteLine("Asker geri geliyor...");
    //}
    //-------------------------------------------------------------------------------
    interface IDavranislar
    {
        IDavranislar Kos();
        IDavranislar SagaKos();
        IDavranislar SolaKos();
        IDavranislar Dur();
        IDavranislar GeriGel();
    }
    class Asker : IDavranislar
    {
        public IDavranislar Kos()
        {
            Console.WriteLine("Asker düz koşuyor...");
            return this;
        }
        public IDavranislar SagaKos()
        {
            Console.WriteLine("Asker sağa koşuyor...");
            return this;
        }
        public IDavranislar SolaKos()
        {
            Console.WriteLine("Asker sola koşuyor...");
            return this;
        }
        public IDavranislar Dur()
        {
            Console.WriteLine("Asker duruyor...");
            return this;
        }
        public IDavranislar GeriGel()
        {
            Console.WriteLine("Asker geri geliyor...");
            return this;
        }
    }


    //----------------------------------------------------------------

    interface ITank
    {
        ITank SetTankAdi(string _TankAdi);
        ITank SetSeviye(Seviye _Seviye);
        ITank SetKoordinat(Koordinat _Koordinat);
        ITank SetTankResmi(string _TankResmi);
        ITank SetToplamPuan(double _ToplamPuan);
        void Yazdir();
    }
    enum Seviye
    {
        CokKolay,
        Kolay,
        Normal,
        Zor,
        CokZor
    }
    struct Koordinat
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
    class Tank : ITank
    {
        string _TankAdi;
        Seviye _Seviye;
        Koordinat _Koordinat;
        string _TankResmi;
        double _ToplamPuan;

        public void Yazdir()
        {
            Console.WriteLine(
                $@"Tank Adı : {_TankAdi}
               Seviye : {_Seviye}
               Koordinat : {_Koordinat.X } x {_Koordinat.Y}
               Tank Resmi : {_TankResmi}
               Toplam Puan : {_ToplamPuan}");
        }

        public ITank SetTankAdi(string _TankAdi)
        {
            this._TankAdi = _TankAdi;
            return this;
        }

        public ITank SetSeviye(Seviye _Seviye)
        {
            this._Seviye = _Seviye;
            return this;
        }

        public ITank SetKoordinat(Koordinat _Koordinat)
        {
            this._Koordinat = _Koordinat;
            return this;
        }

        public ITank SetTankResmi(string _TankResmi)
        {
            this._TankResmi = _TankResmi;
            return this;
        }

        public ITank SetToplamPuan(double _ToplamPuan)
        {
            this._ToplamPuan = _ToplamPuan;
            return this;
        }
    }


}
