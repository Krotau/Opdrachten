using System;

namespace Opdrachten
{
    class Program
    {
        static void Main(string[] args)
        {
            Robot Bixby = new Robot();

            Bixby.gaNaarBestemming(5);
            Bixby.gaNaarBestemming(10);
            Bixby.zetRichting(9);
            Bixby.gaNaarBestemming(0);
            Bixby.gaNaarBestemming(-5);

        }
    }
}
