namespace PatternwithNumberSeries_n_m__07_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kindly enter the No. of rows");
            int input = int.Parse(Console.ReadLine());

            for (int row = input; row >=1; row--)
            {
                for (int column = row; column >= 1; column--)
                {
                    Console.Write(column + " ");
                }
                Console.WriteLine(" ");
            }
        }
    }
}
/* Pattern:
6 5 4 3 2 1
5 4 3 2 1
4 3 2 1
3 2 1
2 1
1
*/