using System;
using System.Buffers.Text;
using System.Reflection;
using System.Reflection.Metadata;
using Day_9_Task.Class;
using Day_9_Task.Interface;
using Day_9_Task.Static;
using Day_9_Task.Struct;


#region Problem 1 
enum Weekdays
{
    Monday = 1,
    Tuesday,
    Wednesday,
    Thursday,
    Friday
}
#endregion

#region Problem 2 
enum Grades : short
{
    F=1,
    E,
    D,
    C,
    B,
    A
}
#endregion

#region Problem 3 & 9
class Person
{
    public string? Name { get; set; }
    public string? Department { get; set; }
}
#endregion

#region Problem 7
enum Gender : byte
{
    Male,
    Female
} 
#endregion


internal class Program
{
    static void Main()
    {
        #region Problem 1
        //foreach (Weekdays day in Enum.GetValues(typeof(Weekdays)))
        //{
        //    Console.WriteLine($"{day} = {(int)day}");
        //}

        ////Question: Why is it recommended to explicitly assign values to enum members in some cases?
        ////Explicitly assigning values to enum members ensures specific values for interoperability, avoids conflicts, and maintains consistency.
        #endregion

        #region Problem 2
        //foreach (Grades grade in Enum.GetValues(typeof(Grades)))
        //{
        //    Console.WriteLine($"Name: {grade}, Grade value: {(short)grade}");
        //}

        ////Question: What happens if you assign a value to an enum member that exceeds the underlying type's range? 
        ////Assigning a value to an enum member that exceeds the underlying type's range causes a compilation error.
        #endregion

        #region Problem 3
        //Person P01 = new Person()
        //{
        //    Name = "Nour",
        //    Department = "Engineering"
        //};
        //Person P02 = new Person()
        //{
        //    Name = "Tamer",
        //    Department = "Marketing"
        //};

        //Console.WriteLine($"Name: {P01.Name}, Department: {P01.Department}");
        //Console.WriteLine($"Name: {P02.Name}, Department: {P02.Department}");

        ////Question: What is the purpose of the virtual keyword when used with properties?
        ////The virtual keyword allows a property to be overridden in a derived class, enabling polymorphism.
        #endregion

        #region Problem 4
        //var child = new Child { Salary = 6666m };
        //child.DisplaySalary();

        ////Question: Why can’t you override a sealed property or method?
        ////A sealed property or method cannot be overridden to ensure the behavior remains unchanged in derived classes.
        #endregion

        #region Problem 5
        //double perimeter = Utility.RectanglePerimeter(5, 3);
        //Console.WriteLine($"Perimeter: {perimeter}");

        ////Question: What is the key difference between static and object members?
        ////Static members belong to the class itself and are shared among all instances, while object members belong to individual instances.
        #endregion

        #region Problem 6
        //ComplexNumber c1 = new ComplexNumber { Real = 3, Imag = 2 };
        //ComplexNumber c2 = new ComplexNumber { Real = 1, Imag = 4 };

        //ComplexNumber sum = c1 + c2;
        //ComplexNumber difference = c1 - c2;
        //ComplexNumber product = c1 * c2;

        //Console.WriteLine($"c1: {c1}");
        //Console.WriteLine($"c2: {c2}");
        //Console.WriteLine($"Sum: {sum}");
        //Console.WriteLine($"Difference: {difference}");
        //Console.WriteLine($"Product: {product}");

        ////Question: Can you overload all operators in C#? Explain why or why not.
        ////Not all operators can be overloaded in C# because some have specific behaviors integral to the language's syntax and semantics.
        #endregion

        #region Problem 7
        //Console.WriteLine($"Memory usage of Gender enum: {sizeof(Gender)} byte");
        //Console.WriteLine($"Memory usage of default int: {sizeof(int)} bytes");

        ////Question: When should you consider changing the underlying type of an enum?
        ////Change the underlying type of an enum to optimize memory usage or match a specific data type for interoperability.
        #endregion

        #region Problem 8
        //double celsius = 25;
        //double fahrenheit = Utility.CelsiusToFahrenheit(celsius);
        //Console.WriteLine($"{celsius}°C = {fahrenheit}°F");

        //fahrenheit = 59;
        //celsius = Utility.FahrenheitToCelsius(fahrenheit);
        //Console.WriteLine($"{fahrenheit}°F = {celsius}°C");

        ////Question: Why can't a static class have instance constructors?
        ////A static class cannot have instance constructors because it cannot be instantiated.
        #endregion

        #region Problem 9
        //Console.Write("Enter a grade: ");
        //string input = Console.ReadLine();

        //if (Enum.TryParse(input, out Grades grade))
        //{
        //    Console.WriteLine($"Parsed grade: {grade}");
        //}
        //else
        //{
        //    Console.WriteLine("Invalid grade entered.");
        //}

        ////Question: What are the advantages of using Enum.TryParse over direct parsing with int.Parse ?
        ////Enum.TryParse provides safe parsing without exceptions and allows graceful error handling.
        #endregion

        #region Problem 10
        //Employee[] employees =
        //{
        //    new Employee(1, "Ahmed", 5000),
        //    new Employee(2, "Nour", 6000),
        //    new Employee(3, "Tamer", 4000)
        //};

        //Employee target = new Employee(2, "Nour", 6000);

        //int index = Helper2<Employee>.SearchArray(employees, target);

        //if (index >= 0)
        //{
        //    Console.WriteLine($"Employee found at index {index}: {employees[index]}");
        //}
        //else
        //{
        //    Console.WriteLine("Employee not found.");
        //}

        ////Question: What is the difference between overriding Equals and == for object comparison in C# struct and class ? 
        ////Equals is a method that can be overridden to define equality based on object content.
        ////== is an operator that must be overloaded explicitly for custom classes and structs to define equality behavior.
        #endregion

        #region Question
        //Question: Why is overriding ToString beneficial when working with custom classes?
        //Overriding ToString is beneficial for providing a meaningful string representation of an object, which is useful for debugging,
        //logging, or displaying object information in a user-friendly manner. 
        #endregion

        #region Problem 11
        //Console.WriteLine(Helper.Max(3, 6)); 
        //Console.WriteLine(Helper.Max(3.5, 7.1)); 
        //Console.WriteLine(Helper.Max("Pineapple", "Hello")); 

        ////Question: Can generics be constrained to specific types in C#? Provide an example.
        ////Yes, generics can be constrained to specific types using constraints like where T : class, where T : struct, where T : new(),
        ////where T : SomeBaseClass, or where T : IComparable<T>.
        #endregion

        #region Problem 12
        //int[] intArray = { 1, 2, 3, 4, 5, 3, 6 };
        //Console.WriteLine("Original integer array: ");
        //foreach (var item in intArray)
        //{
        //    Console.Write(item + " ");
        //}

        //Helper2<int>.ReplaceArray(intArray, 3, 66);
        //Console.WriteLine("\nModified integer array: ");
        //foreach (var item in intArray)
        //{
        //    Console.Write(item + " ");
        //}

        //string[] strArray = { "Nour", "Tamer", "Abdelhaleem", "Mostafa", "Younis" };
        //Console.WriteLine("\nOriginal string array: ");
        //foreach (var item in strArray)
        //{
        //    Console.Write(item + " ");
        //}

        //Helper2<string>.ReplaceArray(strArray, "Tamer", "Younis");
        //Console.WriteLine("\nModified string array: ");
        //foreach (var item in strArray)
        //{
        //    Console.Write(item + " ");
        //}

        ////Question: What are the key differences between generic methods and generic classes ?
        ////Generic methods are defined within a class and can be used independently of the class's type parameters,
        ////while generic classes define type parameters that apply to the entire class and its members.
        #endregion

        #region Problem 13
        //Rectangle rect1 = new Rectangle(6, 12);
        //Rectangle rect2 = new Rectangle(15, 20);

        //Utility.Swap(ref rect1, ref rect2);

        //Console.WriteLine($"Rect1: {rect1.Length}, {rect1.Width}"); 
        //Console.WriteLine($"Rect2: {rect2.Length}, {rect2.Width}"); 

        ////Question: Why might using a generic swap method be preferable to implementing custom methods for each type?
        ////A generic swap method is preferable because it can handle any type, reducing code duplication and increasing reusability.
        #endregion

        #region Problem 14
        //Department hr = new Department("HR");
        //Department it = new Department("IT");

        //Employee[] employees = {
        //    new Employee("Younis", hr),
        //    new Employee("Nour", it)
        //};

        //Employee foundEmployee = Helper2<Employee>.SearchArray(employees, "HR");
        //Console.WriteLine(foundEmployee != null ? $"Found: {foundEmployee.Name}" : "Not Found");

        ////Question: How can overriding Equals for the Department class improve the accuracy of searches?
        ////Overriding Equals ensures that comparisons are based on the actual content of the Department objects, improving search accuracy.
        #endregion

        #region Problem 15
        //Circle circle1 = new Circle(6, "Blue");
        //Circle circle2 = new Circle(6, "Blue");
        //Console.WriteLine(circle1 == circle2);
        //Console.WriteLine(circle1.Equals(circle2)); 

        //CircleClass circleClass1 = new CircleClass(6, "Blue");
        //CircleClass circleClass2 = new CircleClass(6, "Blue");
        //Console.WriteLine(circleClass1 == circleClass2); 
        //Console.WriteLine(circleClass1.Equals(circleClass2));

        ////Question: Why is == not implemented by default for structs ?
        ////== is not implemented by default for structs because it requires defining what equality means for the struct, which can vary based on the struct's fields and intended use.
        #endregion
    }
}