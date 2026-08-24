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
            int X = 1_000_000_000; //_ discard to  imporve readabilty

            double d1 = 15.3;
            float f1 = 15.3f;
            decimal m1 = 15.3m;
            #endregion
        }
    }
}
