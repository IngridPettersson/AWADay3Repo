using System;

namespace AWAPractice402
{
    class Program
    {
        static void Main(string[] args)
        {
            // …där användaren får mata in ett tal mellan 1 och 100. Programmet skriver sedan ut alla tal
            // utifrån angivet tal upp till 100.Om tal utanför 1 till 100 matas in, avslutas programmet.

            Console.Write("Enter a number between 1 and 100: ");
            bool isNumber = int.TryParse(Console.ReadLine(), out int i);

            if (isNumber && i >= 1 && i <= 100)
            {
                while (i <= 100)
                {
                    Console.WriteLine(i);
                    i++;

                }
            }

        }
    }
}
