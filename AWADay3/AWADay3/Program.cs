using System;

namespace AWADay3
{
    class Program
    {
        static void Main(string[] args)
        {

            // Modulus in game

            bool done = false;
            int round = 1;

            while (!done)
            {
                Console.WriteLine($"Round {round}: Player {(round % 4) + 1} shall roll the dice.");
                round++;
                done = round > 25;
                Console.ReadKey(true);
            }


            //double a = 10.10;
            //double b = 3.30;
            //double rest = a % b;

            //Console.WriteLine(rest);
        }
    }
}
