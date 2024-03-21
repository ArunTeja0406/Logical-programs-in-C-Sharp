namespace CompareTwoArraysSfStrings
{
    class LogicalPorgrams
    {
        static void Main(string[] args)
        {
            string[] array1 = { "apple", "banana", "orange" };
            string[] array2 = { "apple", "banana", "orange" };

            //Using LinQ:
            bool areEqual = UsingLinQ.usingLinQ(array1, array2);

            if (areEqual)
                Console.WriteLine("Arrays are equal using LinQ");
            else
                Console.WriteLine("Arrays are not equal using LinQ");

            //Using Loop:
            bool areEqual2 = UsingLoop.usingLoop(array2, array1);

            if (areEqual2)
                Console.WriteLine("Arrays are equal using Loop");
            else
                Console.WriteLine("Arrays are not equal using Loop");

            //Using Array.Equal
            bool areEqual3 = UsingLoop.usingLoop(array2, array1);

            if (areEqual3)
                Console.WriteLine("Arrays are equal using Array.Equal");
            else
                Console.WriteLine("Arrays are not equal using Array.Equal");

        }
    }
}