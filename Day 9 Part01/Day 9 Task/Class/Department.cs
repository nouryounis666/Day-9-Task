using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_9_Task.Class
{
    internal class Department
    {
        #region Property
        public string Name { get; set; }
        #endregion

        #region Constructor
        public Department(string name)
        {
            Name = name;
        }
        #endregion

        #region Override
        public override bool Equals(object obj)
        {
            return obj is Department department && Name == department.Name;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        } 
        #endregion
    }
}
