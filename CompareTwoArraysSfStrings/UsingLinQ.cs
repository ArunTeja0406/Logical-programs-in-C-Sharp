using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareTwoArraysSfStrings
{
    internal class UsingLinQ
    {
        //Using LinQ built-in method SequenceEqual():   
        public static bool usingLinQ(string[] array1, string[] array2)
        {

            return array1.SequenceEqual(array2);

        }

    }
}
