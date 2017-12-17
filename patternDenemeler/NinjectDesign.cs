using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patternDenemeler
{
    class NinjectDesign
    {
    }

    interface IDurak
    {
        int Durak();
    }
    class ADurak : IDurak
    {
        public ADurak()
        {
            Durak();
        }
        public int Durak()
        {
            Console.WriteLine("A duraktayız.");
            return 10;
        }
    }
    class BDurak : IDurak
    {
        public BDurak()
        {
            Durak();
        }
        public int Durak()
        {
            Console.WriteLine("B duraktayız.");
            return 15;
        }
    }
    class CDurak : IDurak
    {
        public CDurak()
        {
            Durak();
        }
        public int Durak()
        {
            Console.WriteLine("C duraktayız.");
            return 20;
        }
    }



    //class Vasita
    //{
    //    ITasit _tasit;
    //    public Vasita(ITasit tasit)
    //    {
    //        _tasit = tasit;
    //    }

    //    public void Kullan()
    //    {
    //        _tasit.GazVer();
    //        _tasit.SagaSinyal();
    //        _tasit.FrenYap();
    //        _tasit.SolaSinyal();
    //    }
    //}

    //Property Setter Injection
    //class Vasita
    //{
    //    [Inject]
    //    public ITasit _tasit { get; set; }

    //    public void Kullan()
    //    {
    //        _tasit.GazVer();
    //        _tasit.SagaSinyal();
    //        _tasit.FrenYap();
    //        _tasit.SolaSinyal();
    //    }
    //}

    //Setter Method Injection
    class Vasita
    {
        ITasit _tasit;
        [Inject]
        public void VasitaAl(ITasit tasit)
        {
            this._tasit = tasit;
        }

        public void Kullan()
        {
            _tasit.GazVer();
            _tasit.SagaSinyal();
            _tasit.FrenYap();
            _tasit.SolaSinyal();
        }
    }

}
