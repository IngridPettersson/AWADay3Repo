using System;

namespace AWAPractice6012
{
    class Program6012
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
            string input = Console.ReadLine().ToUpper();
            Console.Clear();

            switch (input)
            {
                case "I":
                    Console.WriteLine("Du vill göra en insättning.");
                    break;
                case "U":
                    Console.WriteLine("Du vill göra ett uttag.");
                    break;
                case "S":
                    Console.WriteLine("Du vill se ditt saldo. Eeeh, vill du verkligen det?");
                    break;
                case "A":
                    Console.WriteLine("Då avslutar vi.");
                    break;
                default:
                    break;
            }

        }
    }
}
