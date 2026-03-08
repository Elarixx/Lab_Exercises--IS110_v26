using System;

namespace Lab_Exercises___IS110_v26.Lab_Exercise5___.Codes
{
    /*
    ---- Øvelse 1: ----

      ⨠ Opprette en array av type int med minst 10 tall
        
      ⨠ Bruk en for løkke til å:
          - Skrive ut alle tallene
          - Beregne summen av tallene

      ⨠ Bruk en foreach løkke til å:
          - Finne det største tallet i arrayen
     */

    internal class _1_Exercise
    {
        public static void Run()
        {
            //===============================================================================
            // ------- Opprette en array av type int med minst 10 tall -------
            //===============================================================================

                int[] numbers = { 6, 7, 2, 1, 7, 8, 0, 9, 3, 7 };
                int sum = 0; // Variabel for å holde summen av tallene. Starter summen på 0.


            //===========================================================================
            // ------- Beregner summen av tallene ved hjelp av en for-løkke ------
            //===========================================================================

                for (int i = 0; i < numbers.Length; i++) // For-løkke som itererer gjennom hvert tall i arrayen.
                {
                    sum += numbers[i]; // Legger til det nåværende tallet i summen
                }

                Console.WriteLine("Summen av tallene er: " + sum); // Skriver ut summen av tallene


            //====================================================================================
            // ------- Finne det største tallet i arrayen ved hjelp av en foreach-løkke ------
            //====================================================================================

                int biggest = int.MinValue; // Starter på laveste mulige verdi for å sikre at alle tall i arrayen vil være større verdi.

                foreach (int value in numbers) // Går gjennom hvert tall i arrayen.
                {
                    if (value > biggest) // Sjekker om det nåværende tallet er større enn det største tallet vi har funnet så langt.
                    {
                        biggest = value; // Oppdaterer 'biggest' hvis det nåværende tallet er større.
                    }

                    Console.WriteLine("Det største tallet i arrayen er: " + biggest); // Skriver ut det største tallet funnet i arrayen.
                }
        }
    }
}
