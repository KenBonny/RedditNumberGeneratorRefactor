using System;

namespace RedditNumberGeneratorRefactor
{
    class Program
    {
        static int goal = 300000;
        static void Main()
        {
            var numberGen = new Random();
            int randomValue;

            var count = 0;
            do
            {
                count++;

                randomValue = numberGen.Next(1, 347500);
                if (randomValue >= goal)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                Console.WriteLine(randomValue);
            }
            while (randomValue < goal);


            Console.WriteLine("\nit took you " + count + " tries to get number " + randomValue);


        }
    }
}
