namespace PatternwithNumberSeries_n_m__04_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kindly enter the No. of rows");
            int input = int.Parse(Console.ReadLine());

            for (int row = input; row >=1 ; row--)
            {
                for (int column = row; column <=input; column++)
                {
                    Console.Write(column + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
/*
5
4 5
3 4 5
2 3 4 5
1 2 3 4 5
*/