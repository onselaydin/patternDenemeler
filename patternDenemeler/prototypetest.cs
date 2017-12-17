using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patternDenemeler
{
    class prototypetest
    {
    }

    abstract class PrototypeOyun
    {
        public abstract PrototypeOyun Clone();
    }

    class Game : PrototypeOyun
    {
        public int OyunID { get; set; }
        public string OyunAdi { get; set; }
        public string OyunTuru { get; set; }
        public bool Durum { get; set; }
        public Game(int OyunID, string OyunAdi, string OyunTuru, bool Durum)
        {
            this.OyunID = OyunID;
            this.OyunAdi = OyunAdi;
            this.OyunTuru = OyunTuru;
            this.Durum = Durum;
        }

        public override PrototypeOyun Clone()
        {
            return this.MemberwiseClone() as PrototypeOyun;
        }
    }


}
