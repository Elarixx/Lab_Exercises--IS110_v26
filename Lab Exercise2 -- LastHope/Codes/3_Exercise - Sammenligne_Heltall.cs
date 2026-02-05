using System; // Brukes for Console

namespace LastHope;
    internal static class Exercise3
    {
        // Kjør øvelse 3: sammenligne to heltall
        public static void Run()
        {


            // ==========================================================
            // Deklarer to heltallsvariabler
            // ==========================================================

                /* Velger å bruke tall_1 og tall_2 istedenfor tall1 og tall2 for egen lesbarhet.*/

                    int tall_1 = 77;
                    int tall_2 = 24;


            // ==========================================================
            // Sammenligne tallene og skriv ut resultatet
            // ==========================================================
        
                  /* Bruker if-else betingelser for å sammenligne tallene og skrive ut riktig melding */

                    if (tall_1 > tall_2)    // Hvis tall_1 er større enn tall_2, skriv ut at tall_1 er større.
                        {
                          Console.WriteLine($"{tall_1} er større enn {tall_2}");
                        }            
                    else if (tall_1 < tall_2)   // Hvis tall_1 er mindre enn tall_2, skriv ut at tall_1 er mindre.
                        {
                          Console.WriteLine($"{tall_1} er mindre enn {tall_2}");
                        }
                    else  // Hvis ingen av "if" eller "else if", tallen er like.
                        {
                          Console.WriteLine($"{tall_1} og {tall_2} er like");
                        }
        }
    }
