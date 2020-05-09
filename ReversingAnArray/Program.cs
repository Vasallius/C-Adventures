using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ReversingAnArray
{
    class Program
    {
        static void Main(string[] args)
        {

            int [] damn2 = Genar(); //damn exists
            Reverse(damn2);
            foreach(int item in damn2)
            {
                Console.WriteLine(item);
            }
        }

        static int[] Genar()
        {
            int[] damn = new[] { 1, 2, 3, 4, 5, 6 };
            return damn;
        }

        static int[] Reverse(int [] damn2)
        {
            int firstindex = 0;
            int secondindex = 5;

            while (firstindex < secondindex)
            {
                int temp = damn2[firstindex];
                damn2[firstindex] = damn2[secondindex];
                damn2[secondindex] = temp;

                firstindex ++;
                secondindex--;
            }
            

            return damn2;
            
        }
    }
}
