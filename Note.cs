using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labos1
{
    /*Zadatak 2.
    Kreirajte klasu koja predstavlja zabilješku.Klasa treba omogućiti bilježenje teksta zabilješke, autora
    zabilješke te razine važnosti zabilješke.Poštovati pravila enkapsulacije, a omogućiti izmjenu samo
    teksta i razine važnosti, jednom zadan autor ne smije se izmijeniti.*/

    /*Zadatak 3.
    Kreirajte konstruktore za zabilješke (barem tri konstruktora). */

    /*Zadatak 4.
    Izmijenite vlastitu klasu tako da uz pristupne metode za postavljanje i dohvaćanje sadrži i svojstva.
    Pripazite na prethodne zadatke i prava pristupa!*/

    /*Zadatak 5.
    Prepišite postojeću metodu i definirajte vlastitu ToString() metodu.*/

    class Note
    {
        private readonly String author;
        private String text;
        private int priority;

        public String getAuthor() { return this.author; }
        public String getText() { return this.text; }
        public int getPriority() { return this.priority; }

        public void setText(string text) { this.text = text; }
        public void setPriority(int priority) { this.priority = priority; }

        public string Author
        {
            get { return this.author; }
        }

        public string Text
        {
            get { return this.text; }
            set { this.text = value; }
        }

        public int Priority
        {
            get { return this.priority; }
            set { this.priority = value; }
        }

        public Note()
        {
            this.author = "Author is unknown";
            this.text = "Text of this message is unknown.";
            this.priority = 0;
        }

        public Note(string message)
        {
            this.author = "Author is unknown";
            this.text = message;
            this.priority = 0;
        }

        public Note(string author, string message)
        {
            this.author = author;
            this.text = message;
            this.priority = 0;
        }

        public Note(string author, string message, int priority)
        {
            this.author = author;
            this.text = message;
            this.priority = priority;
        }

        public override string ToString()
        {
            return this.author + ", " + this.text + " Priority of this note is " + this.priority + ".";
        }

    }
}
