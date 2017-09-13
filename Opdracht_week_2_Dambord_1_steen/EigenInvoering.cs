using System;
namespace Opdracht_week_2_Dambord_1_steen
{
    public class EigenInvulling
    {
        // declarations
        internal int[,] dambord;
        internal int[] coordinaten;

        public EigenInvulling()
        {
        }

		// maakt het dambord, duh
		public int[,] MaakDambord(int size)
		{
			int[,] bord = new int[size, size];
			int iterator = 0;
			for (int laag = 0; laag < size; laag++)
			{
				for (int positie = 0; positie < size; positie++)
				{
					bord[laag, positie] = iterator; iterator++;
				}

			}
            return bord;

		}

		// dambord kent alleen getal, niet de plek in het twee dimensionaal array 'dambord'
		public int[] ZoekSteenPositie(int size, int steen)
		{
			int iterator = 0;
			int[] rv = new int[2];

			for (int laag = 0; laag < size; laag++)
			{
				for (int positie = 0; positie < size; positie++)
				{
					if (dambord[laag, positie] == steen)
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

    }

}
