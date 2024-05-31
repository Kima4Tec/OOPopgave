using System;

namespace TestOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var hansBil = new Bil
            {
                Navn = "Seat",
                Model = "Toledo",
                Topfart = "200 km/t"
            };

            var petersMotorcykel = new Motorcykel
            {
                Navn = "Honda",
                Topfart = "158 km/t"
            };

            var evasCykel = new Cykel
            {
                Navn = "Raleigh",
                Topfart = "15 km/t"
            };

            List<Person> personListe = new List<Person>
            {
                new Person("Hans", Køn.mand, Transportmidler.Bil, hansBil, Farver.Champagne),
                new Person("Peter", Køn.mand, Transportmidler.Motorcykel, null, petersMotorcykel),
                new Person("Mette", Køn.kvinde, Transportmidler.BusOgTog),
                new Person("Eva", Køn.kvinde, Transportmidler.Cykel,evasCykel,null)
            };

            int i = 0;
            foreach (Person person in personListe)
            {
                i++;
                //Overskrift i farven blå med en grå linje
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"Person nr. {i} ");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("----------------------------");
                Console.ResetColor();

                //Udskriver listen personListe via ToString i Person-klasse
                Console.WriteLine(person.ToString());
            }





        }
    }
}

