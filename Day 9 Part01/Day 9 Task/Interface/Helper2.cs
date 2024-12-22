using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_9_Task.Interface
{
    public static class Helper2<T>
    {
        #region Methods
        public static int SearchArray(T[] array, T value)
        {
            for (int i = 0; i < array?.Length; i++)
            {
                if (EqualityComparer<T>.Default.Equals(array[i], value))
                    return i;
            }
            return -1;
        }
        public static void ReplaceArray(T[] array, T oldValue, T newValue)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(oldValue))
                {
                    array[i] = newValue;
                }
            }
        }
        public static T SearchArray(T[] array, string departmentName)
        {
            foreach (var item in array)
            {
                if ((item as Employee)?.Department.Name == departmentName)
                {
                    return item;
                }
            }
            return default(T);
        } 
        #endregion
    }
}
