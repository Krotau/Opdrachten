using System;
namespace Opdracht_les
{
    public class Frans : Les
    {
        private readonly string boekNaam;

        public Frans(string leraar, int aantalLeerlingen, string boekNaam, string naam = "frans")
		{
			this.leraar = leraar;
			this.naam = naam;
			this.aantalLeerlingen = aantalLeerlingen;
			this.boekNaam = boekNaam;
		}

		public void FransLeren()
		{
			Console.WriteLine("Vandaag gaan wij {1} leren uit het boek '{0}'", boekNaam, naam);
			Console.WriteLine("je m'applle {0}", leraar);
			Console.WriteLine("Het aantal leerlingen zijn: {0}\n", aantalLeerlingen);
		}
    }
}
