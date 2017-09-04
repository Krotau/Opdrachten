using System;

namespace Opdrachten
{
    class Program
    {
        static void Main(string[] args)
        {
            Robot bixby = new Robot();

            bixby.gaNaarBestemming(5);
            bixby.gaNaarBestemming(10);
            bixby.gaNaarBestemming(0);
            bixby.gaNaarBestemming(-5);

        }
    }
}
