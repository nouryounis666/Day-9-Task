using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day_9_Task.Struct;

namespace Day_9_Task.Static
{
    internal static class Utility
    {
        #region Methods
        public static double RectanglePerimeter(double length, double width)
        {
            return 2 * (length + width);
        }

        public static double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }
        public static double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
        #endregion

        #region Non Generic Swap
        public static void Swap(ref Rectangle a, ref Rectangle b)
        {
            Rectangle temp = a;
            a = b;
            b = temp;
        } 
        #endregion
    }
}
