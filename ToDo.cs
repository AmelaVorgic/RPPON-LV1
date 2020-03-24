using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Zadatak 7.
Kreirajte klasu koja predstavlja ToDo listu koja omogućuje praćenje zadataka (zabilješki). Klasa
mora omogućiti dodavanje i uklanjanje (obavljanje) zadataka preko javnog sučelja, dohvaćanje
pojedinih bilješki te ispis cijele ToDo liste (ne vezati uz konzolu!). Kreirajte objekt navedene klase i
napunite svoju ToDo listu zabilješkama čije ćete vrijednosti unijeti s konzole (barem tri). Nakon toga
ispišite sadržaj ToDo liste na ekran, obavite sve zadatke s najvišom razinom prvenstva i ponovno
ispišite sadržaj ToDo liste. */
namespace Labos1
{
    class ToDo
    {
        private List<Note> toDo = new List<Note>();
        public List<Note> getToDo() { return toDo; }
        public void addNote(Note New) { this.toDo.Add(New); }
        public void generateToDoList(int members)
        {
            for (int i = 0; i < members; i++)
            {
                string author = Console.ReadLine();
                string text = Console.ReadLine();
                string priority = Console.ReadLine();

                Note New = new Note(author, text, Int16.Parse(priority));

                addNote(New);
            }
        }
        public ToDo(int members) { generateToDoList(members); }


        public void FinishNote()
        {
            for (int i = 0; i < this.toDo.Count; i++)
            {
                if (toDo[i].Priority == 1)
                {
                    this.toDo.RemoveAt(i);
                    Console.WriteLine("Just finished this note.");
                    i--;
                }
            }
        }
        public void SortByPriority()
        {
            for (int i = 0; i < this.toDo.Count - 1 - i; i++)
            {
                for (int j = 0; j < this.toDo.Count; j++)
                {
                    if (this.toDo[j].Priority > this.toDo[j + 1].Priority)
                    {
                        Note variable = new Note();
                        variable = this.toDo[j];
                        this.toDo[j] = this.toDo[j + 1];
                        this.toDo[j + 1] = variable;
                    }
                }
            }
        }


        public Note GetWantedNote(List<Note> toDo, int index)
        {
            return toDo[index];
        }

        public override string ToString()
        {
            string output = "";
            for (int i = 0; i < this.toDo.Count; i++)
            {
                output += this.toDo[i].ToString() + "\n";
            }

            return output;

        }

    }
}