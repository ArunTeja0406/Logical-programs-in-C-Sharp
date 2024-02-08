namespace PrintPatternwithNumbers_n_m_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the No. row value: ");
            int NoOfRows = int.Parse(Console.ReadLine());

            for (int row = 1; row <= NoOfRows; row++)
            {
                for (int column = 1; column <= row; column++)
                {
                    Console.Write(column + " ");    // to print same number in row use this: Console.Write(row + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
/*
1
1 2
1 2 3
1 2 3 4
1 2 3 4 5
*/