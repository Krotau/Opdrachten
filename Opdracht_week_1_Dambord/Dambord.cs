using System;
namespace Opdracht_week_1_Dambord
{
    public class Dambord : Meldingen
    {
        // Declarations, globaal bekend binnen deze klassen
        private int steen;
        private int size;

        public Dambord(int steen = 1, int size = 100)
        {
			this.steen = steen;
			this.size = size;

            zetSteen(randint.Next(1, 101));
            Console.WriteLine("Dambord met grootte: {0}", this.size);
            Console.WriteLine("Positie steen: {0} \n", this.steen);
            Console.WriteLine("object: {0} \n", this.ToString());

            printAlles();
        }


        // Steen informatie methodes
        internal void zetSteen(int positie)
        {
            if (positie > 0 && positie <= 100)
            {
                this.steen = positie;
            }
            else
            {
                Console.WriteLine("Buiten bereik!");
            }
        }

        internal void printAlles()
        {
            toonLinksBoven();
            toonBoven();
            toonRechtsBoven();
            toonLinks();
            Console.WriteLine(steen);
            toonRechts();
            toonLinksOnder();
            toonOnder();
            toonRechtsOnder();
        }

        // positie print methodes
        internal void toonRechts()
        {
            if (steen % 10 != 0)
            {
                Console.WriteLine(steen + 1);
            }
            else
            {
                foutmelding();
            }
        }

        internal void toonLinks()
        {
            if (steen != 1 || steen % 11 != 0)
            {
                Console.WriteLine(steen - 1);
            }
            else
            {
                foutmelding();
            }
        }

        internal void toonBoven()
        {
            if (steen > 10)
            {
                Console.WriteLine(steen - 10);
            }
            else
            {
                foutmelding();
            }
        }

        internal void toonOnder()
        {
            if (steen <= 90)
            {
                Console.WriteLine(steen + 10);
            }
            else
            {
                foutmelding();
            }
        }

        internal void toonRechtsBoven()
        {
            if (steen > 10 && steen % 10 != 0)
            {
                Console.WriteLine(steen - 9);
            }
            else
            {
                foutmelding();
            }
        }

        internal void toonRechtsOnder()
        {
            if (steen < 90 && steen % 10 != 0)
            {
                Console.WriteLine(steen + 11);
            }
            else
            {
                foutmelding();
            }
        }

        internal void toonLinksBoven()
        {
            if (steen > 10 && steen % 11 != 0)
            {
                Console.WriteLine(steen - 11);
            }
            else
            {
                foutmelding();
            }
        }

        internal void toonLinksOnder()
        {
            if (steen < 90 && steen % 11 != 0)
            {
                Console.WriteLine(steen + 9);
            }
            else
            {
                foutmelding();
            }
        }
    }
}