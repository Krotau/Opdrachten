using System;
using System.Collections.Generic;

namespace Opdracht_week_1_Notebook
{
    public class ArrayList : System.Collections.CollectionBase
    {
        // declarations
        public string name;

        // constructor
        public ArrayList()
        {
            Console.WriteLine("You just created a fabulous ArrayList, feel amazing!");
        }

        // Voeg iets toe aan array list
        // List is beschikbaar in context omdat ArrayList dit van CollectionBase heef inherit
        public void add(string note)
        {
            List.Add(note);
        }

        // verwijder een index in de lijst
        public void remove(int index)
        {
            if (index > Count - 1 || index < 0) // magische getallen anders doen
            {
                Console.WriteLine("Sorry, die bestaat niet!");
            }
            else
            {
                List.RemoveAt(index);
            }
        }
    }
}
