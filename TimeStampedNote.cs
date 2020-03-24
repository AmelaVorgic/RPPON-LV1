using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Zadatak 6.
Kreirajte vlastitu klasu koja predstavlja bilješku s dodanim vremenom, a koja nasljeđuje osnovnu
klasu koja predstavlja bilješku. Za pohranu vremena koristiti objekt DateTime klase,
podrazumijevano vrijeme za kreiranje objekta je trenutno vrijeme, a omogućiti i postavljanje vremena
na novom objektu i promjenu vremena na postojećem objektu. Preopteretite metodu ToString() tako
da zna prikazati i vrijeme bilješke.*/
namespace Labos1
{
    class TimeStampedNote : Note
    {
        private DateTime time;
        public void setTime(DateTime time) { this.time = time; }
        public void RealTime() { this.time = DateTime.Now; }

        public TimeStampedNote(string author, string text, int priority) : base(author, text, priority)
        {
            this.time = DateTime.Now;
        }
        public TimeStampedNote(string author, string text, int priority, DateTime time) : base(author, text, priority)
        {
            this.time = time;
        }

        public override string ToString()
        {
            return this.Author + " says: " + this.Text + " At: " + this.time + ". Priority of this note is " + this.Priority + ".";
        }

    }
}