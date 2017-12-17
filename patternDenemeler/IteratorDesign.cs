using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patternDenemeler
{
    class IteratorDesign
    {
    }

    struct Personel
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string SoyAdi { get; set; }
    }
    interface IAggregate
    {
        IIterator CreateIterator();
    }
    interface IIterator
    {
        //Bir sonraki adımda eleman var mı?
        bool HasItem();
        //Bir sonraki adımdaki elemanı getir.
        Personel NextItem();
        //Mevcut elemanı getir.
        Personel CurrentItem();
    }

    class PersonelAggregate : IAggregate
    {
        List<Personel> PersonelListesi = new List<Personel>();
        public void Add(Personel Model) => PersonelListesi.Add(Model);
        public Personel GetItem(int index) => PersonelListesi[index];
        public int Count { get => PersonelListesi.Count; }
        public IIterator CreateIterator() => new PersonelIterator(this);
    }
    class PersonelIterator : IIterator
    {
        PersonelAggregate aggregate;
        int currentindex;
        public PersonelIterator(PersonelAggregate aggregate) => this.aggregate = aggregate;
        public Personel CurrentItem() => aggregate.GetItem(currentindex);
        public bool HasItem()
        {
            if (currentindex < aggregate.Count)
                return true;
            return false;
        }
        public Personel NextItem()
        {
            if (HasItem())
                return aggregate.GetItem(currentindex++);
            return new Personel();
        }
    }
}
