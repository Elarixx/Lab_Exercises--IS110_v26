using System; // Brukes for Console og double.NaN

namespace LastHope;

    internal class Exercise1
{
        // Kjør øvelse 1: variabler og aritmetikk
        public static void Run()
        {

        // ==========================================================
        // Deklarasjon og initiering av variabler
        // ==========================================================

            // pris_lego: pris i kroner for en LEGO
            int pris_lego = 300;
                 Console.WriteLine($"Prisen på Lego er {pris_lego} kr."); // Bruker 'strenginterpolasjon' ($ og {} for lettere skriving.
                        // Kan også skrives slik: Console.WriteLine("Prisen på Lego er: " + pris_lego + " kr.\n");

            // pris_pokemonfigur: pris i kroner for en pokemonfigur
            int pris_pokemonfigur = 500;                
                 Console.WriteLine($"Prisen på Pokemonfigur er {pris_pokemonfigur}\n"); // Bruker 'strenginterpolasjon' ($ og {} for lettere skriving.
                        // Kan også skrives slik: Console.WriteLine("Prisen på Pokemonfigur er: " + pris_pokemonfigur + " kr.\n");

        // ==========================================================
        // Regn ut og skriv ut resultater
        // ==========================================================    

                // sum: addisjon av prisene
                int sum = pris_lego + pris_pokemonfigur;
                        // Skriver ut summen til konsollen
                        Console.WriteLine($"• Summen av prisen for lego og pokemonfigur er {sum} kr\n");


                // difference: subtraksjon (pokemonfigur - lego)
                int difference = pris_pokemonfigur - pris_lego;
                    // Skriver ut differansen til konsollen
                    Console.WriteLine($"• Differansen mellom prisen for pokemonfigur og lego er {difference} kr\n");


                // product: multiplikasjon av prisene
                int product = pris_lego * pris_pokemonfigur;
                    // Skriver ut produktet til konsollen
                    Console.WriteLine($"• Produktet(/resultatet av multiplikasjon) av prisen for lego og pokemonfigur er {product} kr\n");


                // division: deling som double for å bevare desimaler
                double division = (double)pris_pokemonfigur / pris_lego;
                    // Skriver ut kvotienten til konsollen
                    Console.WriteLine($"• Kvotienten(/resultatet av divisjon) av prisen for pokemonfigur og lego er {division} kr\n");
        }
    }