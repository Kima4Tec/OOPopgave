using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOOP
{
    public enum Farver
    {
        Gul = 1,
        Champagne = 2,
        Blå = 3,
        Sølv = 4,
        Rød = 5,
        Grøn = 6,
        Sort = 7,
        Hvid = 8,
    }
    public class Bil
    {
        public string Navn { get; set; }
        public string Model { get; set; }
        public string Farve { get; set; }
        public string Topfart { get; set; }
    }
}

