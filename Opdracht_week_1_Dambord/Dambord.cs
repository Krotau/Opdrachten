using System;
namespace Opdracht_week_1_Dambord
{
    public class Dambord
    {
        // Declarations
        private int steen;
        private int dambord;

        public Dambord(int steen = 1, int dambord = 100)
        {
            this.steen = steen;
            this.dambord = dambord;

            // testen
            zetSteen(15);
            toonRechts();
            toonLinks();
            toonOnder();
            toonBoven();
            toonLinksBoven();
            toonLinksOnder();
            toonRechtsBoven();
            toonRechtsOnder();
        }


        // Steen informatie methodes
        internal void zetSteen(int positie)
        {
            if (positie > 0 && positie <= 100)
            {
                steen = positie;
            }
            else
            {
                Console.WriteLine("Buiten bereik!");
            }
        }

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
            if (steen > 10){
                Console.WriteLine(steen - 10);
            }
            else{
                foutmelding();
            }
        }

        internal void toonOnder()
        {
            if (steen <= 90){
                Console.WriteLine(steen + 10);
            }
        }

        internal void toonRechtsBoven()
        {
            throw new NotImplementedException();
        }

        internal void toonRechtsOnder()
        {
            throw new NotImplementedException();
        }

        internal void toonLinksBoven()
        {
            throw new NotImplementedException();
        }

        internal void toonLinksOnder()
        {
            throw new NotImplementedException();
        }

        // als iets niet kan wat opgevangen is
        private void foutmelding()
        {
            throw new NotImplementedException();
        }
    }
}