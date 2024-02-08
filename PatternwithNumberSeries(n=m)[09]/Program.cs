namespace PatternwithNumberSeries_n_m__09_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kindly enter the No. of rows");
            int input = int.Parse(Console.ReadLine());

            for (int row = 1; row <= input; row++)
            {
                for (int column = input; column >= row; column--)
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
6 5 4 3 2
6 5 4 3
6 5 4
6 5
6
*/