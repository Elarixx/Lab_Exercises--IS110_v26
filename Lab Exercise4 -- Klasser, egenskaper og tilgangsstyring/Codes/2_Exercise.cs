using System;

namespace Lab_Exercise4.Codes
{
    /*
    ----- Øvelse 2: Lag en klasse UserAccount som representerer en bruker i et system. -----

        Klassen skal ha:
          - Brukernavn
          - Passord
          - Dato for opprettelse

        Krav:
          - Bruk auto-implementerte egenskaper
          - Bruk tilgangsmodifikatorer slik at:
             - Brukernavn kan leses utenfra, men ikke endres
             - Passord ikke kan leses eller endres direkte utenfra klassen
          - Lag minst én metode som på en kontrollert måte endrer passordet
    */

    internal class Exercise2
    {
        // "Public" gjør at alle egenskapene er tilgjengelige utenfor denne klassen.
        // Dette er en auto-implementerte egenskaper, som betyr at kompilatoren automatisk lager en privat backing field for hver egenskap.
        public class UserAccount
        {
            // Auto-implementerte egenskaper med tilgangsmodifikatorer
            public string Username { get; } // Brukernavn kan KUN leses utenfra klassen
            private string? Password { get; set; } // Passord er privat og kan ikke leses eller endres direkte utenfra klassen
            public DateTime dateCreated { get; } // Dato (DateTime) for opprettelse av brukerkontoen kan KUN leses utenfra klassen


            // ----------------------------------------------------------
            // Metode for å endre passordet på en kontrollert måte
            // ----------------------------------------------------------
                public bool ChangePassword(string currentPassword, string newPassword) // Metode for å endre passord
                {
                    if (currentPassword != Password || string.IsNullOrWhiteSpace(newPassword)) // Sjekker om nåværende passord er korrekt og at det nye passordet ikke er tomt eller bare mellomrom
                    {
                        return false; // Returnerer false hvis sjekken feiler
                }

                    Password = newPassword; // Oppdaterer passordet hvis sjekken er vellykket
                    return true; // Returnerer true for å indikere at passordet ble endret
                }
        }
    }
}
