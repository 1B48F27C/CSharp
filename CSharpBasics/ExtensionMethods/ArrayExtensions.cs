using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMethods
{
    public static class ArrayExtensions
    {
        public static bool IsDecimalArraySorted(this decimal[] array)
        {
            var isSorted = true;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    isSorted = false;
                    break;
                }
            }
            return isSorted;
        }

        public static bool HasDuplicates(this decimal[] array)
        {
            var hasDuplicates = false;
            Array.Sort(array);
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == array[i + 1])
                {
                    hasDuplicates = true;
                    break;
                }
            } 
            return hasDuplicates;
        }
    }
}
