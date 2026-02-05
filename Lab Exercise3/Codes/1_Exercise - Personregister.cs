using System;
using System.Collections.Generic;

namespace Lab_Exercise3 {


    /*
      -- Øvelse 1:  
       Basert på programmet vi skrev sammen i forrige forelesningen, så skal du utvide koden sånn at 
       den tar inndata fra brukeren og lager så mange objekter av type person som brukeren vil til at brukeren gir beskjed "exit". 
       Da stopper applikasjonen ved "exit" beskjed og ender med å skrive ut en melding til brukeren som for eksempel "slutt!" eller noe lignende.
    */


    internal class Person   // Denne klassen representerer Person
    {
        public string Username { get; set; }    // lagrer brukernavnet som blir skrivet inn av brukeren.

        public Person(string username)  // tar brukernavnet inn.... forstår ikke??
        {
            Username = username;    // setter feltet til verdien fra parameteren.... forsår ikke???
        }

        public override string ToString()   // Gir en tekstlig representasjon av objektet..... forstår ikke??
        {
            return Username;    // returnerer brukernavnet som en streng.  Streng = bare tekst/ord, ingen tegn eller tall
        }
    }



    internal class Exercise1     // denne klassen representerer selve øvelsen
    {
        public static void Run()    // Programmet starter med denne koden.
        {
            // Gjør det mulig å bruke symbol.
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Lager en liste som samler alle registrerte personer.
                List<Person> people = new List<Person>();

                   /* Console.WriteLine("Welcome! Write a username to register a new person.");  // Velkomstmelding til brukeren.
                        string? UserInput = Console.ReadLine(); // Leser første input (kun én gang)
                        if (!string.IsNullOrWhiteSpace(UserInput))  // Sjekker at første input er gyldig
                        {
                            string trimmed = UserInput.Trim();  // Trimmer første input
                            if (!string.Equals(trimmed, "exit", StringComparison.OrdinalIgnoreCase)) // Hvis ikke exit
                            {
                            Person firstPerson = new Person(trimmed);   // Oppretter første person
                            people.Add(firstPerson);    // Legger til første person
                            Console.WriteLine("Legger til person.");    // Bekrefter
                                Console.WriteLine();    // Luft
                            }
                            else
                            {
                                // Hvis bruker skrev exit med en gang, hopp til slutten
                                Console.WriteLine("Slutt. Registrerte:");
                                foreach (Person p in people)
                                {
                                    Console.WriteLine(p);
                                }
                                return;
                            }
                        }
                        else
                        {
                        Console.WriteLine("Ugyldig");   // Første input var tom/whitespace
                        Console.WriteLine();            // Luft før vi går inn i løkken
                        }
                                */

            // While Loop: Lager objekter frem til bruker gir beskjed "exit".
            while (true)    // evig løkke, kjører til den blir brutt.
            {
                // Spør bruker om Ny Person, eller om de vil avslutte.
                    Console.WriteLine("Write the new usename (or write 'exit' to end the program): ");  // ber om input.
                    Console.Write("➺  ");
                    
                    string? UserInput = Console.ReadLine(); // Leser inn videre brukerinput.

                if (string.IsNullOrWhiteSpace(UserInput))   // Avviser hvis input er tom eller bare mellomrom.
                {
                    Console.WriteLine("Ugyldig input. Prøv på nytt.");
                    continue; // Fortsetter til neste "loop" uten å legge til en person.
                }

                string trimmed = UserInput.Trim(); // Fjerner unødvendige mellomrom fra starten og slutten av inputen.

                if (string.Equals(trimmed, "exit", StringComparison.OrdinalIgnoreCase))  // Sjekker om brukeren skrev "exit".
                {
                    break; // Bryter løkken og avslutter programmet.
                }


                Person person = new Person(trimmed); // Oppretter ny Person som bruker skrev inn.

                people.Add(person); // Legger til den nye personen i listen over registrerte personer.
                Console.WriteLine("Legger til ny bruker."); // Bekrefter at personen er lagt til.
                Console.WriteLine(); // Skriver ut en tom linje for bedre lesbarhet.
            }

            // Skriver: 
            Console.WriteLine("\nAvslutter programmet.\nHer er registrerte brukernavn: "); // Skriver at øvelsen er ferdig. og viser alle brukernavn som har blitt opprettet.
            foreach (Person p in people) // Går gjennom alle registrerte brukernavn.
            {
                Console.WriteLine(p); // Skriver ut hver person (ToString -> brukernavn).
            }

        }
    }
}
