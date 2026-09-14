using System.Collections;
using System.Text;
using System.Xml.Linq;

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

            #region string Formating
            /// Equition : 4 + 2 = 6
            //int X = 4, Y = 2;
            //string result = "Equition : " + X + " + " + Y + " = " + (X + Y); // string concatenation

            //string result1 = "Equition : ";
            //result1 += X;
            //result1 += " + ";
            //result1 += Y;
            //result1 += " = ";
            //result1 += (X + Y);

            //StringBuilder result2 = new StringBuilder();
            //result2.Append("Equition : ");
            //result2.Append(X);
            //result2.Append(" + ");
            //result2.Append(Y);
            //result2.Append(" = ");
            //result2.Append(X + Y);

            //string result3 = string.Format("Equition : {0} + {1} = {2}", X, Y, (X + Y)); // string formatting using placeholders

            //string result4 = $"Equition : {X} + {Y} = {X + Y}"; // string interpolation using $ and {} for expressions

            //Console.WriteLine(result);
            //Console.WriteLine(result1);
            //Console.WriteLine(result2);
            //Console.WriteLine(result3);
            //Console.WriteLine(result4);

            #endregion

            #region Conditional statment
            //if (condition) // true or false
            //{
            //    // statements to execute if condition is true
            //}
            //else if (condition2)
            //{
            //    // statements to execute if condition2 is true
            //}
            //else
            //{
            //    // statements to execute if all conditions are false
            //}


            //jump table
            //variable = value
            //switch (variable)
            //{
            //    case value1:
            //        // statements to execute if variable == value1
            //        break;
            //    case value2:
            //        // statements to execute if variable == value2
            //        break;
            //    default:
            //        // statements to execute if variable does not match any case
            //        break;
            //}

            #region Ex01 : write a program to take number in first quarter in year and print the month name
            ///write a program to take number in first quarter in year and print the month name 
            /// {1 , 2 , 3} => {january , February , March} 

            #region IF statment
            //Console.WriteLine("insert number of month in first qurter of year :");
            ////int month =int.Parse(Console.ReadLine());
            //if (int.TryParse(Console.ReadLine(), out int month))
            //{
            //    //Console.WriteLine(
            //    //    month == 1 ? "January" :
            //    //    month == 2 ? "February" :
            //    //    month == 3 ? "March" 
            //    //    : "Invalid month number"
            //    //    );


            //    //if (month == 1)
            //    //{
            //    //    Console.WriteLine("January");
            //    //}
            //    //else if (month == 2)
            //    //{
            //    //    Console.WriteLine("February");
            //    //}
            //    //else if (month == 3)
            //    //{
            //    //    Console.WriteLine("March");
            //    //}
            //    //else
            //    //{
            //    //    Console.WriteLine("Invalid month number");
            //    //}
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid integer.");
            //} 
            #endregion
            #region Switch
            //Console.WriteLine("insert number of month in first qurter of year :");
            ////int month =int.Parse(Console.ReadLine());
            //if (int.TryParse(Console.ReadLine(), out int month))
            //{
            //    switch(month)
            //    {
            //        case 1:
            //            Console.WriteLine("January");
            //            break;
            //        case 2:
            //            Console.WriteLine("February");
            //            break;
            //        case 3:
            //            Console.WriteLine("March");
            //            break;
            //        default:
            //            Console.WriteLine("Invalid month number");
            //            break;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid integer.");
            //}
            #endregion
            #endregion
            #region Ex02
            //int salary = 3000;
            //switch (salary)
            //{
            //    case 3000:
            //        Console.WriteLine("option 03");
            //        //Console.WriteLine("option 02");
            //        //Console.WriteLine("option 01");
            //        //break;
            //        goto case 2000;
            //    case 2000:
            //        Console.WriteLine("option 02");
            //        //Console.WriteLine("option 01");
            //        //break;
            //        goto case 1000;
            //    case 1000:
            //        Console.WriteLine("option 01");
            //        break;
            //    default:
            //        Console.WriteLine("No option");
            //        break;
            //}
            #endregion
            #region Calculater
            //take number then opertation then number and show result
            //calculater do (+ - * / %)
            //write program to do that and make it protictive

            #region not clean code
            //Console.WriteLine("enter first number");
            //if (int.TryParse(Console.ReadLine(), out int num01))
            //{
            //    if (char.TryParse(Console.ReadLine(), out char op))
            //    {
            //        if (int.TryParse(Console.ReadLine(), out int num02))
            //        {

            //            int result = 0;
            //            switch (op)
            //            {
            //                case '+':
            //                    result = num01 + num02;
            //                    break;
            //                case '-':
            //                    result = num01 - num02;
            //                    break;
            //                case '*':
            //                    result = num01 * num02;
            //                    break;
            //                case '/':
            //                    if (num02 != 0)
            //                        result = num01 / num02;
            //                    else
            //                    {
            //                        Console.WriteLine("Error: Division by zero is not allowed.");
            //                        return;
            //                    }
            //                    break;
            //                case '%':
            //                    if (num02 != 0)
            //                        result = num01 % num02;
            //                    else
            //                    {
            //                        Console.WriteLine("Error: Modulus by zero is not allowed.");
            //                        return;
            //                    }
            //                    break;
            //                default:
            //                    Console.WriteLine("Invalid operator. Please enter a valid operator (+, -, *, /, %).");
            //                    return;
            //            }
            //            Console.WriteLine($"Result: {result}");

            //        }
            //        else
            //        {
            //            Console.WriteLine("Invalid input. Please enter a valid integer.");
            //            return;
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid input. Please enter a valid operator.");
            //        return;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid integer.");
            //    return;
            //} 
            #endregion

            #region Clean Code and Protictive
            //Console.WriteLine("enter first number");
            //if (!int.TryParse(Console.ReadLine(), out int num01))
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid integer.");
            //    return;
            //}

            //Console.WriteLine("enter operator");
            //if (!char.TryParse(Console.ReadLine(), out char op))
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid operator.");
            //    return;
            //}

            //Console.WriteLine("enter seconed number");
            //if (!int.TryParse(Console.ReadLine(), out int num02))
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid integer.");
            //    return;
            //}

            //int result = 0;
            //switch (op)
            //{
            //    case '+': result = num01 + num02; break;
            //    case '-': result = num01 - num02; break;
            //    case '*': result = num01 * num02; break;
            //    case '/':
            //        if (num02 == 0)
            //        {
            //            Console.WriteLine("Error: Division by zero is not allowed.");
            //            return;
            //        }
            //        result = num01 / num02; break;
            //    case '%':
            //        if (num02 == 0)
            //        {
            //            Console.WriteLine("Error: Modulus by zero is not allowed.");
            //            return;
            //        }
            //        result = num01 % num02; break;
            //    default:
            //        Console.WriteLine("Invalid operator. Please enter a valid operator (+, -, *, /, %).");
            //        return;
            //}
            //Console.WriteLine($"{num01} {op} {num02} = {result}"); 
            #endregion
            #endregion
            #endregion

            #region Loops Statment
            // 10 steps to print 1 to 10
            //Console.WriteLine("1");
            //Console.WriteLine("2");
            //Console.WriteLine("3");
            //Console.WriteLine("4");
            //Console.WriteLine("5");
            //Console.WriteLine("6");
            //Console.WriteLine("7");
            //Console.WriteLine("8");
            //Console.WriteLine("9");
            //Console.WriteLine("10");

            #region For
            // start => i = 1
            // condition => i <= 10 => true
            // execute => Console.WriteLine(i)
            // increment => i++
            // condition => i <= 10 => true
            // execute => Console.WriteLine(i)
            // increment => i++

            //for (int i = 1; i <= 10; ++i) // => ++i
            //{
            //    Console.WriteLine(i);
            //}

            //int i = 1; //start
            //for(; ;i++)
            //{
            //    if (!(i <= 10))
            //        break; //condition

            //    if(i % 2 == 0)
            //        continue; //skip even numbers

            //    Console.WriteLine(i); //execute

            //    //i++; //increment
            //}
            #endregion

            #region While
            //Console.WriteLine("insert 0 if you want to exist");
            //string input = Console.ReadLine();
            //while(input != "0")
            //{
            //    Console.WriteLine($"you entered : {input}");
            //    Console.WriteLine("insert 0 if you want to exist");
            //    input = Console.ReadLine();
            //}

            //while(true)
            //{
            //    Console.WriteLine("enter first number");
            //    while (!int.TryParse(Console.ReadLine(), out int num01))
            //    {
            //        Console.WriteLine("Invalid input. Please enter a valid integer.");
            //    }

            //    //[quiz] write calculater program using while loop and switch statment and make it protictive
            //}

            #endregion

            #region Do While
            //do
            //{
            //    Console.WriteLine("Enter First number:");
            //} while (!int.TryParse(Console.ReadLine(), out int num01));
            #endregion

            #region Foreach
            //List<string> names = new List<string>()
            //{
            //    "ali",
            //    "ahmed",
            //    "sara"
            //};


            //for(int i = 0; i <= names.Count; i++)
            //{
            //    names[i] = $"hello {names[i]}";
            //    Console.WriteLine(names[i]);
            //}

            ////for reading 
            //foreach(string item in names)
            //{
            //    //item = $"hello {item}";
            //    Console.WriteLine(item);
            //}
            #endregion

            #region EX00
            //int num01, num02;
            //char op;
            //double result;

            ////do
            ////{
            ////    Console.WriteLine("Enter First number:");
            ////} while (!int.TryParse(Console.ReadLine(), out num01));

            //Console.WriteLine("enter first number");
            //while (!int.TryParse(Console.ReadLine(), out num01))
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid integer.");
            //}

            //do
            //{
            //    Console.WriteLine("enter operation (+ - * / %)");
            //} while (
            //!(char.TryParse(Console.ReadLine(), out op)  //true
            //&&
            //(op == '+' || op == '-' || op == '*' || op == '/' || op == '%')) //true
            //);

            //do
            //{
            //    Console.WriteLine($"enter last number{(op == '/' || op == '%' ? " and make sure not be zero" : "")}");
            //} while (
            //!int.TryParse(Console.ReadLine(), out num02) //false
            //||
            //((op == '/' || op == '%') && num02 == 0)  //true
            //);

            ////if (op == '+' || op == '-' || op == '*')
            ////{
            ////    Console.WriteLine("enter first number");
            ////    while (!int.TryParse(Console.ReadLine(), out num02))
            ////    {
            ////        Console.WriteLine("Invalid input. Please enter a valid integer.");
            ////    }
            ////}
            ////else
            ////{
            ////    do
            ////    {
            ////        Console.WriteLine($"enter last number and make sure not be zero");
            ////    } while(!int.TryParse(Console.ReadLine(), out num02) && num02 != 0);
            ////}

            //switch (op)
            //{
            //    case '+': result = num01 + num02; break;
            //    case '-': result = num01 - num02; break;
            //    case '*': result = num01 * num02; break;
            //    case '/': result = (double) num01 / num02; break;
            //    case '%': result = num01 % num02; break;
            //}

            #endregion
            #endregion

            #region block scope
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            ////Console.WriteLine(i); //invalid [out of scope]

            //while (double.TryParse(Console.ReadLine(), out double X))
            //{
            //    Console.WriteLine(X);
            //}

            //X = 3; //invalid [out of scope]

            //if (double.TryParse(Console.ReadLine(), out double X))
            //{
            //    int Y = 0;
            //    Console.WriteLine(X);
            //}

            //X = 10;
            //y = 20; //invalid[out of scope]


            //{
            //    int z = 0;
            //}

            //{
            //    int z = 0;
            //}
            #endregion

            #region arrays
            #region one D Array
            //int[] numbers;
            /////declare for reference from type array of integers
            /////referring to null => default value of refernce datatype
            /////4 bytes will be allocated in stack => CLR
            /////zero bytes will be allocated in heap => CLR

            //numbers = new int[5];
            ///// CLR allocate 20 bytes [5 * 4byte] in heap
            ///// intialized with the default value of int [0]

            //int[] numbers2 = { 1,2,3,4,5}; //syntax sugaer
            //numbers = new int[] { 1, 2, 3, 4, 5 };
            //numbers = new int[5] { 1, 2, 3, 4, 5 };
            //Console.WriteLine(numbers.Length);  // size
            //numbers[4] = 1;
            //numbers[5] = 2;

            //int[] numbers = new int[5];
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    do
            //    {
            //        Console.WriteLine($"Please enter the {i + 1} element of array:");
            //    } while (!int.TryParse(Console.ReadLine(), out numbers[i]));
            //}

            //foreach (var item in numbers)
            //{
            //    //int.TryParse(Console.ReadLine(), out item); //invalid
            //    Console.WriteLine(item);
            //}

            #endregion
            #region Two D Array [Rectangular]
            //int[,] Marks;
            //Marks = new int[3,5];
            //Console.WriteLine($"the size of array = {Marks.Length} , the number of dimensions = {Marks.Rank}");
            //Console.WriteLine($"number of rows = {Marks.GetLength(0)} , number of column = {Marks.GetLength(1)}");

            ///read elments of arry from user 
            ///print elemnts of arry to user
            ///write program to do that with protictive code and readable messages
            //for (int i = 0; i < Marks.GetLength(0); i++) //0,1,2
            //{
            //    for (int j = 0; j < Marks.GetLength(1); j++) //0,1,2,3,4
            //    {
            //        Console.WriteLine($"insert array elemnt Marks[{i},{j}]");
            //        Marks[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //[quiz] write same program with only one loop

            //for (int i = 0; i < Marks.Length; i++)
            //{
            //    int row = i / Marks.GetLength(1);
            //    int column = i % Marks.GetLength(1);
            //    Console.WriteLine($"insert array elemnt Marks[{row},{column}]");
            //    Marks[row, column] = int.Parse(Console.ReadLine());
            //}
            //foreach (var item in Marks)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Two D Array [Jaged array]
            //int[][,] numbers;
            //numbers = new int[3][,];

            //numbers[0] = new int[3, 5];
            //numbers[1] = new int[1, 3];
            //numbers[2] = new int[2, 1];

            //Console.WriteLine($"the size of array = {numbers.Length} , the number of dimensions = {numbers.Rank}");
            //Console.WriteLine($"the size of array = {numbers[0].Length} , the number of dimensions = {numbers[0].Rank}");
            //Console.WriteLine($"number of rows = {numbers[0].GetLength(0)} , number of column = {numbers[0].GetLength(1)}");

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    for (int j = 0; j < numbers[i].Length; j++)
            //    {
            //        int row = j / numbers[i].GetLength(1);
            //        int column = j % numbers[i].GetLength(1);
            //        while(!int.TryParse(Console.ReadLine(),out numbers[i][row, column]))
            //        {
            //            Console.WriteLine("invalid input, please enter a valid integer"); 
            //        }
            //    }
            //}
            #endregion
            #region Array methods
            //int[] numbers = { 8, 3, 4, 5, 6, 7, 9, 7, 1, 3, 8 };
            #region 1. class member method
            //Array.Sort(numbers);
            //Array.Reverse(numbers);
            //Array.Clear(numbers);
            //Console.WriteLine(Array.IndexOf(numbers,7)); //find first index => 5
            //Console.WriteLine(Array.LastIndexOf(numbers,7)); //find last index => 7

            //var arr = Array.CreateInstance(typeof(int), 10); //int[] arr = new int[10];
            #endregion
            #region 2. Object Member Methods [Non-Static Methods]
            //int[] newarr = new int[7];
            //numbers.CopyTo(newarr,0);
            //numbers.SetValue(18, 5); // numbers[5] = 18;

            //int[] dest = new int[numbers.Length];
            //numbers.CopyTo(dest, 0);

            //var dest01 = Array.CreateInstance(numbers.GetType().GetElementType(), numbers.Length);
            //numbers.CopyTo(dest01, 0);

            //foreach (int item in newarr)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion


            ///Ex01: write a program find the longest distance between 
            ///Two equal cells.
            ///In this example.The distance is 
            ///measured by the number Of cells- for example

            #endregion
            #endregion

            #region Boxing vs unBoxing
            //int x = 10; //value type
            //object obj = x; //parent = child; //boxing
            //x = 20;
            //Console.WriteLine(obj);


            //object[] data = new object[3];
            //data[0] = 10; //boxing => value type to reference type
            //data[1] = 3200.50m; //boxing => value type to reference type
            //data[2] = "ali"; // not boxing


            //ArrayList list = new ArrayList();
            //list.Add(10); //boxing
            //list.Add("test");
            //list.Add(true);


            //List<int> ints = new List<int>();
            //ints.Add(10);
            ////ints.Add("test"); notvalid

            //unboxing
            //object obj = 10; //boxing
            //int x = (int)obj; //child = parent; => explict casting //unboxing
            //Console.WriteLine(x);
            //double y = (double)obj; //unboxing
            //Console.WriteLine(y);

            //int a = 10;
            //double b = a;
            //Console.WriteLine(b);

            //animal = dog;
            //animal = cat;
            //dog = animal;

            //object O1 = new object();
            //O1 = "Ahmed"; //not boxing

            //O1 = 5;    // int[ValueType] to object[ReferenceType] -> Boxing
            //O1 = 'A';  // char[ValueType] to object[ReferenceType] -> Boxing
            //O1 = 3.3;  // double[ValueType] to object[ReferenceType] -> Boxing
            //O1 = true; // bool[ValueType] to object[ReferenceType] -> Boxing
            //O1 = new DateTime();  // DateTime[ValueType] to object[ReferenceType] -> Boxing
            //O1 = new DateOnly(); // DateOnly[ValueType] to object[ReferenceType] -> Boxing
            //O1 = new TimeOnly(); // TimeOnly[ValueType] to object[ReferenceType] -> Boxing
            #endregion

            #region Nullable types
            //nullable types : value type allows null as value
            // Assign Null as a Value for ValueType[int, char, bool, decimal, etc] Variables


            // int age = null; //invalid

            //int? age = null;   //nullable integer : allow int value + null
            //double? age01 = null; //nullable double : allow dounble value + null

            //int x = 8;
            //int? y = x; //nullable integer 
            //y = null;
            //x = (int) y; //explicit casting => unsafe casting

            //if (y is not null)
            //    x = (int)y; // => safe casting 

            //if (y.HasValue)
            //    x = y.Value;


            ////notification
            //string t = "test";
            //t = null;

            //string? tt = "test";
            //tt = null;

            //int x = 0; 
            //int? y = 10;

            //x = (int)y; // unsafe casting

            //if (y.HasValue)
            //    x = y.Value;

            //x = y.HasValue ? y.Value : 0;

            //x = y ?? 0;

            //x = y.HasValue ? y.Value : 0;

            ///////null coalescing operator
            //x = y ?? 0; 

            #endregion

            #region null propagation operator
            //int x = default; //0
            //int[] arr = default; //null

            //int length = arr.Length; //runtime error

            //if(arr is not null)
            //    length = arr.Length;

            //if (arr is not null)
            //{
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        Console.WriteLine(arr[i]);
            //    }
            //}

            //for (int i = 0; arr is not null && i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}

            //int? length = arr?.Length;

            //int length02 = arr?.Length ?? 0;

            //employee?.department?.name ?? "N/A";
            #endregion

            #region Function
            #region prototype and calling
            //PrintLine();

            //PrintLine(20,"$"); // passing parameters by postion
            //PrintLine(pattern: "$", number: 20); //passing parameters by name
            //PrintLine(20);

            //printline with default value of parmeters
            //PrintLine();
            //PrintLine(20);
            //PrintLine(pattern: "$");
            //PrintLine(20, "$");
            #endregion
            #endregion
        }

        #region functions
        #region Prototype and calling
        //print line of 10 element of "#";

        /// <summary>
        /// function to print line of 10 element of "#"
        /// object member method
        /// </summary>
        //public void PrintLine()
        //{
        //    for (int i = 1; i <= 10; i++)
        //    {
        //        Console.Write("#");
        //    }
        //    Console.WriteLine("");
        //}

        /// <summary>
        /// function to print line of 10 element of "#"
        /// class member method
        /// </summary>
        //public static void PrintLine()
        //{
        //    for (int i = 1; i <= 10; i++)
        //    {
        //        Console.Write("#");
        //    }
        //    Console.WriteLine("");
        //}


        //print line of number inserted by user and pattern inserted by user
        //public static void PrintLine(int number, string pattern)
        //{
        //    for (int i = 1; i <= number; i++)
        //    {
        //        Console.Write(pattern);
        //    }
        //    Console.WriteLine();
        //}

        //public static void PrintLine(int number = 10, string pattern = "#")
        //{
        //    for (int i = 1; i <= number; i++)
        //    {
        //        Console.Write(pattern);
        //    }
        //    Console.WriteLine();
        //}
        #endregion
        #endregion

    }

    //class test01
    //{
    //    void test()
    //    {
    //        //Program.PrintLine(); 
    //        //Program p01 = new Program();
    //        //p01.PrintLine(); 
    //    }
    //}
}
