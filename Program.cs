using System;

namespace RedditNumberGeneratorRefactor
{
    class Program
    {
        static int goal = 300000;
        static void Main()
        {
            var numberGen = new Random();
            var randomValue = numberGen.Next(1, 347500);

            var count = 0;
            do
            {
                count++;

                if (randomValue >= goal)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                Console.WriteLine(randomValue);
                randomValue = numberGen.Next(1, 347500);
              
                
            }
            while (randomValue < goal);


            Console.WriteLine("\nit took you " + count + " tries to get number " + randomValue);


        }
    }
}
