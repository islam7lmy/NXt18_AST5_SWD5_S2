using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.InterFaces
{
    /// interface : is a contract that define a set of 
    /// methods, properties, events, or indexers that a class or struct must implement.
    interface IMytype
    {
        /// What You Can Write Inside The Interface?
        /// 1. Method Signature
        /// 2. property Signature
        /// 3. event Signature
        /// 4. indexer signature
        /// 5. Default Implementation (C# 8.0 +)
        
        /// Default acces modifiers inside the interface is Public
        /// private is not allowed inside the interface
        
        //property signature
        int Salary { get; set; }

        //method signature
        void Myfun();

        void Print()
        {
            Console.WriteLine("Hello I am Default Implementation");
        }
    }

    internal class MyType : IMytype //=> implementation
    {
        //clr will generate backing field
        //public int Salary { get; set; }

        private int _salary;

        public int Salary
        {
            get { return _salary; }
            set { _salary = value <= 2000 ? 2000 : value; }
        }

        public void Myfun()
        {
            Console.WriteLine("Hello");
        }

        public void Myfun2()
        {

        }
    }

    internal class MyTypev2 : IMytype
    {
        //clr will generate backing field
        //public int Salary { get; set; }

        private int _salary;

        public int Salary
        {
            get { return _salary; }
            set { _salary = value - 1000; }
        }

        public void Myfun()
        {
            Console.WriteLine("Hello Print");
        }
    }

}
