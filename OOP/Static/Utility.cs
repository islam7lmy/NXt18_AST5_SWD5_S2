using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Static
{
    /// Static Class
    /// is a just Container For Static Members [Attribute, Property, Constructor, Method] 
    /// You Can't Create Object From This Class (Helper Class)
    /// No Inheritance for this Class
    internal static class Utility
    {
        //static method
        public static void Swap(ref object obj1, ref object obj2)
        {
            object temp = obj1;
            obj1 = obj2;
            obj2 = temp;
        }
        public static void Hello()
        {
            Console.WriteLine("Hello");
        }

        /// Static Constructor [Maximum Only One Static Constructor Per Class]
        /// Can't Specifiy Access Modifiers or Parameters for Static Constructor
        /// Will be Executed Just Only One Time Per Class Lifetime Before the firts Usage of Class
        /// Usages Of Class
        /// 1. Call Static Mehtod or Static Property
        /// 2. set value for static property or filed
        static Utility()
        {
            Hello();
            pi = 3.14;
        }

        private static double pi;

        public static double PI { get { return pi; } }


        public static double calcCircleArea(double Radius)
        {
            return 3.14 * Radius * Radius;
        }
    }
}
