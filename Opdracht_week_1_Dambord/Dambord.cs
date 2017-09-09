using System;
namespace Opdracht_week_1_Dambord
{
    public class Dambord
    {
        // Declarations
        private int steen;

        public Dambord(int steen = 1)
        {
            this.steen = steen;
        }


        // Steen informatie methodes
        internal void zetSteen(int positie)
        {
            throw new NotImplementedException();
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
            if (steen != 1 || steen % 11 != 0){
                Console.WriteLine(steen - 1);
            }
        }

        internal void toonBoven()
        {
            throw new NotImplementedException();
        }

        internal void toonOnder()
        {
            throw new NotImplementedException();
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