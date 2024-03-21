namespace BinarySearchWithWhileLoop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };
            int target = 14;

            int result = BinarySearch(arr, target);

            if (result != -1)
            {
                Console.WriteLine("Element found at index: " + result);
            }
            else
            {
                Console.WriteLine("Element not found in the array.");
            }
        }

        static int BinarySearch(int[] arr, int target)
        {
            int low = 0;
            int high = arr.Length - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2; // We can also use: int mid = low + (high- low) / 2

                if (arr[mid] == target)
                    return mid;

                // search the left half of the array
                else if (target < arr[mid])
                    high = mid - 1;

                // search the right half of the array
                else
                    low = mid + 1;
            }
            return -1;
        }
    }
}