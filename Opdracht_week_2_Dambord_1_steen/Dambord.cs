using System;
namespace Opdracht_week_2_Dambord_1_steen
{
    public class Dambord : EigenInvulling
    {
        // Declarations
        private int steen;
        private readonly int size;
        private int linksboven;
        private int boven;
        private int rechtsboven;
        private int links;
        private int rechts;
        private int linksonder;
        private int onder;
        private int rechtsonder;

        // Constructor
        public Dambord(int steen = 4, int size = 3)
        {
            this.steen = steen;
            this.size = size;
            this.dambord = MaakDambord(this.size);
            this.coordinaten = ZoekSteenPositie(this.size, this.steen);
        }

        public void finePrint()
        {
            this.toonLinksBoven();
            this.toonBoven();
            this.toonRechtsBoven();
            this.toonLinks();
            Console.WriteLine("huidig: \t{0}", steen);
            this.toonRechts();
            this.toonLinksOnder();
            this.toonOnder();
            this.toonRechtsOnder();

            Console.WriteLine("\n{0} \t{1} \t{2} \n{3} \t{4} \t{5} \n{6} \t{7} \t{8}",
                              linksboven,
                              boven,
                              rechtsboven,
                              links,
                              steen,
                              rechts,
                              linksonder,
                              onder,
                              rechtsonder);
        }


        // Methodes voor bepalen positie steen
        public void toonRechts()
        {
            if (coordinaten[1] < this.size - 1)
            {
                this.rechts = this.dambord[coordinaten[0], coordinaten[1] + 1];
                Console.WriteLine("Rechts: \t{0}", rechts);
            }
            else
            {
                Console.WriteLine("Rechts: \tx");
            }
        }
        public void toonLinks()
        {
            if (coordinaten[1] > 0)
            {
                this.links = this.dambord[coordinaten[0], coordinaten[1] - 1];
                Console.WriteLine("Links: \t \t{0}", links);
            }
            else
            {
                Console.WriteLine("links: \t\tx");
            }
        }
        public void toonBoven()
        {
            if (coordinaten[0] > 0)
            {
                this.boven = this.dambord[coordinaten[0] - 1, coordinaten[1]];
                Console.WriteLine("Boven: \t \t{0}", boven);
            }
            else
            {
                Console.WriteLine("Boven: \t\tx");
            }
        }
        public void toonOnder()
        {
            if (coordinaten[0] < this.size - 1)
            {
                onder = this.dambord[coordinaten[0] + 1, coordinaten[1]];
                Console.WriteLine("Onder: \t \t{0}", onder);
            }
            else
            {
                Console.WriteLine("Onder: \t\tx");
            }
        }
        public void toonRechtsBoven()
        {
            if ((coordinaten[0] > 0) && (coordinaten[1] < this.size - 1))
            {
                rechtsboven = this.dambord[coordinaten[0] - 1, coordinaten[1] + 1];
                Console.WriteLine("Rechtsboven: \t{0}", rechtsboven);
            }
            else
            {
                Console.WriteLine("Rechtsboven: \tx");
            }
        }
        public void toonLinksBoven()
        {
            if ((coordinaten[0] > 0) && (coordinaten[1] > 0))
            {
                linksboven = this.dambord[coordinaten[0] - 1, coordinaten[1] - 1];
                Console.WriteLine("Linksboven: \t{0}", linksboven);
            }
            else
            {
                Console.WriteLine("Linksboven: \tx");
            }
        }
        public void toonRechtsOnder()
        {
            if ((coordinaten[0] < this.size - 1) && (coordinaten[1] < this.size - 1))
            {
                rechtsonder = this.dambord[coordinaten[0] + 1, coordinaten[1] + 1];
                Console.WriteLine("Rechtsonder: \t{0}", rechtsonder);
            }
            else
            {
                Console.WriteLine("Rechtsonder: \tx");
            }
        }
        public void toonLinksOnder()
        {
            if ((coordinaten[0] < this.size - 1) && (coordinaten[1] > 0))
            {
                linksonder = this.dambord[coordinaten[0] + 1, coordinaten[1] - 1];
                Console.WriteLine("Linksonder: \t{0}", linksonder);
            }
            else
            {
                Console.WriteLine("Linksonder: \tx");
            }
        }
    }
}
