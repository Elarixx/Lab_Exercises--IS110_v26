using System;

namespace Lab_Exercise4.Codes
{
    /*
    ----- Øvelse 4: Design en klasse Employee for et HR-system. -----

        Klassen skal ha:
          - Ansattnummer
          - Navn
          - Månedslønn

        Krav:
          - Ansattnummer skal ikke kunne endres etter at objektet er opprettet
          - Månedslønn skal ikke kunne endres direkte utenfra klassen
          - Alle data skal være tilgjengelige for lesing der det er fornuftig
          - Bruk auto-implementerte egenskaper
     */
    internal class Exercise4
    {
        // "Internal" gjør at egenskapene i klassen ikke er tilgjengelige utenfor dette prosjektet.
        internal class Employee
        {
            // Auto-implementerte egenskaper med tilgangsmodifikatorer
            public int EmployeeID { get; } // Ansattnummer kan ikke endres etter objektet er opprettet. Kan kun leses utenfra klassen.
            public string Name { get; set; } // Navn kan leses og endres utenfra klassen.
            public int MonthlySalary { get; private set; } // Månedslønn kan leses, men ikke endres direkte utenfra klassen.
        }
    }
}
