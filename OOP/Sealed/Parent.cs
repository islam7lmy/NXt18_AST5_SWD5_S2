using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Sealed
{
    internal class Parent
    {
        private int salary;

        /// getter & setter => methods
        public virtual int Salary
        {
            get { return salary; }
            set { salary = value - 1000; }
        }

        public virtual void Print()
        {
            Console.WriteLine("Hello Parent");
        }
    }

    class Child02 : Parent
    {
        //salary - 1500
        public override int Salary
        {
            get => base.Salary;
            set => base.Salary = value - 500;
        }

        public override void Print()
        {
            Console.WriteLine("Hello Child");
        }
    }

    class Child : Parent
    {
        //salary - 1500
        public sealed override int Salary
        {
            get => base.Salary;
            set => base.Salary = value - 500;
        }

        public sealed override void Print()
        {
            Console.WriteLine("Hello Child");
        }
    }

    sealed class GrandChild : Child
    {
        //public new void Print()
        //{
        //    Console.WriteLine("Hello Child");
        //}
    }

    //class GrandGrandChild : GrandChild
    //{

    //}
}
