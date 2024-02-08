using System;

namespace SumOfArrayElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the array size: ");
            int size = int.Parse(Console.ReadLine());

            int[] arr = new int[size];

            Console.WriteLine("Enter the array elements");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int result = sumOfElements(arr);
            Console.WriteLine($"Sum of array elements = {result}");
        }

        public static int sumOfElements(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
    }
}