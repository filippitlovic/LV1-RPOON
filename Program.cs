using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV1_RPOON_ZADACI
{
    class Program
    {
        static void Main(string[] args)
        {
            Note note;

            /// prvi objekt pomocu 1. konstruktora
            note = new Note();
            Console.WriteLine(note.getAuthorName());
            Console.WriteLine(note.getNoteText());
            Console.WriteLine("\n");

            // drugi objekt pomocu 2. konstruktora
            note = new Note("Ivan", "Danas su laboratorijske vježbe", 2);
            Console.WriteLine(note.getAuthorName());
            Console.WriteLine(note.getNoteText());
            Console.WriteLine("\n");


            // treći objekt
            note = new Note("Pada snijeg", 3);
            Console.WriteLine(note.getAuthorName());
            Console.WriteLine(note.getNoteText());


            
        }
    }
}
