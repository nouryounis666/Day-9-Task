using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_9_Task.Class
{
    internal class Child : Parent
    {
        #region Property
        public sealed override decimal Salary { get; set; } 
        #endregion

        #region Method
        public void DisplaySalary()
        {
            Console.WriteLine($"Salary: {Salary}");
        } 
        #endregion
    }
}
