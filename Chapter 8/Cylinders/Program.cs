using System;

namespace Cylinders
{
    class Program
    {
        static void Main(string[] args)
        {
            var h = Convert.ToInt32(Console.ReadLine());
            var r = Convert.ToInt32(Console.ReadLine());
            var pi = 3.1415926;

            var volume = pi * r * r * h;
            var surfacearea = 2 * pi * r * (r + h);

            Console.WriteLine(volume);
            Console.WriteLine(surfacearea);
        }
    }
}
