using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day_9_Task.Class;

namespace Day_9_Task.Interface
{
    internal class Employee : ICloneable, IComparable
    {
        #region Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public Department Department { get; set; }
        #endregion

        #region Method
        public object Clone()
        {
            return new Employee()
            {
                Id = this.Id,
                Name = this.Name,
                Salary = this.Salary
            };
        } 
        #endregion

        #region Constructor
        public Employee(Employee Copy)
        {
            Id = Copy.Id;
            Name = Copy.Name;
            Salary = Copy.Salary;
        }
        public Employee() { }

        public Employee(int _Id, string Name, double Salary)
        {
            this.Id = _Id;
            this.Name = Name;
            this.Salary = Salary;
        }
        public Employee(string name, Department department)
        {
            Name = name;
            Department = department;
        }
        #endregion

        #region Override 
        public override string ToString()
        {
            return $"EmpId is {Id}, EmpName is {Name}, EmpSalary is {Salary}";
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name, Salary);
        }
        #endregion

        #region CompareTo method
        public int CompareTo(object obj)
        {
            Employee PassedEmp = (Employee)obj;

            if (this.Salary > PassedEmp.Salary)
                return 1;
            else if (this.Salary < PassedEmp.Salary)
                return -1;
            else
                return 0;
        }
        #endregion

        #region  Overriding Equals
        public override bool Equals(object obj)
        {
            if (obj is Employee emp)
            {
                return this.Id == emp.Id && this.Name == emp.Name && this.Salary == emp.Salary;
            }
            return false;
        } 
        #endregion

    }
}
