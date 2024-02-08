namespace PatternwithNumberSeries_n_m__03_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kindly enter the No. of rows: ");
            int input = int.Parse(Console.ReadLine());

            char sym = '#';

            for (int row = 1; row <= input; row++)
            {
                for (int column = 1; column <= row; column++)
                {
                    Console.Write(sym + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
/*
#
# #
# # #
# # # #
# # # # # 
*/