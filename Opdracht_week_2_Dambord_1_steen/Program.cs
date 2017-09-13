using System;

namespace Opdracht_week_2_Dambord_1_steen
{
    class Program
    {
        static void Main(string[] args)
        {
            Dambord Dambord = new Dambord(14567, 5000);
            Console.WriteLine("Steen zit op laag: {0} en positie: {1}",Dambord.coordinaten[0], Dambord.coordinaten[1]);

            Dambord.finePrint();
        }
    }
}
