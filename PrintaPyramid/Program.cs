using System;

namespace PrintaPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
          
            int x = 4;
            int y = 1;

            for (int row = 1; row <= 5; row++)
            {
                for (int spaces = 1; spaces <= x; spaces++)
                {
                    Console.Write(" ");
                    
                }

               for (int stars = 1; stars <= y; stars ++)
                {
                    Console.Write("*");
                }

                for (int spaces = 1; spaces <= x; spaces++)
                {
                    Console.Write(" ");

                }
                Console.WriteLine();
                y += 2;
                x -= 1;

            }

            

        }
    }
}
