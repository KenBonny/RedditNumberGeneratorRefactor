using System;

namespace RedditNumberGeneratorRefactor
{
    class Program
    {
        static int goal = 300000;
        static void Main()
        {
            var numberGen = new Random();
            var n01 = numberGen.Next(1, 347500);

            var count = 0;
            do
            {
                count++;

                Console.WriteLine(n01);
                if (n01 == goal)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                n01 = numberGen.Next(1, 347500);
              
                
            }
            while (n01 < goal);


            Console.WriteLine("\nit took you " + count + " tries to get number " + n01);


        }
    }
}
