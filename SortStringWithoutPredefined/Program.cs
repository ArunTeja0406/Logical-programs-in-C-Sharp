namespace SortStringWithoutPredefined
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string> { "Charlie", "Bob", "Alice", "David" };

            string temp;

            for (int i = 0; i < names.Count; i++)
            {
                for (int j = 0; j < names.Count; j++)
                {
                    if (string.Compare(names[i], names[j]) < 0) //In case, to achieve descending order use 'greater than(>)' in if condition 
                    {
                        temp = names[i];
                        names[i] = names[j];
                        names[j] = temp;
                    }
                }
            }

            Console.WriteLine("After sorting: ");
            foreach (var item in names)
            {
                Console.Write(item + " ");
            }

        }
    }
}