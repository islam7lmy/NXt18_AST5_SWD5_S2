using System.Text;

namespace Demo01
{
    internal class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            #region Comments
            //line comment

            /* 
             * block comment 
             * block comment
             * block comment
             */
            #endregion

            #region Value Type
            //int X;
            ///// allocate 4 uninitialized bytes in stack for x

            //X = 5;

            //Int32 Y;
            ///// allocate 4 uninitialized bytes in stack for y

            //Y = X;

            //X = X + 1;

            //Console.WriteLine($"y = {Y}");
            //Console.WriteLine($"x = {X}");
            #endregion

            #region Reference Type
            //Point P1;
            ///// allocate 4 bytes in stack for reference P1 of type Point , Referring to null
            ///// zero bytes allocated in heap for Point object

            //P1 = new Point();
            ///// new
            ///// 1. allocate required bytes in heap for Point object (4 bytes for X , 4 bytes for Y)
            ///// 2. initialize the allocated bytes in heap to default values (0 for X , 0 for Y)
            ///// 3. call user defined constructor of Point class to initialize the allocated bytes in heap
            ///// 4. assign the address of the allocated bytes in heap to reference P1 in stack

            //Point P2 = new Point();
            ///// allocate 4 bytes in stack for reference P2 of type Point , Referring to null
            ///// /// 1. allocate required bytes in heap for Point object (4 bytes for X , 4 bytes for Y)
            ///// 2. initialize the allocated bytes in heap to default values (0 for X , 0 for Y)
            ///// 3. call user defined constructor of Point class to initialize the allocated bytes in heap
            ///// 4. assign the address of the allocated bytes in heap to reference P1 in stack

            //Console.WriteLine($"P1 hashcode : {P1.GetHashCode()}");
            //Console.WriteLine($"P2 hashcode : {P2.GetHashCode()}");

            //Console.WriteLine("after assignment");

            //P2 = P1;
            ///// assign the address of the allocated bytes in heap of reference P1 to reference P2 in stack

            //Console.WriteLine($"P1 hashcode : {P1.GetHashCode()}");
            //Console.WriteLine($"P2 hashcode : {P2.GetHashCode()}");


            //P1.X = 5;
            //P1.Y = 10;

            ////Console.WriteLine($"P2({P2.X} , {P2.Y})");

            //P2.X = 15;
            //P2.Y = 20;

            ////Console.WriteLine($"P1({P1.X} , {P1.Y})");
            #endregion

            #region Object
            //object O1 = new object();

            //Point P1 = new Point();

            //P1.ToString();
            //P1.Equals(P1);
            //P1.GetHashCode();
            //P1.GetType();


            //int X = 5;

            //X.ToString();
            //X.Equals(X);
            //X.GetHashCode();
            //X.GetType();


            //O1 = X;
            //O1 = P1;
            //O1 = true;
            #endregion

            #region Fractions and Discards
            // for better readability of large numbers, we can use _ as a separator in numeric literals
            //int X = 1_000_000_000; //_ discard to  imporve readabilty

            //double d1 = 15.3;
            //float f1 = 15.3f;
            //decimal m1 = 15.3m;
            #endregion

            #region Value Type Casting
            /////1. Implicit Casting (safe casting)
            //int X = 5;
            //long Y = X; // Implicit casting from int to long

            ////X = Y; // Implicit casting from long to int (may cause data loss if Y is too large)
            //// compile time error: cannot implicitly convert long to int

            /////2. Explicit Casting (unsafe casting)
            //Y = 1_000_000_000_000; // Assigning a large value to Y
            //X = (int) Y; // Explicit casting from long to int (may cause data loss if Y is too large)

            //checked
            //{
            //    int Z = (int) Y; // Explicit casting from long to int (may cause data loss if Y is too large)
            //    unchecked
            //    {
            //        Console.WriteLine($"Z = {Z}");
            //    }
            //}
            //Console.WriteLine($"Y = {Y}"); // Output: Y = 1000000000000
            //Console.WriteLine($"X = {X}"); // Output: X = -727379968 (data loss occurred)

            /// 3. Parsing (string to value type) --> unsafe casting
            //Console.Write("Please Enter Your Name:");
            //string name = Console.ReadLine();
            //Console.Write("Please Enter Your Age: ");
            //int age = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Hello {name}, you are {age} years old.");

            /// 4. tryParse (string to value type) --> safe casting
            //Console.Write("Please Enter Your Name:");
            //string name = Console.ReadLine();
            //Console.Write("Please Enter Your Age: ");
            //if (int.TryParse(Console.ReadLine(), out int age))
            //    Console.WriteLine($"Hello {name}, you are {age} years old.");
            //else
            //    Console.WriteLine("Invalid age input. Please enter a valid integer.");

            /// 5. Convert (any datatype to any datatype) --> unsafe casting
            //Console.Write("Please Enter Your Name:");
            //string name = Console.ReadLine();
            //Console.Write("Please Enter Your Age: ");
            //int age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"Hello {name}, you are {age} years old.");
            #endregion

            #region Operators

            #region Unary Operator
            //int X = 10;
            ////X++; ==> same
            ////++X; ==> same
            ///// 1. prefix increment operator (++X) : increments the value of X by 1 and returns the incremented value
            //Console.WriteLine(++X); // increment x to 11 then print 11 
            ///// 2. postfix increment operator (X++) : returns the current value of X and then increments the value of X by 1
            //Console.WriteLine(X++); // print 11 then increment x to 12
            //Console.WriteLine(X); // print 12
            ///// 3. prefix decrement operator (--X) : decrements the value of X by 1 and returns the decremented value
            //Console.WriteLine(--X); // decrement x to 11 then print 11
            ///// 4. postfix decrement operator (X--) : returns the current value of X and then decrements the value of X by 1
            //Console.WriteLine(X--); // print 11 then decrement x to 10
            //Console.WriteLine(X); // print 10
            #endregion

            #region Binary Operator
            //int Sum, Mul, Sub, Div, Mod, num1 = 10, num2 = 5;
            //Sum = num1 + num2; // addition
            //Mul = num1 * num2; // multiplication
            //Sub = num1 - num2; // subtraction
            //Div = num1 / num2; // division 
            //Mod = num1 % num2; // modulus


            //int x = 10 / 3; // integer division, result is 3
            //Console.WriteLine(x); // Output: 3

            //double y = 10.0 / 3;
            //Console.WriteLine(y); // 3.3333333333333335

            //double Div2 = (double)num1 / num2; // explicit casting to double
            //Console.WriteLine(Div2);

            #endregion

            #region Assignment Operator
            //int X;
            //X = 5; // assignment operator
            //X += 10; // addition assignment operator, equivalent to X = X + 10
            //X -= 3; // subtraction assignment operator, equivalent to X = X - 3
            //X *= 2; // multiplication assignment operator, equivalent to X = X * 2
            //X /= 4; // division assignment operator, equivalent to X = X / 4
            //X %= 3; // modulus assignment operator, equivalent to X = X % 3
            #endregion

            #region Relational Operator [Compaision]
            //int X = 10, Y = 20;
            //Console.WriteLine(X == Y); //equality operator // false
            //Console.WriteLine(X != Y); //inequality operator // true
            //Console.WriteLine(X > Y); // greater than operator // false
            //Console.WriteLine(X >= Y); // greater than or equal to operator // false
            //Console.WriteLine(X < Y); // less than operator // true
            //Console.WriteLine(X <= Y); // less than or equal to operator // true
            #endregion

            #region Logical Operator
            //Console.WriteLine(!false); // logical NOT operator, negates the boolean value, Output: True
            ///// logical AND operator (&&) and lofgical OR operator (||) are short-circuit operators, meaning they only evaluate the second operand if necessary.
            //Console.WriteLine(false && true); // logical AND operator, returns true if both operands are true, Output: False
            //Console.WriteLine(false || true); // logical OR operator, returns true if at least one operand is true, Output: True

            //Console.WriteLine((4 > 5) && (!(7 < 9) || 5 == 5)); 
            #endregion

            #region Bitwise Operator
            //Console.WriteLine(false & true); // bitwise AND operator, returns true if both operands are true, Output: False
            //Console.WriteLine(false | true); // bitwise OR operator, returns true if at least one operand is true, Output: True
            //Console.WriteLine(true ^ false); // bitwise XOR operator, returns true if operands are different, Output: True  
            #endregion

            #region Ternary Operator 
            //int X = 4, Y = 7, Z = 10;
            //if (X > Y)
            //    Console.WriteLine("X is greater than Y");
            //else
            //    Console.WriteLine("Y is greater than X");

            //Console.WriteLine(X > Y ? "X is greater than Y" : "Y is greater than X");


            //if (X > Y)
            //    if (X > Z)
            //        Console.WriteLine("X is the greatest");
            //    else
            //        Console.WriteLine("Z is the greatest");
            //else if (Y > Z)
            //    Console.WriteLine("Y is the greatest");
            //else
            //    Console.WriteLine("Z is the greatest");

            ///// not recommended to use nested ternary operator for better readability
            //Console.WriteLine(X > Y ? (X > Z ? "X is the greatest" : "Z is the greatest") : (Y > Z ? "Y is the greatest" : "Z is the greatest"));
            #endregion

            #region Operator Priorty
            /// 1. unary operator [prefix]
            /// 2. round brackets ()
            /// 3. multiplicative operator (* , / , %)
            /// 4. additive operator (+ , -)

            //int a = 20, b = 10, c = 15, d = 5;
            //int result = (a + b) * c / d; // 20 + 10 = 30 * 15 = 450 / 5 = 90
            //int result2 = ((--a + b) * c) / d; // 19 + 10 = 29 * 15 = 435 / 5 = 87
            //int result3 = --a + b * c / d; // 19 + 10 * 15 / 5 = 19 + 150 / 5 = 19 + 30 = 49
            //int result4 = ++a + a++ - --a - a--; // 21 + 21 - 21 - 21       => a = 22 => 21 => 20
            // ++a => a = 21 , value = 21
            // a++ => value = 21 , a = 22
            // --a => a = 21 , value = 21
            // a-- => value = 21 , a = 20

            #endregion
            #endregion

            #region string vs stringbuilder
            //string x = "Hello"; //syntactic sugar for string x = new string("Hello");
            //Console.WriteLine(x.GetHashCode());
            //x = "world"; // x = new string("world"); // x now refers to a new string object, the old string "Hello" is eligible for garbage collection
            //Console.WriteLine(x.GetHashCode());
            //x += "!!!"; // x = new string("world!!!"); // x now refers to a new string object, the old string "world" is eligible for garbage collection
            //Console.WriteLine(x.GetHashCode());
            ////////////////////////////////////////////////
            //StringBuilder Y = new StringBuilder("Hello");
            //Console.WriteLine(Y.GetHashCode());
            //Y.Append(" world"); // modifies the existing StringBuilder object, no new object is created
            //Console.WriteLine(Y.GetHashCode());
            //Y.Clear(); // clears the content of the StringBuilder object, no new object is created
            //Y.AppendLine("Hello world"); // modifies the existing StringBuilder object, no new object is created
            //Y.Insert(0, "Welcome to "); // modifies the existing StringBuilder object, no new object is created
            //Y.Remove(0, 11); // modifies the existing StringBuilder object, no new object is created
            //Y.Replace("world", "C#"); // modifies the existing StringBuilder object, no new object is created
            //Console.WriteLine(Y);
            #endregion
        } 
    }
}
