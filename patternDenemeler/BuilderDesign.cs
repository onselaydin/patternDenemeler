using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patternDenemeler
{
    class BuilderDesign
    {
    }
    //http://www.gencayyildiz.com/blog/c-builder-design-patternbuilder-tasarim-deseni/
    //Product Class
    class Car
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public double KM { get; set; }
        public bool Vites { get; set; }
        public override string ToString()
        {
            return $"{Marka} marka araba {Model} modelinde {KM} kilometrede {Vites} vites olarak üretilmiştir.";
        }
    }
    //Builder
    abstract class IArabaBuilder
    {
        protected Car araba;
        public Car Araba
        {
            get { return araba; }
        }

        public abstract void SetMarka();
        public abstract void SetModel();
        public abstract void SetKM();
        public abstract void SetVites();
    }

    //ConcreteBuilder Class
    class OpelConcreteBuilder : IArabaBuilder
    {
        public OpelConcreteBuilder()
        {
            araba = new Car();
        }
        public override void SetKM() => araba.KM = 100;
        public override void SetMarka() => araba.Marka = "Opel";
        public override void SetModel() => araba.Model = "Astra";
        public override void SetVites() => araba.Vites = true;
    }
    //ConcreteBuilder Class
    class ToyotaConcreteBuilder : IArabaBuilder
    {
        public ToyotaConcreteBuilder()
        {
            araba = new Car();
        }
        public override void SetKM() => araba.KM = 150;
        public override void SetMarka() => araba.Marka = "Toyota";
        public override void SetModel() => araba.Model = "Corolla";
        public override void SetVites() => araba.Vites = true;
    }
    //ConcreteBuilder Class
    class BMWConcreteBuilder : IArabaBuilder
    {
        public BMWConcreteBuilder()
        {
            araba = new Car();
        }
        public override void SetKM() => araba.KM = 25;
        public override void SetMarka() => araba.Marka = "BMW";
        public override void SetModel() => araba.Model = "X Bilmem Kaç";
        public override void SetVites() => araba.Vites = true;
    }

    //Director Class
    class ArabaUret
    {
        public void Uret(IArabaBuilder Araba)
        {
            Araba.SetKM();
            Araba.SetMarka();
            Araba.SetModel();
            Araba.SetVites();
        }
    }
}
