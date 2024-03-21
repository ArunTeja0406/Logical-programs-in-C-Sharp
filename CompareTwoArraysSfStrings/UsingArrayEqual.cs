using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareTwoArraysSfStrings
{
    internal class UsingArrayEqual
    {
        static bool usingArrayEqual(string[] array1, string[] array2)
        {
            bool areEqual3 = Array.Equals(array1, array2);

            return areEqual3;

        }
    }
}
