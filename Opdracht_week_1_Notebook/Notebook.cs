using System;
namespace Opdracht_week_1_Notebook
{
    public class Notebook
    {
        // declarations
        private ArrayList notes = new ArrayList();

        // constructor
        public Notebook()
        {
            voegDataToe();
            printeAlleNotities();
            verwijderTweedeNotitie();
            printeAlleNotities();

            Console.WriteLine(totaalAantalNotities());
            Console.WriteLine(showNote());
        }

        private string showNote()
        {
            return "nog niet geimplementeerd";
        }

        private int totaalAantalNotities()
        {
            return notes.Count;
        }

        private void verwijderTweedeNotitie()
        {
            notes.remove(1);
        }

        private void printeAlleNotities()
        {
            foreach (var note in notes)
            {
                Console.WriteLine(note);
            }
        }

        private void voegDataToe()
        {
            notes.add("Dit is mijn eerste notitie!");
            notes.add("Dit is mijn tweede notitie!");
            notes.add("Dit is mijn derde notitie!");
            notes.add("Dit is mijn vierde notitie!\n");
        }


    }
}
