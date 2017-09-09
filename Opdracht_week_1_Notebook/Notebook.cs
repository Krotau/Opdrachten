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
            voegDataToe("ik ben 1");
            voegDataToe("ik ben 2");
            voegDataToe("ik ben 3");
            voegDataToe("ik ben 4");

            printeAlleNotities();

            totaalAantalNotities();

            verwijderNotitie(2);

            printeAlleNotities();

            voegDataToe("ik ben 5");

            showNote(3);
        }

        private void showNote(int nummer)
        {
            Console.WriteLine(notes.laatNotitieZien(nummer)); 
        }

        private void totaalAantalNotities()
        {
            Console.WriteLine(notes.showTotal());
        }

        private void verwijderNotitie(int index)
        {
            notes.remove(index);
        }

        private void printeAlleNotities()
        {
            foreach (var note in notes)
            {
                Console.WriteLine(note);
            }
        }

        private void voegDataToe(string note)
        {
            notes.add(note);
        }


    }
}
