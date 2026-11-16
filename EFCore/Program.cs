using EFCore.Contexts;
using EFCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace EFCore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region How To Migrate
            //to add db to sql server:

            ///1.Install-Package "Microsoft.EntityFrameworkCore.SqlServer"
            ///2.create Compnydbcontext that inhert DbContext
            ///3.override OnConfiguring and set db conection string
            ///4.add dbset<> for class (Models) that want to be tables
            ///5.install Package Microsoft.EntityFrameworkCore.Tools
            ///6.Add-Migration "InitialCreate"
            ///7.Update-Database
            #endregion

            #region CRUD Operations [create, read, update, delete]
            #region How To Manage Connection
            ///unManaged Code
            //CompanyDbContext db = new CompanyDbContext();
            //try
            //{
            //    ///crud operation
            //}
            //finally
            //{
            //    //dispose
            //    db.Dispose(); //close connection
            //}

            //using (CompanyDbContext db2 = new CompanyDbContext()) //Managed Code
            //{
            //    //crud operations
            //}

            ///code block
            /// Crud Operation
            //using CompanyDbContext db3 = new CompanyDbContext(); //Managed Code
            // code
            // Crud
            // code
            // crud 
            #endregion

            //using CompanyDbContext db = new CompanyDbContext();

            //Employee emp = new Employee()
            //{
            //    FirstName = "Ahmed",
            //    Salary = 3000,
            //    Age = 30
            //};

            //Department dept = new Department() { Name = "HR" };

            #region Create
            //db.Employees.Add(emp);
            //db.Add(emp);
            ////db.Set<Employee>().Add(emp);
            //db.Set<Department>().Add(dept);
            //db.Entry(emp).State = EntityState.Added;
            //db.SaveChanges();

            //Console.WriteLine(db.Entry(emp).State);
            //db.Employees.Add(emp);
            //Console.WriteLine(db.Entry(emp).State);
            //db.SaveChanges();
            //Console.WriteLine(db.Entry(emp).State);

            #endregion

            #region Read
            #region Multi Elements
            //var result01 = (from em in db.Employees
            //                where em.EmployeeId == 1
            //                select em
            //                );//select * from employees where employeeid = 1
            //var result02 = db.Employees.Where(e => e.EmployeeId == 1);//select * from employees where employeeid = 1
            //var result03 = result02.ToList(); // excuite for IQuaryble [tolist , foreach]


            ////select * from employees => in db Get all Employees and save it in local memory
            ////=> then filter data in local memory to get employee with id == 1  
            //var result = db.Employees.ToList().Where(e => e.EmployeeId == 1);

            //foreach (var item in result02)
            //{
            //    Console.WriteLine($"Id : {item.EmployeeId} , firstname : {item.FirstName} , salary : {item.Salary} , age : {item.Age}");
            //}
            #endregion
            #region Single Element
            //var Emp = (from e in db.Employees
            //           where e.EmployeeId == 1
            //           //where e.Age == 40
            //           select e)
            ////           //.First(); //top(1) => select top(1) * from Employees where employeeid = 1
            ////           //.FirstOrDefault();//top(1) => select top(1) * from Employees where employeeid = 1 , null
            ////           //.Single(); ////top(2) => select top(2) * from Employees where employeeid = 1
            //           .SingleOrDefault(); ////top(2) => select top(2) * from Employees where employeeid = 1

            ////Console.WriteLine($"Id : {Emp.EmployeeId} , firstname : {Emp.FirstName} , salary : {Emp.Salary} , age : {Emp.Age}");

            //Emp.FirstName = "koko";

            //var Emp01 = db.Employees.Find(2);
            //Console.WriteLine($"Id : {Emp01.EmployeeId} , firstname : {Emp01.FirstName} , salary : {Emp01.Salary} , age : {Emp01.Age}");

            #endregion
            #region Tracking vs No Tracking
            //db.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            //var Emp = (from e in db.Employees
            //           where e.EmployeeId == 1
            //           select e
            //            )
            //            //.AsNoTracking()
            //            .AsTracking()
            //            .FirstOrDefault();
            //Console.WriteLine(db.Entry(Emp).State);
            #endregion
            #endregion

            #region Update
            //var Emp = db.Employees.Where(e => e.EmployeeId == 1).FirstOrDefault();
            //if (Emp is not null)
            //{
            //    Emp.FirstName = "Updated";
            //    Emp.Salary = 6000;
            //    Console.WriteLine(db.Entry(Emp).State);
            //    db.SaveChanges();
            //    Console.WriteLine(db.Entry(Emp).State);
            //}
            #endregion

            #region Delete
            //var Emp = db.Employees.Where(e => e.EmployeeId == 1).FirstOrDefault();
            //if(Emp is not null)
            //{
            //    Console.WriteLine(db.Entry(Emp).State);
            //    db.Employees.Remove(Emp);
            //    Console.WriteLine(db.Entry(Emp).State);
            //    db.SaveChanges();
            //    Console.WriteLine(db.Entry(Emp).State);
            //}
            #endregion
            #endregion
        }
    }
}
