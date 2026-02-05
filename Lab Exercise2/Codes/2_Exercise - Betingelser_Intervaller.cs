using System; // Brukes for Console

namespace LastHope;

internal static class Exercise2
{
    // Kjør øvelse 2: sjekk om en dag (1-7) er arbeidsdag, helg eller ugyldig
    public static void Run()
    {

        // ==========================================================
        // Deklarerer en heltallsvariabel som representerer en dag i uken (1-7).
        // ==========================================================
        
                int dag = 2; // Endre verdien for å teste andre dager.

    //----------------------------------------------------------------------------------\\

        // Bruker if-else for å avgjøre dagtype og skrive ut riktig melding.
        if (dag >= 1 && dag <= 5) // '&&' betyr "og": begge betingelser må være sanne.
        {
            // Dag 1–5 (mandag–fredag) → arbeidsdag
            Console.WriteLine("Arbeidsdag");
        }
        else if (dag == 6 || dag == 7) // '||' betyr "eller": minst én må være sann.
        {
            // Dag 6 eller 7 (lørdag/søndag) → helg
            Console.WriteLine("Helg");
        }
        else
        {
            // Alt annet enn 1–7 → ugyldig dag
            Console.WriteLine("Ugyldig dag");
        }

    }
}