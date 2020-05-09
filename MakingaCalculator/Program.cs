using System;

namespace MakingaCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my simple calculator! ");
            Console.Write("Enter first number: ");
            float num1 = Convert.ToSingle(Console.ReadLine()); 
            Console.Write("Enter second number: ");
            float num2 = Convert.ToSingle(Console.ReadLine());
            Console.Write("Enter operation symbol: ");
            string operation = Console.ReadLine();

            switch (operation)
            {
                case "+":
                    Console.WriteLine("You chose addition.");
                    float sum = num1 + num2;
                    Console.WriteLine(sum);
                    break;

                case "-":
                    Console.WriteLine("You chose substraction.");
                    float difference = num1 - num2;
                    Console.WriteLine(difference);
                    break;

                case "*":
                    Console.WriteLine("You chose multiplication.");
                    float product = num1 * num2;
                    Console.WriteLine(product);
                    break;

                case "/":
                    Console.WriteLine("You chose divsion.");
                    float quotient = num1 / num2;
                    Console.WriteLine(quotient);
                    break;

                case "^":
                    Console.WriteLine("You chose raising to the power of.");
                    double exponentproduct = Math.Pow(num1, num2);
                    Console.WriteLine(exponentproduct);
                    break;
            }

            Console.WriteLine("Thank you for using my calculator!");
        }
    }
}
