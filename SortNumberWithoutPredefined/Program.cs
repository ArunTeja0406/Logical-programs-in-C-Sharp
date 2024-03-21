namespace SortNumberWithoutPredefined
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 6, 3, 7, 4, 1, 2, 5 };

            int temp;

            for (int i = 0; i < numbers.Count; i++)
            {
                for (int j = 0; j < numbers.Count; j++)
                {
                    if (numbers[i] < numbers[j]) //In case, to achieve descending order use 'greater than(>)' in if condition 
                    {
                        temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }

            Console.WriteLine("After sorting: ");
            foreach (var item in numbers)
            {
                Console.Write(item + " ");
            }

        }
    }
}