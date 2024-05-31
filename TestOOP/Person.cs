namespace TestOOP
{
    public class Person : Vaesen
    {
        public string Navn { get; set; }
        public int Alder { get; set; }
        public Køn Koen {  get; set; }
        public Farver Farve { get; set; }
        public Transportmidler Transportmiddel { get; set; }
        public Bil Bil { get; set; }
        public Cykel Cykel { get; set; }
        public Motorcykel Motorcykel { get; set; }


    public Person(string navn, Køn koen, Transportmidler transportmiddel, Bil bil, Farver farve)
        {
            Navn = navn;
            Koen = koen;
            Transportmiddel = transportmiddel;
            Bil = bil;
            Farve = farve;
        }
        public Person(string navn, Køn koen, Transportmidler transportmiddel, Cykel cykel, Motorcykel motorcykel)
        {
            Navn = navn;
            Koen = koen;
            Transportmiddel = transportmiddel;
            Cykel = cykel;
            Motorcykel = motorcykel;
        }

        public Person(string navn, Køn koen, Transportmidler transportmiddel)
        {
            Navn = navn;
            Koen = koen;
            Transportmiddel = transportmiddel;
        }

        public override string? ToString()
        {
            if (Transportmiddel == Transportmidler.Bil) 
            { 
            return $"Navn:\t\t {Navn}\nKøn:\t\t {Koen}\nTransportmiddel: {Transportmiddel}\nBil:\t\t {Bil.Navn}\nModel:\t\t {Bil.Model}\nTopfart:\t {Bil.Topfart}\nBilens farve:\t {Farve}\n";
            }
            else if (Transportmiddel == Transportmidler.Motorcykel)
            {
                return $"Navn:\t\t {Navn}\nKøn:\t\t {Koen}\nTransportmiddel: {Transportmiddel}\nNavn:\t\t {Motorcykel.Navn} \nTopfart:\t {Motorcykel.Topfart}\n" ;
            }
            else if (Transportmiddel == Transportmidler.Cykel)
            {
                return $"Navn:\t\t {Navn}\nKøn:\t\t {Koen}\nTransportmiddel: {Transportmiddel}\nNavn:\t\t {Cykel.Navn} \nTopfart:\t {Cykel.Topfart}\n";
            }
            else
            {
            return $"Navn:\t\t {Navn}\nKøn:\t\t {Koen}\nTransportmiddel: {Transportmiddel}\n";
            }
        }
    }
}
