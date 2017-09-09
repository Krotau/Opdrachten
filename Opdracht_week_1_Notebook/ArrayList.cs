using System;
using System.Collections.Generic;

namespace Opdracht_week_1_Notebook
{
    public class ArrayList : System.Collections.CollectionBase// hiermee inherit je de basis lijst functionaliteit op
    {
        // declarations
        public string name;

        // constructor
        public ArrayList()
        {
            Console.WriteLine("You just created a fabulous ArrayList, feel amazing!\n");
        }

        internal string showTotal()
        {
            string rv = "Total number of notes is " + List.Count.ToString() + "\n";
            return rv;
        }

        // Voeg iets toe aan array list
        // List is beschikbaar in context omdat ArrayList dit van CollectionBase heef inherit
        public void add(string note)
        {
            List.Add(note);
        }

        internal string laatNotitieZien(int notitieNummer)
        {
            string rv = "The returned note: " + List[notitieNummer].ToString() + "\n";
            return rv;
        }

        // verwijder een index in de lijst
        // komt overeen met de removeat() methode dat inherit is
        public void remove(int index)
        {
            if (index > Count - 1 || index < 0) // magische getallen anders doen
            {
                Console.WriteLine("Sorry, die bestaat niet!\n");
            }
            else
            {
                List.RemoveAt(index);
                Console.WriteLine("Ik heb notitie {0} verwijderd\n", index+1);
            }
        }
    }
}