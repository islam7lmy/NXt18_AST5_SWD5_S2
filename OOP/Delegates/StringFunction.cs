using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Delegates
{
    internal static class StringFunction
    {
        public static int GetCountOfUpperCaseChar(string Name)
        {
            int count = 0;
            if (Name is not null)
                for (int i = 0; i < Name.Length; i++)
                {
                    if (char.IsUpper(Name[i]))
                        count++;
                }
            //foreach (char item in Name)
            //{
            //    if (char.IsUpper(item))
            //        count++;
            //}
            return count;
        }

        public static int GetCountOfLowerCaseChar(string Name)
        {
            int count = 0;
            if (Name is not null)
                for (int i = 0; i < Name.Length; i++)
                {
                    if (char.IsLower(Name[i]))
                        count++;
                }
            //foreach (char item in Name)
            //{
            //    if (char.IsUpper(item))
            //        count++;
            //}
            return count;
        }
    }
}
