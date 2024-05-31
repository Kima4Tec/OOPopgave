using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOOP
{
    public enum Transportmidler
    {
        Bil = 1,
        Cykel = 2,
        BusOgTog = 3,
        Motorcykel = 4,
        Taxa = 5,
    }
    public class Cykel
    {
        public string Navn { get; set; }
        public string Topfart { get; set; }
    }

    public class Motorcykel
    {
        public string Navn { get; set;}
        public string Topfart { get; set;}
    }

}
