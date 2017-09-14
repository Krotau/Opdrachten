using System;
namespace Opdracht_les
{
    public class Wiskunde : Les
    {
        private readonly string boekNaam;

        public Wiskunde(string leraar, int aantalLeerlingen, string boekNaam, string naam = "wiskunde")
        {
            this.leraar = leraar;
            this.naam = naam;
            this.aantalLeerlingen = aantalLeerlingen;
            this.boekNaam = boekNaam;
        }

        public void WiskundeLeren()
        {
            Console.WriteLine("Vandaag leren wij {1} uit het boek '{0}'", boekNaam, naam);
            Console.WriteLine("Deze les wordt gegeven door {0}", leraar);
            Console.WriteLine("Het aantal leerlingen zijn: {0}\n", aantalLeerlingen);
        }
    }
}
