using System;

namespace Lab_Exercise3
{
    /*
    ---- Øvelse 3: ----
        Skriv en kode som tar inn en integer (heltall) verdi fra brukeren og sjekker om tallet er oddetall eller partall. 
        Koden skal skrive ut en melding til brukeren at tallet er oddetall eller partall.  
    */

    internal class Exercise3
    {

        public static void Run()
        {
            // =================================================
            // Ber bruker om et heltall (integer)
            // =================================================
                Console.WriteLine("Welcome!\nPlease enter a whole number (integer):"); // Skriver melding til consolen.

            // =================================================
            // Sjekker om tallet er oddetall eller partall
            // =================================================
                while (true) // While-løkke som lar brukeren prøve på nytt fram til betingelsen (if) er møtt.
                {
                    Console.Write(">>>> "); // Ber brukeren skrive på samme linje som prompten.
                    string? input = Console.ReadLine(); // Leser inputen fra brukeren. // string? betyr at verdien kan være ubesvart.

                    if (int.TryParse(input, out int inputNumber)) // Sjekker om inputen er et heltall. 
                    {
                        string parity = inputNumber % 2 == 0 ? "even" : "odd"; // Sjekker om input-tallet er "odd" or "even". // Hvis det går an å dele på 2 -> "even", hvis ikke -> "odd". // parity = the property of an integer of whether it is even or odd.
                        Console.WriteLine($"\nYour number {inputNumber} is {parity}!"); // Skriver ut resultatet.
                            //Console.ReadKey();
                            break; // Avslutter While-løkken.
                    }
                    else // Hvis betingelsen (if) ikke er møtt, fortsetter løkken.
                    {
                        Console.WriteLine("\nInvalid input! Please enter a whole number (integer)."); // Skriver ut melding til consolen.
                    }
                }
        }
    }
}
