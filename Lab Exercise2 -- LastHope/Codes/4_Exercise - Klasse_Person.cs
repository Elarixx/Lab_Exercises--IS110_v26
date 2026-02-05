using System;

namespace LastHope;

    // Kjør øvelse 4: opprett en Person og skriv ut data
    internal static class Exercise4
    {
        public static void Run()
        {

            // ======================================================
            // Lager ny Person og fyller feltene
            // ======================================================

                    var person = new Person
                        {
                            ID = 77,
                            Name = "Saylor Sinclair",
                            BirthDate = new DateOnly(2174, 07, 07),
                            Address = "Alpha sector 7, 7777 Pandora Moon"
                        };

                     person.PrintInfo(); // Skriv ut all info for personen
        }
    }
            // ==========================================================
            // Enkel modell for en Person-klassen
            // ==========================================================
                    internal class Person
                        {
                            public int ID { get; set; }                      // Unik identifikator
                            public string Name { get; set; } = string.Empty; // Personens navn
                            public DateOnly BirthDate { get; set; }          // Fødselsdato
                            public string Address { get; set; } = string.Empty; // Adresse


                            // Skriver personinformasjon til konsollen
                            public void PrintInfo()
                            {
                                Console.WriteLine(
                                    $"ID: {ID}\n" +
                                    $"Name: {Name}\n" +
                                    $"Birthday: {BirthDate:dd.MM.yyyy}\n" +
                                    $"Address: {Address}\n");

                                //Kan også skrives slik:
                                    /* Console.WriteLine($"ID: {ID}");
                                    Console.WriteLine($"Navn: {Name}");
                                    Console.WriteLine($"Fødselsdato: {BirthDate:dd.MM.yyyy}");
                                    Console.WriteLine($"Adresse: {Address}");
                                    Console.WriteLine(); */
    }
}