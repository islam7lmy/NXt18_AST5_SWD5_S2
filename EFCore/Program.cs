using EFCore.Contexts;
using EFCore.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Drawing;

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

            #region Mapping RealtionShip
            ///pk => fk
            ///3. how to implment in code
            ///     3.1 fk property [class name + pk name]
            ///     3.2 Navigational property [class name]
            ///     by defaulty 
            #endregion

            #region Mapping Inheritance
            //using InheritanceDbContext dbContext = new InheritanceDbContext();
            //FullTime fullTime = new FullTime()
            //{
            //    Name = "Ahmed",
            //    Salary = 6000,
            //    HiringDate = DateOnly.FromDateTime(DateTime.Now),
            //    Age = 22
            //};

            //PartTime partTime = new PartTime()
            //{
            //    Name = "Ali",
            //    HoureRate = 300,
            //    HoursCount = 10,
            //    Age = 20
            //};
            #region TPH
            #region Two DbSet
            //dbContext.FullTimePerson.Add(fullTime);
            //dbContext.PartTimePerson.Add(partTime);
            //dbContext.SaveChanges();

            //var fulltimeperson = (from f in dbContext.FullTimePerson select f).ToList();
            //var partimeperson = (from f in dbContext.PartTimePerson select f).ToList();
            #endregion
            #region One DbSet
            //dbContext.Persons.Add(fullTime);
            //dbContext.Persons.Add(partTime);
            //dbContext.SaveChanges();

            //var fulltimeperson = (from f in dbContext.Persons.OfType<FullTime>()
            //                      select f).ToList();

            //var partimeperson = (from f in dbContext.Persons.OfType<PartTime>()
            //                     select f).ToList();

            //var persons = (from f in dbContext.Persons select f).ToList();
            #endregion

            //Console.WriteLine();
            //Console.WriteLine("****************fulltimeperson**************");
            //foreach (var item in fulltimeperson)
            //    Console.WriteLine($"{item.Id} :: {item.Name} :: {item.Salary}");
            //Console.WriteLine();
            //Console.WriteLine("****************PartTimeperson**************");
            //foreach (var item in partimeperson)
            //    Console.WriteLine($"{item.Id} :: {item.Name} :: {item.HoureRate}");
            //Console.WriteLine();
            //Console.WriteLine("****************Persons**************");
            //foreach (var item in persons)
            //{
            //    Console.WriteLine($"{item.Id} :: {item.Name} :: {item.Age}");
            //}
            #endregion

            #region work with multi dbcontext
            ///Add-Migration "TPHInitialCreate" -Context "InheritanceDbContext" -OutputDir "MigrationsForInheritanceDbContext"

            ///Update-Database -Context "InheritanceDbContext"
            #endregion
            #endregion

            #region Loading Navigational Properties
            //using CompanyDbContext db = new CompanyDbContext();
            #region By Default
            //var Emp = (from e in db.Employees
            //           where e.Id == 1
            //           select e).FirstOrDefault();

            //if(Emp is not null)
            //    Console.WriteLine($"Employee: Id = {Emp.Id}, Name = {Emp.Name}, Department = {Emp.Department?.Name ?? "N/A"}");


            //var Dept = (from d in db.Set<Department>()
            //                  where d.DeptId == 10
            //                  select d).FirstOrDefault();
            //if(Dept is not null)
            //{
            //    Console.WriteLine($"Department: Id = {Dept.DeptId}, Name = {Dept.Name}");
            //    foreach (var emp in Dept.Employees ?? new List<Employee>())
            //    {
            //        Console.WriteLine($".............Employee: Id = {emp.Id}, Name = {emp.Name}, Department = {emp.Department?.Name ?? "NA"}");
            //    }
            //}
            #endregion

            #region Explicit 
            //var Emp = (from e in db.Employees
            //           where e.Id == 1
            //           select e).FirstOrDefault();

            //if (Emp is not null)
            //{
            //    db.Entry(Emp).Reference(e => e.Department).Load(); //loading one explicit
            //    Console.WriteLine($"Employee: Id = {Emp.Id}, Name = {Emp.Name}, Department = {Emp.Department?.Name ?? "N/A"}");
            //}


            //var Dept = (from d in db.Set<Department>()
            //            where d.DeptId == 10
            //            select d).FirstOrDefault();

            //var DeptList = (from d in db.Set<Department>()
            //                //where d.DeptId == 10
            //                select d).ToList(); //one quary + n

            //if (Dept is not null)
            //{
            //    db.Entry(Dept).Collection(d => d.Employees).Load(); //loading multi explicit
            //    Console.WriteLine($"Department: Id = {Dept.DeptId}, Name = {Dept.Name}");
            //    foreach (var emp in Dept.Employees ?? new List<Employee>())
            //    {
            //        Console.WriteLine($".............Employee: Id = {emp.Id}, Name = {emp.Name}, Department = {emp.Department?.Name ?? "NA"}");
            //    }
            //}

            //foreach (var dept in DeptList)
            //{
            //    db.Entry(dept).Collection(d => d.Employees).Load(); //loading multi explicit
            //    Console.WriteLine($"Department: Id = {dept.DeptId}, Name = {dept.Name}");
            //    foreach (var emp in dept.Employees ?? new List<Employee>())
            //    {
            //        Console.WriteLine($".............Employee: Id = {emp.Id}, Name = {emp.Name}, Department = {emp.Department?.Name ?? "NA"}");
            //    }
            //}
            #endregion

            #region Eager
            //select * from employee e left outer join department d on e.deptid = d.deptid
            //var Emp = (from e in db.Employees
            //           .Include(e => e.Department)
            //               //.Include(e => e.Department).ThenInclude(d=>d.Project).ThenInclude(p=>p.Products)
            //               //.Include(e=>e.Department).ThenInclude(d=>d.Services)
            //           where e.Id == 1
            //           select e).FirstOrDefault();

            //if (Emp is not null)
            //{
            //    //db.Entry(Emp).Reference(e => e.Department).Load(); //loading one explicit
            //    Console.WriteLine($"Employee: Id = {Emp.Id}, Name = {Emp.Name}, Department = {Emp.Department?.Name ?? "N/A"}");
            //}


            //var DeptList = (from d in db.Set<Department>()
            //                .Include(d => d.Employees)
            //                    //where d.DeptId == 10
            //                select d).ToList(); //one quary + n

            //foreach (var dept in DeptList)
            //{
            //    //db.Entry(dept).Collection(d => d.Employees).Load(); //loading multi explicit
            //    Console.WriteLine($"Department: Id = {dept.DeptId}, Name = {dept.Name}");
            //    foreach (var emp in dept.Employees ?? new List<Employee>())
            //    {
            //        Console.WriteLine($".............Employee: Id = {emp.Id}, Name = {emp.Name}, Department = {emp.Department?.Name ?? "NA"}");
            //    }
            //}
            #endregion

            #region Lazy [Loding Imlicitly]
            ///1.install package Microsoft.EntityFrameworkCore.proxies
            ///2.in dbcontext onconfguring => optionBuilder.UseLazyLoadingProxies(True);
            ///3.make class public to can access from anthor assemply OR [InternalsVisibleTo]
            ///4.make Navigational Property virtual

            //var Emp = (from e in db.Employees
            //           where e.Id == 1
            //           select e).FirstOrDefault();

            //if (Emp is not null)
            //{
            //    Console.WriteLine($"Employee: Id = {Emp.Id}, Name = {Emp.Name}, Department = {Emp.Department?.Name ?? "N/A"}");
            //}

            //var Dept = (from d in db.Set<Department>()
            //            where d.DeptId == 10
            //            select d).FirstOrDefault();
            //if (Dept is not null)
            //{
            //    db.Entry(Dept).Collection(d => d.Employees).Load(); //loading multi explicit
            //    Console.WriteLine($"Department: Id = {Dept.DeptId}, Name = {Dept.Name}");
            //    foreach (var emp in Dept.Employees ?? new List<Employee>())
            //    {
            //        Console.WriteLine($".............Employee: Id = {emp.Id}, Name = {emp.Name}, Department = {emp.Department?.Name ?? "NA"}");
            //    }
            //}
            #endregion

            #region Explicit vs Eager vs Lazy
            ///first enbale Lazy Loading Mode in app
            ///if navigational property is one => Eager
            ///if navigational property is many => dependes
            ///........if  [Requierd] => Eager => order & order item
            ///........if  [optional] => Lazy => department & employees
            #endregion
            #endregion

            #region LINQ Join Operators - Join()
            //using CompanyDbContext db = new CompanyDbContext();
            #region Inner Join
            #region Query Exprission
            //var Result = from D in db.Set<Department>()
            //             join E in db.Employees
            //             on D.DeptId equals E.DepartmentDeptId
            //             select new
            //             {
            //                 EmpId = E.Id,
            //                 EmpName = E.Name,
            //                 DeptId = D.DeptId,
            //                 DeptName = D.Name
            //             };

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Falunt Exprission
            //var Result = db.Set<Department>().Join(
            //    db.Employees, //y
            //    d=>d.DeptId,
            //    e=>e.DepartmentDeptId,
            //    (x,y) => new
            //    {
            //        EmpId = y.Id,
            //        EmpName = y.Name,
            //        DeptId = x.DeptId,
            //        DeptName = x.Name
            //    });


            //var Result = db.Employees.Join(
            //    db.Set<Department>(), //x
            //    e => e.DepartmentDeptId,
            //    d => d.DeptId,

            //    (y,x) => new
            //    {
            //        EmpId = y.Id,
            //        EmpName = y.Name,
            //        DeptId = x.DeptId,
            //        DeptName = x.Name
            //    });

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #endregion
            #region Group Join
            //var Result = from D in db.Set<Department>()
            //             join E in db.Employees
            //             on D.DeptId equals E.DepartmentDeptId into Emps
            //             select new
            //             {
            //                 Department = D,
            //                 Employees = Emps
            //             };

            //var Result = db.Set<Department>().GroupJoin(
            //    db.Employees,
            //    d => d.DeptId,
            //    e => e.DepartmentDeptId,
            //    (x, y) => new
            //    {
            //        Department = x,
            //        Employees = y
            //    });
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item.Department.Name);
            //    Console.WriteLine($"\t{{");
            //    foreach (var emp in item.Employees)
            //        Console.WriteLine($"\t\tEmployee: Id = {emp.Id}, Name = {emp.Name}");
            //    Console.WriteLine($"\t}}");
            //}
            #endregion
            #region Left Outer Join
            //var Result = from D in db.Set<Department>()
            //             join E in db.Employees
            //             on D.DeptId equals E.DepartmentDeptId
            //             into DepartmentEmployees
            //             //////////////////////////////////////////
            //             from emp in DepartmentEmployees.DefaultIfEmpty()
            //             select new
            //             {
            //                 Department = D,
            //                 Employee = emp
            //             };


            //var Result = db.Set<Department>().GroupJoin(
            //    db.Employees,
            //    d => d.DeptId,
            //    e => e.DepartmentDeptId,
            //    (D, DepartmentEmployees) => new
            //    {
            //        Department = D,
            //        Employees = DepartmentEmployees.DefaultIfEmpty()
            //    }).SelectMany(x=>x.Employees, (x,emp) => new
            //    {
            //        Department = x.Department,
            //        Employee = emp
            //    });

            //foreach (var item in Result)
            //{
            //    if (item.Department is not null)
            //    {
            //        Console.WriteLine($"Department: Name = {item.Department.Name} , Employee: {item.Employee?.Name ?? "No Employees"}");
            //    }
            //}
            #endregion
            #region CrossJoin
            //var Result = from D in db.Set<Department>()
            //             from E in db.Employees
            //             select new
            //             {
            //                 EmployeeName = E.Name,
            //                 DepartmentName = D.Name
            //             };

            //var Result = db.Set<Department>().SelectMany(D => db.Employees.Select
            //(E => new
            //{
            //    EmployeeName = E.Name,
            //    DepartmentName = D.Name
            //}));

            //foreach (var item in Result)
            //    Console.WriteLine(item);
            #endregion
            #endregion

            #region Mapping View
            ///1.add new empty migration with name of view
            ///2.in up write sql code to create view 
            ///3.in down write sql code to drop view
            ///4.create class with same structure of view
            ///5.add dbset
            ///6.on model create refer to view and set hasnokey
            ///7.use dbset to get data
            
            //using CompanyDbContext db = new CompanyDbContext();
            //var Result = db.EmployeeDepartmentView.AsNoTracking();
            //foreach (var item in Result)
            //    Console.WriteLine($"Employee:{item.EmpName}, Department:{item.DepartmentName ?? "NA"}");
            #endregion
        }
    }
}
