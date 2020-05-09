using System;

namespace PositiveorNegative
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 2 numbers:");

            var num1 = Convert.ToInt32(Console.ReadLine());
            var num2 = Convert.ToInt32(Console.ReadLine());

            if ((num1 > 0 && num2 < 0) || (num1 < 0 && num2 > 0))
            {
                Console.WriteLine("Result is a negative integer");
            }
            else
            {
                Console.WriteLine("Result is a positive integer");
            }
        }
    }
}
