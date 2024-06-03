using System;
using System.Collections.Generic; // Behöver för att använda listor
using System.Linq; // Behöver för att använda min func. med listor

namespace Uppgift1
{
    class Program1
    {
        static void Main(string[] args)
        {
            // While loop villkor för att kunna forsätta att spela en gång till
            bool playAgain;

            // Att spela in spelomgång
            List<int> spelomgång = new List<int>();

            do
            {
                // Skapa slumpmässigt nummer
                Random random = new Random();
                int randomvalue = random.Next(101);

                // Välkomna spelaren, inledning
                Console.WriteLine("\nGissa talet\nDu ska nu gissa ett tal mellan 1 och 100, så varsågod..\nSkriv in ett tal");

                // Hur många gånger gissades
                int gissning_kvar = 10;

                // deklaranten gissning
                int gissning;

                do
                {
                    // Att gissa
                    gissning = Convert.ToInt16(Console.ReadLine());

                    // Gränsen om gissning och hemligt nummer är nära
                    int närhetsgräns = 10;
                    int skillanden = Math.Abs(randomvalue - gissning);

                    // Om man gissar rätt
                    if (gissning == randomvalue)
                    {
                        Console.WriteLine($"Grattis! Du har gissat prick rätt siffran!\nDu har gissat {11 - gissning_kvar} gånger\n\n");
                        // Spela in hur många gånger gissade spelaren
                        spelomgång.Add(11 - gissning_kvar);
                        break; // Exit the loop if the guess is correct
                    }

                    // Kolla om gissning är mellan 0-100
                    else if (gissning < 0 || gissning > 100)
                    {
                        Console.WriteLine("Du måste skriva in ett tal mellan 1 och 100!");
                    }

                    // Om gissningen är större
                    else if (gissning > randomvalue)
                    {
                        // Om skillnaden mellan gissning och hemligt sifran är mindre än 10
                        if (skillanden <= närhetsgräns)
                        {
                            Console.WriteLine("Ditt tal är för stort. Gissa på ett mindre tal.\nDu är dock nära och det bränns.\n");
                        }
                        // Om skillnaden mellan gissning och hemligt sifran är större än 10
                        else
                        {
                            Console.WriteLine("Ditt tal är för stort. Gissa på ett mindre tal\n");
                        }
                    }

                    // Om gissning är mindre
                    else
                    {
                        // Om skillnaden mellan gissning och hemligt sifran är mindre än 10
                        if (skillanden <= närhetsgräns)
                        {
                            Console.WriteLine("Ditt tal är för litet. Gissa på ett större tal.\nDu är dock nära och det bränns.\n");
                        }
                        // Om skillnaden mellan gissning och hemligt sifran är större än 10
                        else
                        {
                            Console.WriteLine("Ditt tal är för litet. Gissa på ett större tal\n");
                        }
                    }

                    // Att minska gissning kvar
                    gissning_kvar--;

                    // Att kolla om max gissning nådde
                    if (gissning_kvar == 0)
                    {
                        Console.WriteLine("Tyvärr, du har inga gissningar kvar. Det hemliga talet var: " + randomvalue + "\n\n");
                        break; // Exit the loop if no guesses left
                    }
                    // Kolla varje gång om gissning och hemligt siffran är samma
                } while (gissning != randomvalue);

                // Man får spela en gång till eller sluta spelan efter varje gång
                Console.WriteLine("Vill du spela igen? Tryck 'p' för att spela igen eller någåt annat för att avsluta.");
                string userInput = Console.ReadLine().ToLower();
                playAgain = userInput == "p";

            } while (playAgain);

            // Om man inte väljer "p" att spela en gång till

            // Att kontrollera om det finns något inspelat i spelet runt listan, om spelaren inte kunde gissa rätt bara en gång, skulle listan vara tom
            if (spelomgång.Any())
            {
                // Att hitta den minsta siffran
                int recordet = spelomgång.Min();

                // Output the smallest integer
                Console.WriteLine($"Rekordet för att gissa rätt minsta gången är '{recordet}' gånger!");
            }

            Console.WriteLine("Tack för att du spelade!");
        }
    }
}
