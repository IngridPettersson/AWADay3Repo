using System;

namespace AWAPractice4Extra
{
    class ProgramExtra
    {
        static void Main(string[] args)
        {
            //1. …med hjälp av en do...while loop skriver ut alla tal mellan 1 och 20

            //2. …där användaren får mata in ett tal mellan 1 och 100.Programmet skriver sedan ut alla tal
            //utifrån angivet tal upp till 100.Om tal utanför 1 till 100 matas in, avslutas programmet.

            int i = 1;
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i <= 20);

            Console.ReadLine();
            Console.Clear();

            Console.Write("Enter a number between 1 and 100: ");
            bool isNumber = int.TryParse(Console.ReadLine(), out int j);

            if (isNumber && j >= 1 && j <= 100)
            {
                do
                {
                    Console.WriteLine(j);
                    j++;
                } while (j <= 100);
            }
        }
    }
}
