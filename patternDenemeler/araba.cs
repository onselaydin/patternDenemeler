using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patternDenemeler
{
    //Dependecy injection
    interface ITasit
    {
        void GazVer();
        void FrenYap();
        void SagaSinyal();
        void SolaSinyal();
    }
    class araba
    {
       

        
    }

   

    class Otobus: ITasit
    {
        public void GazVer()
        {
            //...
        }
        public void FrenYap()
        {
            //...
        }
        public void SagaSinyal()
        {
            //...
        }
        public void SolaSinyal()
        {
            //..
        }
    }

    class Motor : ITasit
    {
        public void GazVer()
        {
            //...
        }
        public void FrenYap()
        {
            //...
        }
        public void SagaSinyal()
        {
            //...
        }
        public void SolaSinyal()
        {
            //..
        }
    }

    class Minibus : ITasit
    {
        public void GazVer()
        {
            //...
        }
        public void FrenYap()
        {
            //...
        }
        public void SagaSinyal()
        {
            //...
        }
        public void SolaSinyal()
        {
            //..
        }
    }
}
