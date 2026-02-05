using System;

namespace Lab_Exercise4.Codes
{
    /*
    ----- Øvelse 1: Lag en klasse som representerer en Book. -----

        Klassen skal ha: 
          - Tittel
          - Forfatter
          - Utgivelsesår

        Krav: 
          - Bruk auto-implementerte egenskaper
          - Alle egenskapene skal være tilgjengelige utenfra klassen
          - Klassen skal kunne brukes fra Program.cs
    */

    internal class Exercise1
    {
        // "Public" gjør at alle egenskapene er tilgjengelige utenfor denne klassen.
        // Dette er en auto-implementerte egenskaper, som betyr at kompilatoren automatisk lager en privat backing field for hver egenskap.
        public class Book
        {
            /* Alle er offentlig auto-implementerte egenskaper
                * "get/set" lager og bruker et automatisk felt */
            public string Title { get; set; } // Hva gjør denne linjen?
            public string Author { get; set; } // Hva gjør denne linjen?
            public int YearPublished { get; set; } // Hva gjør denne linjen?
        }
    }
}
