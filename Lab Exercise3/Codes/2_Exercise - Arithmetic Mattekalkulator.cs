using System;

namespace Lab_Exercise3
{

        /*
            -- Øvelse 2: 
            ⫺ Basert på øvelse 1 i Lab øvelse 2, så skal du opprette en klasse og kalle den "MatteKlasse". 
            ⫺ Opprett metoder for hver matte operasjon. 
            ⫺ Opprett et objekt av klassen i Program.cs og utvid koden sånn at den tar inn verdiene av tallene og operasjonen fra brukeren. 
            ⫺ Kall metodene på objektet basert på operasjonen som brukeren gir til programmet.

                -- (Lab Øvelse 2 -> Øvelse 1: 
                ⫺ Deklarer to variabler med meningsfulle navn og tilpassede datatyper. 
                ⫺ Gjennomfør +, -, * og / operasjoner på de to variablene og legg resultatet i en variabel. 
                ⫺ Skriv ut resultatet.)
        */

    public class Exercise2
    {

        // ==========================================
        /* Startpunkt for Øvelse 2;
           'Program.cs' kaller denne metoden for å starte øvelsen. */
        // ==========================================
        public static void Run() // Bruker "Run" istedet for "Main" for at......
        {
            // Lager kalkulator-objektet for å utfører regnestykkene.
            MatteKlasse kalkulator = new MatteKlasse();

            // ==========================================================
            // Bruker input for Tall
            // ==========================================================
                
             /* ---- Første tall:  ---- */
                double tall_1;
                while (true)
                {
                    Console.WriteLine("Type the first number: "); // skrive melding til consolen.
                    string? input_1 = Console.ReadLine(); // leser tekst (string) fra brukeren; bruker '?' fordi 'ReadLine' kan gi null/ingen verdi. // Hvorfor 'string?' og ikke 'int?'? siden string er for tekst. og "input_1" vises ikke flere ganger i koden

                    if (double.TryParse(input_1, out tall_1)) break; // prøver å konvertere input til double <-- forstår ikke. // 'TryParse' validerer/konverterer til tall; '!' betyr at konvertering feilet.                    
                        Console.WriteLine("\nNot a valid number. Try again!\n"); // skriver melding til consolen.                    
                }

             /* ---- Andre tall:  ---- */
                double tall_2;
                while (true)
                {
                    Console.WriteLine("\nType the second number: "); // skrive melding til consolen.
                    string? input_2 = Console.ReadLine(); // leser tekst (string) fra brukeren; bruker '?' fordi 'ReadLine' kan gi null/ingen verdi. // Hvorfor 'string?' og ikke 'int?'? siden string er for tekst. og "input_1" vises ikke flere ganger i koden

                    if (double.TryParse(input_2, out tall_2)) break; // prøver å konvertere input til double <-- forstår ikke. // 'TryParse' validerer/konverterer til tall; '!' betyr at konvertering feilet.                    
                        Console.WriteLine("\nNot a valid number. Try again!\n"); // skriver melding til consolen.                        
                }
        

            // ==========================================================
            // Ber bruker om hvilken operasjon å bruke (+, -, *, /)
            // ==========================================================               
                string? operasjon;
                while (true)
                {
                    Console.WriteLine("\nChoose an Arithmetic Operator: +  -  *  / ");
                    operasjon = Console.ReadLine()?.Trim(); // Leser input/tekst fra bruker; '?' håndterer mulig null/tomt, 'Trim' fjerner ekstra mellomrom.
                    
                    if (operasjon is "+" or "-" or "*" or "/") break;
                        Console.WriteLine("\nInvalid operator. Use:  +  -  *  /  ");
                }

            // ==========================================================
            // Velger og Utfører Operasjon (if/else)
            // ==========================================================
                double resultat; // Lagrer svaret fra valgt regneoperasjon ↑; 'double' gir plass til desimaler.

                if (operasjon == "+") // velger denne hvis bruker valgte "+" som operasjon.
                {
                    resultat = kalkulator.Addition(tall_1, tall_2);
                }
                    else if (operasjon == "-") // velger denne hvis bruker valgte "-" som operasjon.
            {
                        resultat = kalkulator.Subtraction(tall_1, tall_2);
                    }
                    else if (operasjon == "*") // velger denne hvis bruker valgte "*" som operasjon.
            {
                        resultat = kalkulator.Multiplication(tall_1, tall_2);
                    }
                    else if (operasjon == "/") // velger denne hvis bruker valgte "/" som operasjon.
            {
                        resultat = kalkulator.Division(tall_1, tall_2);
                    }
            else // velger denne hvis bruker ikke valgte en gyldig operasjon
            {
                    Console.WriteLine("Invalid operator. Use  +  -  *  /");
                    return; // stopper ved ugyldig operasjon
                }

            // =================================================================
            // Annen måte å utføre på: Velger og Utfører Operasjon (Switch) 
            /* =================================================================

               // switch: velger gren basert på hvilken operator brukeren skrev.
               // ------------
                    switch (operasjon)
                    {
                        case "+":
                            resultat = kalkulator.Addition(tall_1, tall_2);
                            break;
                        case "-":
                            resultat = kalkulator.Subtraction(tall_1, tall_2);
                            break;
                        case "*":
                            resultat = kalkulator.Multiplication(tall_1, tall_2);
                            break;
                        case "/":
                            resultat = kalkulator.Division(tall_1, tall_2);
                            break;

                        default:
                            Console.WriteLine("Invalid operator. Use  +  -  *  /")
                            return; // avslutter når input ikke er gyldig.
                    }*/

            // Skriver ut resultatet
            Console.WriteLine($"\nResult: {tall_1} {operasjon} {tall_2} = {resultat}");
        }
    } 

    internal class MatteKlasse
    {
        // ==========================================================
        // Lager Metoder for hver matte operasjon
        // ==========================================================

            // Addisjon ( + )
           /* static void Addition()
            {
                Console.WriteLine(tall_1 + tall_2);
            } */
            public double Addition(double tall_1, double tall_2)
            {
                return tall_1 + tall_2;
            }
            
            public double Subtraction(double tall_1, double tall_2)
            {
                return tall_1 - tall_2;
            }

            public double Multiplication(double tall_1, double tall_2)
            {
                return tall_1 * tall_2;
            }

            public double Division(double tall_1, double tall_2)
            {
                if (tall_2 == 0) throw new DivideByZeroException("Cannot divide by zero.");
                return tall_1 / tall_2;
            }
    } 
}

