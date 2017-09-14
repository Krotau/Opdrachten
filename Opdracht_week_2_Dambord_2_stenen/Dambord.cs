using System;

namespace Opdracht_week_2_Dambord_2_stenen
{
    public class Dambord
    {
        private int[,] dambord;
        private readonly int size;
        private readonly int steen1;
        private readonly int steen2;


        // Constructur
        public Dambord(int steen1, int steen2, int size)
        {
            this.steen1 = steen1;
            this.steen2 = steen2;
            this.size = size;
        }
    }
}
