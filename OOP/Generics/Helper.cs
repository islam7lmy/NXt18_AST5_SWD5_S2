using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Generics
{
    internal class Helper
    {
        #region Ex01: Swap
        #region NonGenerics
        //public static void Swap(ref int x ,ref int y)
        //{
        //    int temp = x;
        //    x = y;
        //    y = temp;
        //}

        //public static void Swap(ref double x, ref double y)
        //{
        //    double temp = x;
        //    x = y;
        //    y = temp;
        //}

        //public static void Swap(ref string x, ref string y)
        //{
        //    string temp = x;
        //    x = y;
        //    y = temp;
        //}

        public static void Swap(ref object x, ref object y)
        {
            object temp = x;
            x = y;
            y = temp;
        }
        #endregion
        #region Generics
        public static void Swap<hamada>(ref hamada x, ref hamada y)
        {
            hamada temp = x;
            x = y;
            y = temp;
        }
        #endregion
        #endregion

        #region SearchArray
        #region NonGenerics
        //public static int SearchArray(int[] arr, int value)
        //{
        //    if (arr is not null)
        //    {
        //        for (int i = 0; i < arr.Length; i++)
        //        {
        //            if (arr[i] == value)
        //                return i;
        //        }
        //    }
        //    return -1;
        //}

        ////public static int SearchArray(Generics.Point[] arr, Generics.Point value)
        ////{
        ////    if (arr is not null)
        ////    {
        ////        for (int i = 0; i < arr.Length; i++)
        ////        {
        ////            if (arr[i] == value)
        ////                return i;
        ////        }
        ////    }
        ////    return -1;
        ////}

        //public static int SearchArray(Generics.Point[] arr, Generics.Point value)
        //{
        //    if (arr is not null)
        //    {
        //        for (int i = 0; i < arr.Length; i++)
        //        {
        //            // Use Equals method to compare the objects
        //            // compare hashcode vs hashcode
        //            // compare the values of the objects
        //            if (arr[i].Equals(value))
        //                return i;
        //        }
        //    }
        //    return -1;
        //}

        #endregion
        #region Generics
        public static int SearchArray<T>(T[] arr, T value)
        {
            if (arr is not null)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    // Use Equals method to compare the objects
                    // compare hashcode vs hashcode
                    // compare the values of the objects
                    if (arr[i].Equals(value))
                        return i;
                }
            }
            return -1;
        }
        #endregion
        #endregion

        #region GetMax
        public static T GetMax<T>(T[] arr) where T : IComparable<T>
        {
            T max = arr[0];

            for (int i = 1; i < arr.Length; i++) 
            {
                if (arr[i].CompareTo(max) > 0)
                    max = arr[i];
            }

            return max;
        }
        #endregion

        
    }

    #region Constraints
    //T must be a reference type (class)
    public class Repository<T> where T : class 
    {
        public T? Data { get; set; }
    }

    public class Repository02<T> where T : notnull
    {
        public T? Data { get; set; }
    }

    //T must be a value type (struct)
    class Calculator<T> where T : struct
    {
        public T Value { get; set; }
    }

    //T must have a parameterless constructor
    class Factory<T> where T : new()
    {
        public T CreateInstance()
        {
            return new T();
        }
    }

    #region BaseClass
    class Employee
    {
        public string Name { get; set; }
    }

    class Manager : Employee
    {
    }

    class Devloper : Employee
    {
    }

    //T must be Employee or derived from Employee
    class EmployeeService<T> where T : Employee
    {
        public void PrintEmployeeName(T employee)
        {
            Console.WriteLine($"Employee Name: {employee.Name}");
        }
    }
    #endregion

    class Animal { }
    class Dog : Animal { }

    class AnimalContainer<T, U> where T : U
    {
        public AnimalContainer(T dog)
        {
            U animal = dog; // This is valid because T is constrained to be a subclass of U
        }
    }


    #endregion

    #region Quiz
    public interface IPrintable
    {
        void Print();
    }

    public class Student : IPrintable
    {
        public string Name { get; set; }

        public Student()
        {
            Name = "Unknown";
        }

        public void Print()
        {
            Console.WriteLine($"Student: {Name}");
        }
    }

    public class DataProcessor<T>
        where T : IPrintable, new()
    {
        public void Process(T item)
        {
            item.Print();

            T newItem = new T();

            newItem.Print();
        }
    }
    #endregion
}
