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
            var n02 = n01;

            var count = 1;
            do
            {

                Console.WriteLine(n01);
                if (n01 == goal)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                n02 = n01;
                n01 = numberGen.Next(1, 347500);
                
                if (n02 != n01)
                {
                    count++;
                }
              
                
            }
            while (n01 < goal);


            Console.WriteLine("\nit took you " + count + " tries to get number " + n01);


        }
    }
}
