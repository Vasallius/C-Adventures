using System;

namespace MonthsoftheYear
{   
    enum Months { January = 1, February = 2, March = 3, April = 4, May = 5, June = 6, July = 7,
                    August = 8, September = 9, October = 10, November = 11, December = 12}
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number: ");
            int userinput = Convert.ToInt32(Console.ReadLine());

            Months today = (Months)userinput;

            Console.WriteLine(today);
        }
    }
}
