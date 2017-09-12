using System;
namespace Opdracht_week_2_Dambord_1_steen
{
    public class Dambord
    {
        // Declarations
        private int steen;
        private int[] steenInfo;
        private readonly int size;
        private int[,] dambord;

        // Constructor
        public Dambord(int steen = 23, int size = 5)
        {
            this.steen = steen;
            this.size = size;

            MaakDambord();
            steenInfo = ZoekSteenPositie();
        }

        // maakt het dambord, duh
        public void MaakDambord()
        {
            this.dambord = new int[this.size, this.size];
            int iterator = 0;
            for (int laag = 0; laag < size; laag++)
            {
                for (int positie = 0; positie < size; positie++)
                {
                    this.dambord[laag, positie] = iterator; iterator++;
                }

            }

        }

        // dambord kent alleen getal, niet de plek in het twee dimensionaal array 'dambord'
        public int[] ZoekSteenPositie()
        {
            int iterator = 0;
            int[] rv = new int[2];

            for (int laag = 0; laag < size; laag++)
            {
                for (int positie = 0; positie < size; positie++)
                {
                    if (dambord[laag, positie] == this.steen)
                    {
                        rv[0] = laag;
                        rv[1] = positie;
                        return rv;
                    }
                    else
                    {
                        iterator++;
                    }

                }

            }
            return rv;
        }
        // Methodes voor bepalen positie steen
    }

}
