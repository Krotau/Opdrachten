using System;
namespace Opdracht_week_1_Dambord
{
    public class Meldingen
    {
        internal Random randint = new Random();

        public Meldingen()
        {
            Console.WriteLine("Maak ik dan ook een melding aan?");
        }

        // als iets niet kan wat opgevangen is
        internal void foutmelding()
        {
            Console.WriteLine("Dat hokje bestaat niet!");
        }

        internal void controleerZelf()
        {
            throw new NotImplementedException();
        }
    }
}
