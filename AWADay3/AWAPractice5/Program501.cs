using System;

namespace AWAPractice5
{
    class Program501
    {
        static void Main(string[] args)
        {
            
            int j = 0;
            try
            {
                Console.Write("Enter a number between 1 and 100: ");
                j = int.Parse(Console.ReadLine());
                if (j < 1 || j > 100)
                {
                    Console.WriteLine("Your number must be at least 1 and not higher than 100.");
                }
                else
                {
                    do
                    {
                        Console.WriteLine(j);
                        j++;
                    } while (j <= 100);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("You must enter an integer between 1 and 100.");
            }
        }
    }
}
