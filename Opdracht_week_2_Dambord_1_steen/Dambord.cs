using System;
namespace Opdracht_week_2_Dambord_1_steen
{
    public class Dambord
    {
        // Declarations
        private int steen;
        private int size;
        private int[,] dambord;

        public Dambord(int steen = 1, int size = 3)
        {
            this.steen = steen;
            this.size = size;

            maakDambord();
        }

        public void maakDambord()
        {
            dambord = new int[size+1, size];

            foreach (var layer in dambord)
            {
                Console.WriteLine(layer);
            }
        }

        // Methodes voor bepalen positie steen
        public void toonRechts()
        {
            throw new NotImplementedException();
        }
    }
}
