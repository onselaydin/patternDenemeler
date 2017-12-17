using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patternDenemeler
{
    class SingletonDesing
    {
    }

    public class Veritabani

    {
        private static Veritabani db;
        OleDbConnection baglanti;

        private Veritabani()
        {
            baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=deneme.mdb");
        }
        public static Veritabani veritabaniniAl
        {
            get
            {
                if (db == null)
                    db = new Veritabani();
                return db;
            }
        }
    }

}
