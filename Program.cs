using System;

namespace RedditNumberGeneratorRefactor
{
    class Program
    {
        static int n01;
        static int n02;
        static int count;
        static int a;
        static int goal = 300000;
        static void Main()
        {
            number();
         
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


            Console.WriteLine("\nit took you " + count + " tries to get number " + n01);


        }
        static void number()
        {
            Random numberGen = new Random();
            n01 = numberGen.Next(1, 347500);
            if (n02 != n01)
            {
                count++;
            }
            if (a == 0)
            {
                n02 = n01;
                a++;
            }
        }
    }
}
