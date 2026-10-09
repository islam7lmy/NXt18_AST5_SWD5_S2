using Commen;
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
            
            #endregion
            #endregion
        }
    } 
}
