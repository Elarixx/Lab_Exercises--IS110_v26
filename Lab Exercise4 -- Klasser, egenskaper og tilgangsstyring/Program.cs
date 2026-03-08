using Lab_Exercise4.Codes;
using System;

namespace Lab_Exercise4
{
    internal class Program
    {
        static void Main()
        {

        // ====================================
        // Introduksjon  ↓
        // ====================================
            Console.WriteLine("=== Lab Exercise 4: Klasser, egenskaper og tilgangsstyring ===\n");

        // --------------------------------------------------
        // Øvelse 1: Book  ↓
        // --------------------------------------------------
            Console.WriteLine("Øvelse 1");
                var book = new Exercise1.Book
                {
                    Title = "To Kill a Mockingbird",
                    Author = "Harper Lee",
                    YearPublished = 1960
                };
            Console.WriteLine($"Tittel på boka: {book.Title},\n Forfatter: {book.Author},\n År utgitt: {book.YearPublished}\n");

        // --------------------------------------------------
        // Øvelse 2: UserAccount  ↓
        // --------------------------------------------------
            Console.WriteLine("Øvelse 2");
                var account = new Exercise2.UserAccount("Aurora", "letsgooo345");
                var changed = account.ChangePassword("letsgooo345", "nyttPassord!");
            Console.WriteLine($"Bruker: {account.Username},\n Passord endret: {changed}\n");

        // --------------------------------------------------
        // Øvelse 3: ConfigurationManager  ↓
        // --------------------------------------------------
            Console.WriteLine("Øvelse 3");
                var config = new Exercise3.ConfigurationManager
                {
                    ApplicationName = "LabApp",
                    VersionNumber = "1.0.0"
                };
            Console.WriteLine($"App: {config.ApplicationName},\n Versjon: {config.VersionNumber}\n");

        // --------------------------------------------------
        // Øvelse 4: Employee  ↓
        // --------------------------------------------------
            Console.WriteLine("Øvelse 4");
                var employee = new Employee("Aurora", 52000m);
                var authoriser = new Employee("HR", 6000m);
                employee.ChangeSalary(54000, authoriser);
            Console.WriteLine($"Ansatt: {employee.Name},\n ID: {employee.EmployeeID},\n Lønn: {employee.MonthlySalary:C}\n");
    }
    }
}
