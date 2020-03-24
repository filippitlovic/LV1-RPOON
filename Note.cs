using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV1_RPOON_ZADACI
{
    class Note
    {
        //2. zadatak
        private String authorName;
        private String noteText;
        private int note_LevelOfImportance;



        public string getAuthorName() { return this.authorName; }
        public string getNoteText() { return this.noteText; }
        public int getNote_LevelOfImportance() { return this.note_LevelOfImportance; }

        private void setAuthorName(string authorName) { this.authorName = authorName; }
        public void setNoteText(string noteText) { this.noteText = noteText; }
        public void setNote_LevelOfImportance(int note_LevelOfImportance) { this.note_LevelOfImportance = note_LevelOfImportance; }


        ////4. zadatak
        public string AuthorName
        {
            get { return this.authorName; }
            private set { this.authorName = value; }
        }

        public string NoteText
        {
            get { return this.noteText; }
            set { this.noteText = value; }
        }

        public int Note_LevelOfImportance
        {
            get { return this.note_LevelOfImportance; }
            set { this.note_LevelOfImportance = value; }
        }


        ////////3. zadatak

        //1. nacin konstruktora
        public Note()
        {
            this.authorName = "Darko";
            this.noteText = "Danas je suncan dan";
            this.note_LevelOfImportance = 1;
        }
        //2. nacin konstruktora
        public Note(string authorName, string noteText, int note_LevelOfImportance)
        {
            this.authorName = authorName;
            this.noteText = noteText;
            this.note_LevelOfImportance = note_LevelOfImportance;
        }
        //3. nacin konstruktora

        public Note(string noteText, int note_LevelOfImportance)
        {
            this.authorName = "Ivan";
            this.noteText = noteText;
            this.note_LevelOfImportance = note_LevelOfImportance;
        }


        //  5.zadatak
        public override string ToString()
        {
            return this.authorName + "," + this.noteText;
        }
    }
}
