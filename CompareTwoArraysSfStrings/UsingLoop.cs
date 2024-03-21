using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareTwoArraysSfStrings
{
    internal class UsingLoop
    {
        public static bool usingLoop(string[] array1, string[] array2)
        {

            bool areEqual2 = true;

            if (array1.Length != array2.Length)
            {
                areEqual2 = false;
            }
            else
            {
                for (int i = 0; i < array1.Length; i++)
                {
                    if (array1[i] != array2[i])
                    {
                        areEqual2 = false;
                        break;
                    }
                }
            }
            return areEqual2;
        }
    }
}
