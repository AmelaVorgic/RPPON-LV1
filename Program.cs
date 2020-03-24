using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labos1
{
    /*Zadatak 3.
      Napravite tri zabilješke koristeći različite konstruktore. Ispišite autore i tekst zabilješki.*/
    /*Zadatak 7.
      Kreirajte objekt navedene klase i
      napunite svoju ToDo listu zabilješkama čije ćete vrijednosti unijeti s konzole (barem tri). Nakon toga
      ispišite sadržaj ToDo liste na ekran, obavite sve zadatke s najvišom razinom prvenstva i ponovno
      ispišite sadržaj ToDo liste. */
    class Program
    {
        static void Main(string[] args)
        {
            Note first = new Note();
            Note second = new Note("This note has a message!");
            Note third = new Note("I know that I know nothing!", "Socrates", 1);

            Console.WriteLine(first.getAuthor());
            Console.WriteLine(first.getText());

            Console.WriteLine(second.getAuthor());
            Console.WriteLine(second.getText());

            Console.WriteLine(third.getAuthor());
            Console.WriteLine(third.getText());

            Console.WriteLine(first.ToString());
            Console.WriteLine(second.ToString());


            TimeStampedNote NewNote = new TimeStampedNote("Now you know what time it is!", "Student", 2);

            NewNote.ToString();
            Console.WriteLine(NewNote);

            ToDo MyList = new ToDo(3);

            Console.WriteLine(MyList.ToString());

            MyList.FinishNote();

            Console.WriteLine(MyList.ToString());

            Console.ReadKey();
        }
    }
}
