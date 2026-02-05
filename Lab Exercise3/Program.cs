using System;

namespace Lab_Exercise3
{
    internal class Program
    {

        // Program entry point: kaller hver øvelse for å demonstrere temaene én etter én.
        static void Main()
        {
            // ====================================
            // Introduksjon  ↓
            // ====================================
                Styles.WriteSeparator();                 // Pusterom over løsningstittel
                Styles.WriteTitle("Lab Exercise 3"); // Skriver ut teksten/tittelen med fet skrift og '====' som understrek
                Console.WriteLine();                     // Lite mellomrom

                Styles.WriteSeparator();                 // Pusterom
                Styles.WaitForNext("Øvelse 1", addLeadingBlank: false); // Vis melding (styles.cs) og vent på tast før øvelse 1 (uten ekstra tom linje)
                Styles.WriteSeparator();                 // Pusterom før øvelse 1


            // =========================================================================================================
            // Kjører Øvelse 1 – Personregister
            // =========================================================================================================
                Styles.WriteHeading("Øvelse 1 – Personregister"); // Skriver overskrift for øvelse 1
                    Exercise1.Run();                     // Kjører øvelse 1
                Styles.WaitForNext("Øvelse 2");          // Prompt før øvelse 2
                Styles.WriteSeparator();                 // Pusterom

            // =========================================================================================================
            // Kjører Øvelse 2 – Arithmetic Mattekalkulator
            // =========================================================================================================
                Styles.WriteHeading("Øvelse 2 – Arithmetic Mattekalkulator"); // Skriver overskrift for øvelse 2
                    Exercise2.Run();                     // Kjører øvelse 2
                Styles.WaitForNext("Øvelse 3");          // Prompt før øvelse 3
                Styles.WriteSeparator();                 // Pusterom

            // =========================================================================================================
            // Kjører Øvelse 3 – Oddetall eller Partall sjekk
            // =========================================================================================================
                Styles.WriteHeading("Øvelse 3 – Oddetall eller Partall sjekk"); // Skriver overskrift for øvelse 3
                    Exercise3.Run();                     // Kjører øvelse 3
                Styles.WaitForNext("Øvelse 4");          // Prompt før øvelse 4
                Styles.WriteSeparator();                 // Pusterom


            // =========================================================================================================
            // Kjører Øvelse 4 - Student karakter kalkulator
            // =========================================================================================================
                Styles.WriteHeading("Øvelse 4 – Student karakter kalkulator"); // Skriver overskrift for øvelse 4
                    Exercise1.Run();                     // Kjører øvelse 1
                Styles.WaitForNext("avslutning");        // Prompt før avslutning
                Styles.WriteSeparator();                 // Avsluttende pusterom


            // ====================================
            // Avslutning  ↓
            // ====================================
                Console.WriteLine("Trykk en tast for å avslutte..."); // Avsluttende melding
                Console.ReadKey(); // Venter på at brukeren trykker en tast før programmet avsluttes
        }
    }
} 