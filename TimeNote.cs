using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//6. zadatak
/*Kreirajte vlastitu klasu koja predstavlja bilješku s dodanim vremenom, a koja nasljeđuje osnovnu
klasu koja predstavlja bilješku. Za pohranu vremena koristiti objekt DateTime klase,
podrazumijevano vrijeme za kreiranje objekta je trenutno vrijeme, a omogućiti i postavljanje vremena
na novom objektu i promjenu vremena na postojećem objektu. Preopteretite metodu ToString() tako
da zna prikazati i vrijeme bilješke.*/

namespace LV1_RPOON_ZADACI
{
    class TimeNote : Note
    {
        DateTime time = DateTime.Now;

        public TimeNote(string authorName, string textNote, int note_LevelOfImportance, DateTime time)
            : base(authorName, textNote, note_LevelOfImportance)
        {
            this.time = time;
        }


        public DateTime timeChanger

        {
            get { return this.time; }
            set { this.time = value; }
        }


        public override string ToString()
        {
            return base.ToString() + "date:" + this.time;
        }
    }
}
