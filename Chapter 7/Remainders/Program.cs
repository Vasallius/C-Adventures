using System;

namespace Remainders
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;
            int quotient = 17 / 4;
            int remainder = 17 % 4;
            Console.WriteLine("17/4 is 4 remainder " + remainder);

            int dividend = b * quotient + remainder;

            Console.WriteLine(dividend);
        }
    }
}
