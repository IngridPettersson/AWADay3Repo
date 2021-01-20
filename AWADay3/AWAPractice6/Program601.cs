using System;
using System.Collections.Generic;

namespace AWAPractice6
{
    class Program601
    {
        static void Main(string[] args)
        {
            // Ge användaren alternativen.
            // Sätta de olika alternativen som variabler.
            // Göra ett switch statement för varje alternativ och vad som då ska hända.
            // varför loop??

            //            …med hjälp av en switch sats skapar en inmatningsmeny för en bankomat. Alternativen ska
            //            vara:
            //            [I]nsättning
            //            [U]ttag
            //            [S]aldo
            //            [A]vsluta

            Console.WriteLine("Jag är din bank. Tryck på motsvarande tanget som du ser inom hakparentes för det du önskar göra.\n");
            Console.WriteLine("[I]nsättning");
            Console.WriteLine("[U]ttag");
            Console.WriteLine("[S]aldo");
            Console.WriteLine("[A]vsluta");
            Console.WriteLine();
            ConsoleKeyInfo input = Console.ReadKey();

            List<ConsoleKeyInfo.Key> validKeys = new List<ConsoleKeyInfo.Key>();
            validKeys.Add(ConsoleKey.I);
            validKeys.Add(ConsoleKey.U);
            validKeys.Add(ConsoleKey.S);
            validKeys.Add(ConsoleKey.A);

            foreach (var key in validKeys)
            {
                switch ()
                {
                    case 1:
                        Console.WriteLine();
                        break;
                    default:
                        break;
                }
            }








        }
    }
}
