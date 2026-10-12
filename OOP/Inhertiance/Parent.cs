using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Inhertiance
{
    internal class Parent
    {
        public int A { get; set; }

        ///clr will create a default constructor
        //public Parent()
        //{
        //}


        /// <summary>
        /// userer defined constructor
        /// </summary>
        /// <param name="_a"></param>
        public Parent(int _a)
        {
            A = _a;
        }

        public void MyFunc01()
        {
            Console.WriteLine("Hi I am Parent");
        }

        public void MyFunc02()
        {
            Console.WriteLine($"A = {A}");
        }

    }
}
