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

    // "Internal" gjør at egenskapene i klassen ikke er tilgjengelige utenfor dette prosjektet.
    internal class Employee
    {
        // Auto-implementerte egenskaper med tilgangsmodifikatorer
        public uint EmployeeID { get; init; } = (uint)Random.Shared.Next(); // Ansattnummer kan ikke endres etter objektet er opprettet. Kan kun leses utenfra klassen.
            /* 
             * uint = "Unsigned Integer". Et heltall som bare kan være positivt eller null (0 og oppover).
             * Random.Shared.Next() genererer automatisk et tilfeldig heltall. 
             * init = settes kun én gang (når objektet lages), kan ikke endres senere.
             */
        public string Name { get; set; } // Navn kan leses og endres utenfra klassen.
        public decimal MonthlySalary { get; private set; } // Månedslønn kan leses, men ikke endres direkte utenfra klassen.

        // Konstruktør for å opprette en ansatt med gyldige data
            // Konstruktør MÅ ha samme navn som klassen.
        public Employee(string name, decimal monthlySalary)
        {
            if (monthlySalary < 0)
            {
                Console.WriteLine($"{monthlySalary} cannot be negative.");
                return;
            }

            Name = name;
            MonthlySalary = monthlySalary;
        }

        // Metode for å endre månedslønnen på en kontrollert måte
        public void ChangeSalary(double newSalary, Employee authoriser)
        {
            // Sjekker om den som godkjenner har et navn (en enkel sikkerhetssjekk)
            if (string.IsNullOrEmpty(authoriser?.Name))
            {
                Console.WriteLine("Authoriser must have a valid name to change salary.");
                return;
            }

            // Sjekker at lønnen ikke er negativ
            if (newSalary < 0)
            {
                Console.WriteLine($"{newSalary} cannot be negative.");
                return;
            }

            // Hvis alt er OK, oppdaterer månedslønnen
            MonthlySalary = (decimal)newSalary;
            Console.WriteLine($"Salary for {Name} changed to {newSalary} by {authoriser.Name}.");
        }
    }
}
