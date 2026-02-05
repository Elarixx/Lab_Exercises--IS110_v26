using LastHope;
using System;
using System.Text;

namespace Lab_Exercise2 
{
    internal class Program
    {
        
        // Program entry point: kaller hver øvelse for å demonstrere temaene én etter én.
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8; // Sikrer at Unicode-tegn (f.eks. punktlister) vises riktig i konsollen


        // --------------------------------------------------
        // Introduksjon  ↓
        // --------------------------------------------------

            Styles.WriteSeparator();                 // Pusterom over løsningstittel
            Styles.WriteTitle("Solution: LastHope"); // Skriver ut teksten/tittelen med fet skrift og '====' som understrek
            Console.WriteLine();                     // Lite mellomrom

            Styles.WriteSeparator();                 // Pusterom
            Styles.WaitForNext("Øvelse 1", addLeadingBlank: false); // Vis melding (styles.cs) og vent på tast før øvelse 1 (uten ekstra tom linje)
            Styles.WriteSeparator();                 // Pusterom før øvelse 1


        // --------------------------------------------------
        // Øvelse 1: Variabler og aritmetikk  ↓
        // --------------------------------------------------

            Styles.WriteHeading("Øvelse 1 – Variabler og aritmetikk"); // Skriver overskrift for øvelse 1
                Exercise1.Run();                     // Kjører øvelse 1
            Styles.WaitForNext("Øvelse 2");          // Prompt før øvelse 2
            Styles.WriteSeparator();                 // Pusterom


        // --------------------------------------------------
        // Øvelse 2: Betingelser (if/else) med intervaller  ↓
        // --------------------------------------------------

            Styles.WriteHeading("Øvelse 2 – Betingelser (if/else) med intervaller"); // Skriver overskrift for øvelse 2
                Exercise2.Run();                     // Kjører øvelse 2
            Styles.WaitForNext("Øvelse 3", addLeadingBlank: true);  // Vis melding og vent på tast før øvelse 3 (med ekstra tom linje først)
            Styles.WriteSeparator();                 // Pusterom


        // --------------------------------------------------
        // Øvelse 3: Sammenligne to heltall  ↓
        // --------------------------------------------------

            Styles.WriteHeading("Øvelse 3 – Sammenligne to heltall"); // Skriver overskrift for øvelse 3
                Exercise3.Run();                         // Kjører øvelse 3
            Styles.WaitForNext("Øvelse 4", addLeadingBlank: true); // Prompt med ekstra linje
            Styles.WriteSeparator();                 // Pusterom


        // --------------------------------------------------
        // Øvelse 4: Klasse: Person  ↓
        // --------------------------------------------------

            Styles.WriteHeading("Øvelse 4 – Klasse: Person"); // Skriver overskrift for øvelse 4
                Exercise4.Run();                         // Kjører øvelse 4
            Styles.WaitForNext("avslutning");        // Prompt før avslutning
            Styles.WriteSeparator();                 // Avsluttende pusterom


        // --------------------------------------------------
        // Avslutning  ↓
        // --------------------------------------------------

            Console.WriteLine("Trykk en tast for å avslutte..."); // Avsluttende melding
            Console.ReadKey(); // Venter på at brukeren trykker en tast før programmet avsluttes
        }
    }
}
