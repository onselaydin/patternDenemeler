﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patternDenemeler
{
    class FacadeDesign
    {
    }
    //http://www.gencayyildiz.com/blog/c-facade-design-patternfacade-tasarim-deseni/

    class IskeletOlusturu
    {
        public int x { get; set; }
        public int y { get; set; }
        public bool z { get; set; }
    }
    class MotorOlusturucu
    {
        public int x { get; set; }
        public int y { get; set; }
        public bool z { get; set; }
    }

    class ArabaOlusturucu
    {
        public IskeletOlusturu Iskelet { get; set; }
        public MotorOlusturucu Motor { get; set; }
        public ArabaOlusturucu(IskeletOlusturu Iskelet, MotorOlusturucu Motor)
        {
            this.Iskelet = Iskelet;
            this.Motor = Motor;
        }

        public Araba Olustur(Renkler renk)
        {
            return new Araba(Iskelet, Motor, renk);
        }
    }

    enum Renkler
    {
        Kırmızı,
        Mavi,
        Mor,
        Yeşil,
        Sarı
    }
    class Araba
    {
        public Araba(IskeletOlusturu Iskelet, MotorOlusturucu Motor, Renkler Renk)
        {
            Console.WriteLine($"Iskelet x = {Iskelet.x}");
            Console.WriteLine($"Iskelet y = {Iskelet.y}");
            Console.WriteLine($"Iskelet z = {Iskelet.z}");
            Console.WriteLine($"Motor x = {Motor.x}");
            Console.WriteLine($"Motor y = {Motor.y}");
            Console.WriteLine($"Motor z = {Motor.z}");
            Console.WriteLine($"Renk = {Renk}");
        }
    }

    class FacadeUretici
    {
        IskeletOlusturu iskelet;
        MotorOlusturucu motor;
        ArabaOlusturucu olustur;

        public FacadeUretici()
        {
            iskelet = new IskeletOlusturu() { x = 3, y = 5, z = true };
            motor = new MotorOlusturucu() { x = 2, y = 4, z = false };
            olustur = new ArabaOlusturucu(iskelet, motor);
        }

        public void ArabaUret()
        {
            Araba uretilenAraba = olustur.Olustur(Renkler.Kırmızı);
        }
    }

}
