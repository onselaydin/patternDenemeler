using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patternDenemeler
{
    class MementoDesign
    {
    }

    //http://www.gencayyildiz.com/blog/c-memento-design-patternmemento-tasarim-deseni/
    class Seksek
    {
        public int Level { get; set; }
        public string BolumAdi { get; set; }

        public override string ToString()
        {
            return $"{Level}. levelın {BolumAdi} bölümündeyiz.";
        }

        public SekSekMemento Kaydet()
        {
            return new SekSekMemento
            {
                BolumAdi = this.BolumAdi,
                Level = this.Level
            };
        }

        public void OncekiniYukle(SekSekMemento Memento)
        {
            this.BolumAdi = Memento.BolumAdi;
            this.Level = Memento.Level;
        }

    }
    class SekSekCareTaker
    {
        public SekSekMemento Memento { get; set; }
    }

    class SekSekMemento
    {
        public int Level { get; set; }
        public string BolumAdi { get; set; }
    }

    



}
