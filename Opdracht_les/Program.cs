using System;

namespace Opdracht_les
{
    class Program
    {
        static void Main(string[] args)
        {
            Wiskunde wiskunde = new Wiskunde("Simon", 17, "Zo Leer Je Wiskunde");
            Frans frans = new Frans("Patrick", 11, "Dit is Frans");

            wiskunde.WiskundeLeren();
            frans.FransLeren();
            frans.huiswerkMaken();
        }
    }
}
