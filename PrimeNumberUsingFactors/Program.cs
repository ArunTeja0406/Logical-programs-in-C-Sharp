using System;
using System.Collections.Generic;

namespace PrimeNumberUsingFactors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kindly enter the input value");
            int input = int.Parse(Console.ReadLine());

            List<int> result = findFactors(input);

            if (result.Count==2)
            {
                Console.WriteLine("Yes, given input is a prime number!");
            }
            else
            {
                Console.WriteLine("No, given input is not a prime number. Try again!");
            }
        }
       public static List<int> findFactors(int input)
        {
            List<int> list = new List<int>();
            for (int i = 1; i <= input; i++)
            {
                if (input % i == 0)
                {
                    list.Add(i);
                }
            }
            return list;
        }
    }
}