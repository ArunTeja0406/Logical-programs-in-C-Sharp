namespace PatternWithAlphabets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kindly enter the row number value: ");
            int input = int.Parse(Console.ReadLine());

            int counter = 0;

            for (int row = 1; row <= input; row++)
            {
                for (int column = input; column >= 1; column--) //This also works for same: for(int column = row; column <= input; column++)
                {
                    Console.Write((char)('A' + counter) + " "); //'A' is treated as ASCII value, the ASCII value of 'A' + 0 is 65
                    counter++;
                }
                Console.WriteLine();
            }
        }
    }
}
/* Pattern: 
A B C D E
F G H I
J K L
M N
O
*/

/* Pattern and logic: 
A B C D E
F G H I J
K L M N O
P Q R S T
U V W X Y

Using same code above, only 2nd for loop changes needed i.e., for (int column = input; column >= 1; column--) 
 */