using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_9_Part02.Static
{
    internal static class ArrayHelper
    {
        #region Problem 1 Method
        public static T[] ReverseArray<T>(T[] array)
        {
            T[] reversed = new T[array.Length];
            for (int i = 0, j = array.Length - 1; i < array.Length; i++, j--)
            {
                reversed[i] = array[j];
            }
            return reversed;
        }
        #endregion

        #region Problem 3 Swap
        public static void Swap<T>(T[] array, int index1, int index2)
        {
            if (index1 < 0 || index1 >= array.Length || index2 < 0 || index2 >= array.Length)
            {
                throw new ArgumentOutOfRangeException("Indices are out of range.");
            }

            T temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
        }
        #endregion

        #region Problem 4 Max
        public static T Max<T>(T[] array) where T : IComparable<T>
        {
            if (array == null || array.Length == 0)
                throw new ArgumentException("Array is empty or null.");

            T max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i].CompareTo(max) > 0)
                    max = array[i];
            }
            return max;
        }
        #endregion
    }
}
