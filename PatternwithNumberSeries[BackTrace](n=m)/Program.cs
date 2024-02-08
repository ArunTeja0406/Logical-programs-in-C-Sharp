namespace PatternwithNumberSeries_BackTrace__n_m_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kindly enter the No. rows");
            int NoOfRow = int.Parse(Console.ReadLine());

            for (int row = 1; row <= NoOfRow; row++)
            {
                for (int column = row; column >=1; column--)
                {
                    Console.Write(column + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
/*
Pattern: 
1
2 1
3 2 1
4 3 2 1
5 4 3 2 1
*/