using System;

namespace LogicalProgram
{
    class factorial
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter the input: ");
            int input = int.Parse(Console.ReadLine());

            int FactResult = 1;

            for (int i = 1; i <= input; i++)
            {
                FactResult = FactResult * i;

            }
            Console.WriteLine(FactResult);
        }
    }
}