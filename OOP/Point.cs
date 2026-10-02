using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal struct Point
    {
        /// What You Can Write Inside The Class Or Struct?
        /// 1. variables => fields (Attributes)
        /// 2. functions => Methods
        /// 3. Constructor => special method
        /// 4. Properties
        /// 5. Events
        /// 6. Indexers

        public int x;
        public int y;

        /// clr will create a default constructor for the struct 
        /// that will initialize the fields with default values
        /// You Can't Create User-Defined Parameterless Constructor 
        /// Inside Struct (Except C# 10.0)

        //public Point()
        //{
        //    x = default;
        //    y = default;
        //}

        /// <summary>
        /// user defined constructor with parameters to initialize the struct fields
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public Point(int _x, int _y)
        {
            // this.x = x;
            // this.y = y;

            x = _x;
            y = _y;
        }
    }
}
