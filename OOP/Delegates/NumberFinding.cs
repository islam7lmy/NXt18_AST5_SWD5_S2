using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Delegates
{
    public delegate bool NumberFuncDelegate(int num);
    public delegate bool GenericsNumberFuncDelegate<T>(T num);
    public delegate TResult EnhanceGenericsNumberFuncDelegate<in T,out TResult>(T num);

    internal class NumberFinding
    {
        #region Without Delegate
        public static List<int> FindOddNumbers(List<int> numbers)
        {
            List<int> oddnumbers = new List<int>();

            if (numbers is not null)
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] % 2 == 1)
                        oddnumbers.Add(numbers[i]);
                }

            return oddnumbers;
        }

        public static List<int> FindEvenNumbers(List<int> numbers)
        {
            List<int> evennumbers = new List<int>();

            if (numbers is not null)
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] % 2 == 0)
                        evennumbers.Add(numbers[i]);
                }

            return evennumbers;
        }

        public static List<int> FindNumbersDivisibleBySeven(List<int> numbers)
        {
            List<int> oddnumbers = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
                if (numbers[i] % 7 == 0)
                    oddnumbers.Add(numbers[i]);

            return oddnumbers;
        }
        #endregion
        #region withDelegates
        public static List<int> FindNumbers(List<int> numbers, NumberFuncDelegate reference)
        {
            List<int> oddnumbers = new List<int>();

            if (numbers is not null)
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (reference(numbers[i]))
                        oddnumbers.Add(numbers[i]);
                }

            return oddnumbers;
        }
        public static List<T> FindNumbers<T>(List<T> numbers, GenericsNumberFuncDelegate<T> reference)
        {
            List<T> oddnumbers = new List<T>();

            if (numbers is not null)
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (reference(numbers[i]))
                        oddnumbers.Add(numbers[i]);
                }

            return oddnumbers;
        }

        public static List<T> FindNumbers<T>(List<T> numbers, Predicate<T> reference)
        {
            List<T> oddnumbers = new List<T>();

            if (numbers is not null)
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (reference(numbers[i]))
                        oddnumbers.Add(numbers[i]);
                }

            return oddnumbers;
        }

        public static List<T> FindNumbers<T>(List<T> numbers, EnhanceGenericsNumberFuncDelegate<T,bool> reference)
        {
            List<T> oddnumbers = new List<T>();

            if (numbers is not null)
                for (int i = 0; i < numbers.Count; i++)
                {
                    //if (reference(numbers[i]))
                        oddnumbers.Add(numbers[i]);
                }

            return oddnumbers;
        }
        #endregion
    }

    class NumberConditionFunctions
    {
        public static bool Odd(int num)
        {
            return num % 2 == 1;
        }

        public static bool Even(int num)
        {
            return num % 2 == 0;
        }

        public static bool BySeven(int num)
        {
            return num % 7 == 0;
        }

        public static bool CheckLength(string str)
        {
            return str.Length > 4;
        }
    }
}
