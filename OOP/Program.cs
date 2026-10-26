//using Commen;
using Commen;
using Microsoft.VisualBasic;
using OOP.Abstraction;
using OOP.Abstraction02;
using OOP.Inhertiance;
using OOP.InterFaces;
using OOP.OperatorOverLoading;
using OOP.PolyMorphism_OverRiding;
using System;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Access Modifiers
            ///1. private:
            ///2. private protected => inhertance
            ///3. protected => inhertance
            ///4. inernal
            ///5. internal protected => inhertance
            ///6. public

            //PermissionItem CurrentPermission = PermissionItem.read | PermissionItem.write;
            //Permission.AddPErmission(ref CurrentPermission, PermissionItem.execute, PermissionItem.update);
            //Console.WriteLine(CurrentPermission);

            //rank r = rank.first;
            /// not valid because it's internal 
            /// only avilable in same asembly

            //TypeA a = new TypeA();
            ////a.x = 10; // invalid because x is private in typeA
            ////a.y = 20; // invalid because y is internal in typeA
            //a.z = 30; // valid because z is public in typeA

            //TypeC c = new TypeC();
            ////c.x = 10; // invalid because x is private in typeC
            ////c.y = 20; // invalid because y is internal in typeC
            //c.z = 30; // valid because z is public in typeC
            #endregion

            #region Struct 
            #region Ex 01: Point
            //Point p1;
            /// allocate 8 bytes uninitialized in stack memory for p1 
            /// Console.WriteLine(p1);// invalid because not intilized

            //p1.x = 10;
            //p1.y = 20;
            //Console.WriteLine(p1);

            //p1 = new Point();
            /// new key word just for constructor selection and not for memory allocation in stack memory
            ///that will initialize the struct fields with default values

            //p1 = new Point(10, 20);

            //Console.WriteLine(p1.x);
            //Console.WriteLine(p1.y); 
            #endregion
            #region Ex 02: Employee
            //Employee emp = new Employee(20);
            ////emp.Name = "ahmed mohmed ahmed ibrahem";
            //emp.SetName("ahmed mohmed ahmed ibrahem");
            //Console.WriteLine(emp.GetName());



            //emp.Salary = 10000000;
            //emp.Salary = 0; //2000
            ////emp.setsalary(10);
            ////Console.WriteLine(emp.getsalary());

            ////emp.SalaryProperty = 10;
            ////Console.WriteLine(emp.SalaryProperty);

            ////emp.Age = 30;
            //Console.WriteLine($"Age : {emp.Age}");

            ////Console.WriteLine(emp.Deductions());

            //Console.WriteLine(emp.Deductions);
            #endregion
            #region Ex 03 : PhoneBook
            //name => number
            //PhoneBook book = new PhoneBook(0);

            ////Console.WriteLine(book.numbers[0]);
            ////Console.WriteLine(book.numbers.Length);

            ////book.numbers = new string[100];

            //Console.WriteLine($"book size : {book.Size} , book elements count : {book.Count}");
            ////book.AddContact("ahmed", "01234567891", 0);
            //book.AddContact("ahmed", "01234567891");
            //book.AddContact("ibrahem", "01234567892");
            //book.AddContact("omr", "01234567893");
            //book.AddContact("ali", "01234567894");
            //book.AddContact("ali", "01234567894");
            //book.AddContact("ali", "01234567894");
            //book.AddContact("ali", "01234567894");
            //book.AddContact("ali", "01234567894");
            //book.AddContact("ali", "01234567894");
            //Console.WriteLine($"book size : {book.Size} , book elements count : {book.Count}");
            ////book.RemoveContact("ahmed");
            //Console.WriteLine($"book size : {book.Size} , book elements count : {book.Count}");

            ////book.SetNumber("ahmed", "01248957524");
            ////Console.WriteLine(book.GetNumber("ahmed"));


            //book["ahmed"] = "01248957524";
            //Console.WriteLine(book["ahmed"]);


            //for (int i = 0; i < book.Count; i++)
            //{
            //    Console.WriteLine(book[i]);
            //   // Console.WriteLine($"{book.name[i]} => {book.number[i]}");
            //}
            #endregion
            #endregion

            #region Class
            #region Ex : Car
            //Car c1;
            //declare reference of type car refer to null
            //allocate 4 bytes uninsitlized in stack
            //zero bytes will be allocate in heab
            //Console.WriteLine(c1); 

            //c1.Id = 1;
            //c1.Model = "BMW";
            //c1.Speed = 220;

            //c1 = new Car();
            //c1 = new Car(10);
            //c1 = new Car(10,"BMW");
            //c1 = new Car(10,"BMW",220);

            //c1.Id = 20;
            //c1.Model = "BYD";
            //c1.Speed = 320;


            //Point p1;
            ////allocate 8 bytes uninsitlized in stack [x 4byte , y 4byte]
            ////Console.WriteLine(p1);

            ////p1.x = 10;
            ////p1.y = 20;
            ////Console.WriteLine(p1);

            //p1 = new Point(); 
            #endregion
            #region Inhertance
            //Parent p = new Parent(10);
            //p.MyFunc01();
            //p.MyFunc02();
            #endregion
            #region Class Vs Struct
            //Car c1 = new Car();
            //Car c2 = c1; // Shallow copy => copy just reference 
            //c2.Id = 99;
            //Console.WriteLine(c1.Id); // 99 because c1 and c2 refer to the same object in heab
            ///Reference Type => stored refernece in stack and object in heab
            ///instiliztion => must call constructor
            ///clr will always generate empty parameterless constructor ,if no user-defined constructor exists 
            ///clr will no longer generate empty parameterless constructor, if u write user-defined constructor
            ///default constructor => do nothing 
            ///Supports inheritance => [all access modifers]
            ///used for complex objects and behaviors


            //Point P1 = new Point();
            //Point P2 = P1; // deep copy => p2 is a copy of p1 but refer to different memory address
            //P2.x = 10;
            //P2.y = 10;
            //P2.x = 99;
            //Console.WriteLine(P1.x); // 0 
            ///Vlaue Type => stored in stack
            ///instiliztion => mustnot call constructor
            ///clr will always Generate Parameterless Constructor
            ///default constructor => initialize the attributes of struct with their default values
            ///Cannot inherit from another struct =>  [private, internal, public]
            ///often used for small and simple data => recomanded 16 bytes or less
            #endregion

            //PhoneBook book = new PhoneBook();
            //book.AddContact("ahmed", "0123456789");
            //book.AddContact("ali", "0123456788");
            //book.AddContact("omr", "0123456787");

            //PhoneBook book01 = book;
            //book01["ahmed"] = "00000000000000";

            ////book01 = new PhoneBook();
            //book01.names = new string[10];
            //book01.numbers = new string[10];

            //Console.WriteLine(book["ahmed"]);
            //Console.WriteLine(book01["ahmed"]);
            #endregion

            #region PolyMophism
            #region OverLoading
            //int num1 = 10, num2 = 20;
            //Sum(num1, num2);

            //double num03 = 10.5, num04 = 15.5;
            //Sum(num03, num04);

            //int x = 10;
            //x.ToString(); //=> has 4 overloading
            #endregion
            #region OverRiding
            //Commen.TypeA typeA = new Commen.TypeA();
            //PolyMorphism_OverRiding.TypeA A = new PolyMorphism_OverRiding.TypeA();

            //TypeA typeA = new TypeA(10);
            //typeA.MyFun01();
            //typeA.MyFun02();


            //TypeB typeB = new TypeB(10, 20);
            //typeB.MyFun01();
            //typeB.MyFun02();
            #endregion
            #endregion

            #region Binding
            //PolyMorphism_OverRiding.Employee emp;
            ///// allocate 4 byte for reference from type employee in stack refer to null

            //emp = new PolyMorphism_OverRiding.Employee();
            /// allocate object in heap

            #region What is Binding
            /// reference from base type => object from derived type

            //PolyMorphism_OverRiding.Employee emp01;

            //emp01 = new FullTimeEmployee(); //binding

            //emp01.Id = 10;
            //emp01.Name = "ahmed";
            //emp01.Age = 30;
            ////emp01.Salary = 10; //not valid

            //emp01.ShowRole(); //hiding  => static => will run ralted to reference 
            //emp01.PrintDetails(); // overriding => dynamic => will run ralted to object 



            //emp01 = new PartTimeEmployee();
            //emp01.Id = 10;
            //emp01.Name = "ahmed";
            //emp01.Age = 30;
            ////emp01.HourRate = 10; //not Valid
            ////emp01.CountOfHour = 20; //not valid

            //emp01.ShowRole();
            //emp01.PrintDetails();



            //emp01 = new FreeLanceEmployee();
            //emp01.Id = 10;
            //emp01.Name = "ahmed";
            //emp01.Age = 30;
            ////emp01.ProjectPrice = 1000; //invalid

            //emp01.ShowRole();
            //emp01.PrintDetails();

            #endregion

            #region Not binding
            //FullTimeEmployee emp = (FullTimeEmployee)new PolyMorphism_OverRiding.Employee(); //not binding

            ///animal = dog 
            ///animal = cat 
            ///dog = (dog) animal 
            #endregion

            #region why Binding
            ///class member method to process employees with all types 
            //FullTimeEmployee fullTime = new FullTimeEmployee();
            //PartTimeEmployee partTime = new PartTimeEmployee();
            //FreeLanceEmployee freeLance = new FreeLanceEmployee();
            //DayFullTimeEmployee dayFullTimeEmployee = new DayFullTimeEmployee();
            //NightFullTimeEmployee nightFullTimeEmployee = new NightFullTimeEmployee();

            //ProcessEmployee(fullTime);
            //ProcessEmployee(partTime);
            //ProcessEmployee(freeLance);
            //ProcessEmployee(dayFullTimeEmployee);
            //ProcessEmployee(nightFullTimeEmployee);

            #endregion

            #region More Practise on Binding
            //TypeA typeA = new TypeC(1, 2, 3);
            //typeA.A = 11;
            ////typeA.B = 10;
            ////typeA.C = 20;

            //typeA.MyFun01(); //typeA
            //typeA.MyFun02(); //typeC 

            //TypeB typeB = new TypeC(1, 2, 3);
            //typeB.A = 11;
            //typeB.B = 10;
            ////typeA.C = 20;

            //typeB.MyFun01(); //typeB
            //typeB.MyFun02(); //typeC

            //TypeA typeA1 = new TypeE(1, 2, 3, 4, 5);
            //TypeB typeB1 = new TypeE(1, 2, 3, 4, 5);
            //TypeC typeC1 = new TypeE(1, 2, 3, 4, 5);
            //TypeD typeD1 = new TypeD(1, 2, 3, 4);
            //TypeD typeD2 = new TypeE(1, 2, 3, 4, 5);
            //TypeD typeD3 = new TypeF(1, 2, 3, 4, 5);

            //typeA1.MyFun02(); //typeC
            //typeB1.MyFun02(); //typeC
            //typeC1.MyFun02(); //typeC
            //typeD1.MyFun02(); //typeD
            //typeD2.MyFun02(); //typeE
            //typeD3.MyFun02(); //
            #endregion
            #endregion

            #region Interfaces
            #region Ex01
            //IMytype mytype = new IMytype();//not valid

            //IMytype mytype = new MyType();
            //mytype.Salary = 20;
            //mytype.Myfun();
            //mytype.Print();

            //MyType myType02 = new MyType();
            //myType02.Salary = 20;
            //myType02.Myfun();
            //myType02.Print(); //not valid 
            #endregion
            #region Ex02
            ///SeriesByTwo seriesByTwo = new SeriesByTwo();
            //Console.WriteLine(seriesByTwo.Current);
            //seriesByTwo.Current = 20;

            //Print10NumbersFromSeries(seriesByTwo);

            //SeriesByThree seriesByThree = new SeriesByThree();
            //Print10NumbersFromSeries(seriesByThree);

            //SeriesBySeven seriesBySeven = new SeriesBySeven();
            //Print10NumbersFromSeries(seriesBySeven);

            //SeriesByFive seriesByFive = new SeriesByFive();
            //seriesByFive.Current = 100;
            #endregion
            #region Implment Interface Implicitly Vs Implment Interface Explicitly
            //InterFaces.Car car = new InterFaces.Car();
            //car.Speed = 20;
            //car.Backward();
            //car.Forward();
            //car.Left();
            //car.Right();


            //AirPlan airPlan = new AirPlan();
            //airPlan.Speed = 20;
            //not valid => because it's explicit implmintation
            //airPlan.Backward();
            //airPlan.Forward();
            //airPlan.Left();
            //airPlan.Right(); 

            //IMoveable moveablePlan = airPlan;
            //moveablePlan.Speed = 100;
            //moveablePlan.Backward();
            //moveablePlan.Forward();
            //moveablePlan.Left();
            //moveablePlan.Right();

            //IFlyable flyablePlan = airPlan;
            //flyablePlan.Speed = 500; // => implicit implmentation
            //flyablePlan.Backward();
            //flyablePlan.Forward();
            //flyablePlan.Left();
            //flyablePlan.Right();
            #endregion
            #region Shallow Copy Vs Deep Copy
            //int x = 10;
            //int y = 20;
            //y = x;
            //y = 30;
            //Console.WriteLine(x);
            //Console.WriteLine(y);

            //int[] Arr01 = { 1, 2, 3 };
            //int[] Arr02 = { 4, 5, 6 };

            //Console.WriteLine($"Arr01 = {Arr01.GetHashCode()}");
            //Console.WriteLine($"Arr02 = {Arr02.GetHashCode()}");

            #region Shallow Copy
            //Arr02 = Arr01;

            //Console.WriteLine("after Shallow copy");

            //Console.WriteLine($"Arr01 = {Arr01.GetHashCode()}");
            //Console.WriteLine($"Arr02 = {Arr02.GetHashCode()}");

            //Arr02[0] = 99;
            //Console.WriteLine(Arr01[0]);
            #endregion

            #region Deep Copy
            ////int[] test = (int[]) new object(); 
            //Arr02 = (int[]) Arr01.Clone();
            //Console.WriteLine("after Deep copy");

            //Console.WriteLine($"Arr01 = {Arr01.GetHashCode()}");
            //Console.WriteLine($"Arr02 = {Arr02.GetHashCode()}");

            //Arr02[0] = 99;
            //Console.WriteLine(Arr01[0]);
            #endregion
            #endregion
            #region Built-In Interface ICloneable
            //OOP.InterFaces.Employee emp01 = new InterFaces.Employee();
            //emp01.Id = 20;
            //emp01.Name = "ahmed";
            //emp01.Address = "cairo";
            //emp01.Salary = 10000;


            //OOP.InterFaces.Employee emp02 = new InterFaces.Employee()
            //{
            //    Id = 20,
            //    Name = "Ahmed",
            //    Address = "Cairo",
            //    Salary = 10000,
            //};

            //Console.WriteLine($"emp01 : {emp01.GetHashCode()}");
            //Console.WriteLine($"emp02 : {emp02.GetHashCode()}");

            #region Shallow
            //emp02 = emp01;
            //Console.WriteLine("After shallow");
            //Console.WriteLine($"emp01 : {emp01.GetHashCode()}");
            //Console.WriteLine($"emp02 : {emp02.GetHashCode()}");
            #endregion

            #region Deep
            //OOP.InterFaces.Employee emp03 = new OOP.InterFaces.Employee(emp01);

            //emp02 = OOP.InterFaces.Employee.DeepCopy(emp01);
            //emp01.Id = 100;
            //emp02 =(OOP.InterFaces.Employee) emp01.Clone();
            //Console.WriteLine($"emp01 : {emp01.GetHashCode()}");
            //Console.WriteLine($"emp02 : {emp02.GetHashCode()}");
            //#endregion
            //Console.WriteLine(emp01.ToString());
            //Console.WriteLine(emp02.ToString());
            #endregion

            #endregion
            #region Built-In Interface IComparable
            //int[] arr = { 9, 8, 11, 7, 2, 3, 4, 5, 1 };
            ////Array.Sort(arr);
            //foreach (int i in arr)
            //{
            //    Console.Write($"{i} \t");
            //}
            //Console.WriteLine();
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = 0; j < arr.Length - i - 1; j++)
            //    {
            //        if (arr[j].CompareTo(arr[j + 1]) > 0)
            //        {
            //            Swap(ref arr[j], ref arr[j + 1]);
            //        }

            //    }
            //}
            //foreach (int i in arr)
            //{
            //    Console.Write($"{i} \t");
            //}
            //Console.WriteLine();


            //string[] strings = { "omr", "Ahmed", "Ali", };
            //Array.Sort(strings);
            //for (int i = 0; i < strings.Length; i++)
            //{
            //    for (int j = 0; j < strings.Length - i - 1; j++)
            //    {
            //        if (strings[j].CompareTo(strings[j + 1]) > 0)
            //        {
            //            Swap(ref strings[j], ref strings[j + 1]);
            //        }

            //    }
            //}

            //InterFaces.Employee[] employees =
            //{
            //    new InterFaces.Employee() { Id = 10 , Name = "Ahmed" , Address = "Cairo", Salary = 10_000},
            //    new InterFaces.Employee() { Id = 20 , Name = "Ali" , Address = "Alex", Salary = 4_000},
            //    new InterFaces.Employee() { Id = 30 , Name = "Omar" , Address = "Asyut", Salary = 8_000},
            //    new InterFaces.Employee() { Id = 40 , Name = "Amr" , Address = "Fayoum", Salary = 5_000},
            //};

            //Array.Sort(employees);
            ////for (int i = 0; i < employees.Length; i++)
            ////{
            ////    for (int j = 0; j < employees.Length - i - 1; j++)
            ////    {
            ////        if (employees[j].CompareTo(employees[j + 1]) > 0)
            ////        {
            ////            Swap(ref employees[j], ref employees[j + 1]);
            ////        }

            ////    }
            ////}


            //foreach (InterFaces.Employee emp in employees)
            //{
            //    Console.WriteLine(emp.ToString());
            //}
            #endregion
            #endregion

            #region Abstraction
            //Shape s = new Shape(); //not valid
            //Shape squ = new Squere();
            //squ.Dim01 = 10;
            //Console.WriteLine(squ.Perimeter);
            //Console.WriteLine(squ.Area);
            //squ.test();

            //OOP.Abstraction02.Squere sq = new OOP.Abstraction02.Squere(10);
            //IShape ss = new OOP.Abstraction02.Squere(10);
            #endregion

            #region operator overLoading
            //5 + 7i => complex
            //Complex c1 = new Complex(1, 2);
            //Complex c2 = new Complex(3, 4);
            //Complex c3 = new Complex(5, 6);
            //Complex c5 = default;

            //Complex c4 = c1 + c2 + c3 + c5;
            //Console.WriteLine(c4);

            //Console.WriteLine(c1++); //print => 1+2i then value => 2+3i
            //Console.WriteLine(++c1); //value => 3+4i then print => 3+4i
            //Console.WriteLine(c1--); //print => 3+4i then value => 2+3i
            //Console.WriteLine(--c1); //value => 1+2i then print => 1+2i
            //Console.WriteLine(c1);   //print => 1+2i

            #endregion

        }

        #region PolyMorphism 1. function overloading
        ///1. datatype of parameters
        ///2. count number of parameters
        ///3. reorder parameters if not same datatype

        public static int Sum(int x, int y)
        {
            return x + y;
        }
        public static double Sum(double x, double y)
        {
            return x + y;
        }

        public static double Sum(double x, double y, double z)
        {
            return x + y;
        }

        public static int Sum(int x, short y)
        {
            return x + y;
        }
        //public static double Sum(int x, short y) //not overloading
        //{
        //    return x + y;
        //}
        public static int Sum(short y, int x)
        {
            return x + y;
        }
        #endregion

        #region Binding
        public static void ProcessEmployee(PolyMorphism_OverRiding.Employee emp)
        {
            if (emp is not null)
            {
                emp.ShowRole();
                emp.PrintDetails();
            }
        }

        //public static void ProcessEmployee(FullTimeEmployee emp)
        //{
        //    if (emp is not null)
        //    {
        //        emp.ShowRole();
        //        emp.PrintDetails();
        //    }
        //}

        //public static void ProcessEmployee(PartTimeEmployee emp)
        //{
        //    if (emp is not null)
        //    {
        //        emp.ShowRole();
        //        emp.PrintDetails();
        //    }
        //}

        //public static void ProcessEmployee(FreeLanceEmployee emp)
        //{
        //    if (emp is not null)
        //    {
        //        emp.ShowRole();
        //        emp.PrintDetails();
        //    }
        //}
        #endregion

        #region Interfaces
        public static void Print10NumbersFromSeries(ISeries series)
        {
            for (int i = 0; i < 10; i++)
            {
                //series.Current = 20; //not valid outer class
                Console.Write(series.Current);
                Console.Write("\t");
                series.GetNext();
            }
            Console.WriteLine();
            series.Reset();
            Console.WriteLine(series.Current);
        }

        //public static void Print10NumbersFromSeries(SeriesByTwo series)
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.WriteLine(series.Current);
        //        series.GetNext();
        //    }
        //    series.Reset();
        //}

        //public static void Print10NumbersFromSeries(SeriesByThree series)
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.WriteLine(series.Current);
        //        series.GetNext();
        //    }
        //    series.Reset();
        //}

        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        public static void Swap(ref string a, ref string b)
        {
            string temp = a;
            a = b;
            b = temp;
        }
        public static void Swap(ref InterFaces.Employee a, ref InterFaces.Employee b)
        {
            InterFaces.Employee temp = a;
            a = b;
            b = temp;
        }

        public static void Swap(ref object a, ref object b)
        {
            object temp = a;
            a = b;
            b = temp;
        }

        public static void Swap(ref IComparable a, ref IComparable b)
        {
            IComparable temp = a;
            a = b;
            b = temp;
        }

        public static void Sorting(IComparable[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j].CompareTo(arr[j + 1]) > 0)
                    {
                        Swap(ref arr[j], ref arr[j + 1]);
                    }
                }
            }
        }
        #endregion
    }
}
