using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Delegates
{
    internal class SomeFunction
    {
        public static bool Test(string str) { return str.Length > 1; }
        public static string Cast(int str) { return str.ToString(); }
        public static void Print() { Console.WriteLine("Hello"); }
        public static void Print(string str) { Console.WriteLine($"Hello {str}"); }
    }
}
