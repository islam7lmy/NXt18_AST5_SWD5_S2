using Commen;
using OOP.Inhertiance;
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

            #endregion
            #endregion

            #region Binding

            #endregion

            #region Interfaces

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
    }
}
