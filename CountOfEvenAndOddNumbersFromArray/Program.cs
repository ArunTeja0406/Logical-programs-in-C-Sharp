using System.Diagnostics.Tracing;

namespace CountOfEvenAndOddNumbersFromArray
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

            CountOfEvenOdd(arr);
        }
        public static void CountOfEvenOdd(int[] arr)
        {
            int evenCount = 0;
            int oddCount = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    evenCount++;
                }
                else
                {
                    oddCount++;
                }
            }

            Console.WriteLine($"Even count: {evenCount}, Odd count: {oddCount}");
        }
    }
}