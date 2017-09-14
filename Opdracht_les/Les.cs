using System;
namespace Opdracht_les
{
    public abstract class Les
    {
        protected string naam;
        protected string leraar;
        protected int aantalLeerlingen;

        public void huiswerkMaken()
        {
            Console.WriteLine("De leerlingen maken huiswerk.\n");
        }
    }
}
