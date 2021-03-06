﻿using System;
namespace Opdrachten
{
    public class Robot
    {
        // declarations
        private int plaats;
        private int richting;
        private int links = -1;
        private int rechts = 1;

        // constructor, geeft melding dat nieuwe robot is gemaakt
        // zet plaats en richting naar lokale variabele in huidige context
        public Robot(int richting = 0, int plaats = 0)
        {
            Console.WriteLine("Thank you for creating me! I will be a good robot. :D");
            this.plaats = plaats;
            this.richting = richting;
        }

        // verschuift de robot met een stap in een richting
        public void zetEenStap()
        {
            plaats += richting;
            Console.WriteLine("plaats: {0}", plaats);
        }

        // draait simpelweg de richting om zonder een input te hoeven hebben
        public void veranderRichting()
        {
            if (richting == links)
            {
                richting = rechts;
            }
            if (richting == rechts)
            {
                richting = links;
            }
        }

        // verander de richting na eigen keuze
        public void zetRichting(int keuze)
        {
            if (keuze >= links && keuze <= rechts)
            {
                richting = keuze;
                Console.WriteLine("Ik heb mijn richting naar {0} gezet! :D", richting);
            }
            else
            {
                Console.WriteLine("Iets verkeerd ingegeven. :c");
            }
        }

        // verplaats de robot naar de bestemming
        public void gaNaarBestemming(int bestemming)
        {
            Console.WriteLine("Ik ga mij nu naar {0} toe! :D", bestemming);

            if (bestemming < plaats)
            {
                zetRichting(links);
            }
            if (bestemming > plaats)
            {
                zetRichting(rechts);
            }
            while (plaats != bestemming)
            {
                zetEenStap();
            }
        }
    }
}
