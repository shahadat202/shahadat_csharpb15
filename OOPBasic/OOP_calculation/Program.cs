using System;
using System.Collections.Generic;
namespace practice
{
    class OOPBasic
    {

        static void Main(string[] args)
        {
            calculation calculation = new calculation();



            int sum1 = calculation.Add(5, 6);
            Console.WriteLine("Sum of a and b is: " + sum1);

            double sum2 = calculation.Add(5.5, 7.6);
            Console.WriteLine("Sum of c and d is: " + sum2);

            string s = calculation.Add("Shahadat ", "Hossain");
            Console.WriteLine("Concatenated string: " + s);
        }
    }
}

