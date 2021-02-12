using System;

namespace RedditNumberGeneratorRefactor
{
    class Program
    {
        static int n01 = 0;
        static int n02 = 0;
        static int x = 0;
        static int y = 0;
        static int a = 0;
        static int goal = 300000;
        static void Main(string[] args)
        {
            if (y == 0)
            {
                number();
            }
            do
            {

                Console.WriteLine(n01);
                if (n02 != n01)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(n01 + " ");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                if (n01 == goal)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                n02 = n01;
                number();
                
              
                
            }
            while (n01 < goal);


            Console.WriteLine("\nit took you " + x + " tries to get number " + n01);
            Console.ReadKey();


        }
        static void number()
        {
            y = 1;
            
            Random numberGen = new Random();
            n01 = numberGen.Next(1, 347500);
            if (n02 != n01)
            {
                x++;
            }
            if (a == 0)
            {
                n02 = n01;
                a++;
            }
            else if (a != 0)
            {
                
            }
        }
    }
}
