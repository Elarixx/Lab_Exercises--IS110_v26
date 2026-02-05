using System;

namespace Lab_Exercise3
{
    /*
     ---- Øvelse 4: ----
    Opprett en klasse og kall den "Student" som et institutt kan bruke til å representere informasjon som instansvariabler: 
        - studentId (type string)
        - studentNavn (type string)  
        - tre separate variabler for poengsummer i tre fag (type decimal). 

    Klassen din bør ha en konstruktør som initialiserer de fem verdiene. 
        - Opprett Set og Get metoder for alle instansvariabler. 
        - Oprett også metoder "GetAggregate()" og "GetPercentage()" som beregner de samlede poengsummene i 
        de tre fagene (summen av tre fagpoengsummer) og prosentandelen (dvs. sum delt på maksimumspoengsummen, 60, og deretter multiplisert med 100), 
        og returner deretter aggregatet og prosentandelen som desimalverdi. 

    Skriv en kode i Program.cs som demonstrerer klassens Student-evner.
     */

    internal class Exercise4
    {
        public class Student
        {
          // =============================================================
          // Instansvariabler (private = kun tilgjengelig inne i klassen)
          // =============================================================
            private string studentID; // Studentens ID-nummer
            private string studentName; // Studentens navn
            private decimal subject_1; // Poengsum i fag 1
            private decimal subject_2; // Poengsum i fag 2
            private decimal subject_3; // Poengsum i fag 3

          // =============================================================
          // Konstruktør – kjøres når vi lager en ny Student
          // =============================================================
              // Tar imot verdier og setter dem til instansvariablene.
              public Student(string id, string name, decimal sub1, decimal sub2, decimal sub3)
                {
                    studentID = id; // Setter studentID til verdien vi sender inn.
                    studentName = name; // Setter studentName til verdien vi sender inn.
                    subject_1 = sub1; // Setter subject_1 til verdien vi sender inn.
                    subject_2 = sub2; // Setter subject_2 til verdien vi sender inn.
                    subject_3 = sub3; // Setter subject_3 til verdien vi sender inn.
                }

          // =============================================================
          // GET metode – Returnerer verdien (henter verdien ut)
          // =============================================================
              public string GetStudentID() 
                { 
                    return studentID; // returnerer studentID
                }    
              public string GetStudentName() 
                { 
                    return studentName; // returnerer studentName
                }    
              public decimal GetSubject1()
                { 
                    return subject_1; // returnerer subject_1
                }    
              public decimal GetSubject2()
                { 
                    return subject_2; // returnerer subject_2 
                }    
              public decimal GetSubject3()
                { 
                    return subject_3; // returnerer subject_3
                }    

          // =============================================================
          // SET metode – Setter ny verdien (endrer verdien)
          // =============================================================
             public void SetStudentID(string id) 
                { 
                    studentID = id; // endrer studentID til ny verdi
                }    
              public void SetStudentName(string name) 
                { 
                    studentName = name; // endrer studentName til ny verdi
                }    
              public void SetSubject1(decimal sub1) 
                { 
                    subject_1 = sub1; // endrer subject_1 til ny verdi
                }    
              public void SetSubject2(decimal sub2) 
                { 
                    subject_2 = sub2; // endrer subject_2 til ny verdi
                }    
              public void SetSubject3(decimal sub3) 
                { 
                    subject_3 = sub3; // endrer subject_3 til ny verdi
                }

            // =============================================================
            // Regning av fagpoengsummer og prosentandel
            // =============================================================
               /* GetAggregate = regner ut summen av alle 3 fag */
               public decimal GetAggregate()
                {
                    decimal sum = subject_1 + subject_2 + subject_3; // Legger sammen alle tre poengsummene
                    return sum; // Returnerer summen
                }

               /* GetPercentage = regner ut prosentansdelen av de 3 fagene */
               public decimal GetPercentage()
                {
                    decimal aggregate = GetAggregate(); // Bruker 'GetAggregate()' for å få summen
                    decimal percentage = (aggregate / 60) * 100; // Finner ut av prosentandelen ved å dele på maks (60) og ganger med 100
                    return percentage; // Returnerer prosentandelen
                }         
        }


            // ===========================================================
            // Demo-kjøring for Student-klassen (kalles fra Program.cs)
            // ===========================================================
            public static void Run()
            {
                Console.WriteLine("Øvelse 4: Student Klasse Demo\n");

                // Lager én student med eksempelpoeng
                Student student = new Student("X127", "Saylor Sinclaire", 20, 18, 17);

                // Skriver ut all informasjon
                Console.WriteLine($"ID: {student.GetStudentID()}");
                Console.WriteLine($"Name: {student.GetStudentName()}");

                Console.WriteLine($"Fag 1: {student.GetSubject1()}");
                Console.WriteLine($"Fag 2: {student.GetSubject2()}");
                Console.WriteLine($"Fag 3: {student.GetSubject3()}");
                Console.WriteLine($"Summen av de 3 fagene: {student.GetAggregate()}");
                Console.WriteLine($"Prosentandelen av de 3 fagene: {student.GetPercentage}");
            }
    }
}
