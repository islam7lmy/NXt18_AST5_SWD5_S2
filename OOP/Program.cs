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
            Employee emp = new Employee();
            emp.Salary = 10000000;

            #endregion
            #endregion
        }
    }
}
