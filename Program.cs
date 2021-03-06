﻿using System;

namespace RedditNumberGeneratorRefactor
{
    class Program
    {
        private const int goal = 300000;

        static void Main()
        {
            var numberGen = new Random();
            int randomValue;
            bool goalReached;

            var count = 0;
            do
            {
                count++;

                randomValue = numberGen.Next(1, 347500);
                goalReached = randomValue >= goal;
                if (goalReached)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                Console.WriteLine(randomValue);
                Console.ForegroundColor = ConsoleColor.Black;
            }
            while (!goalReached);


            Console.WriteLine($"\nit took you {count} tries to get number {randomValue}");


        }
    }
}
