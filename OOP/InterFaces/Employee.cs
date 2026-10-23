using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.InterFaces
{
    internal class Employee : ICloneable,IComparable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string Address { get; set; }

        public override string ToString()
        {
            return $"{Id} :: {Name} :: {Address} :: {Salary}";
        }

        public Employee()
        {

        }

        /// copy constructor => a constructor that takes an object of the same class as a parameter 
        public Employee(Employee emp)
        {
            Id = emp.Id;
            Name = emp.Name;
            Salary = emp.Salary;
            Address = emp.Address;
        }

        public static Employee DeepCopy(Employee emp)
        {
            //Employee newemp = new Employee()
            //{
            //    Id = emp.Id,
            //    Name = emp.Name,
            //    Salary = emp.Salary,
            //    Address = emp.Address
            //};
            //return newemp;

            //return new Employee()
            //{
            //    Id = emp.Id,
            //    Name = emp.Name,
            //    Salary = emp.Salary,
            //    Address = emp.Address
            //};

            return new Employee(emp);
        }

        public object Clone()
        {
            ///this keyword => refere to object that call method
            return new Employee(this);
        }

        //+ve : this > obj
        //-ve : this < obj
        //0 : this == obj
        public int CompareTo(object? obj)
        {
            Employee other = (Employee)obj;

            //if (this.Salary > other.Salary)
            //    return 1;
            //else if (this.Salary < other.Salary)
            //    return -1;
            //else return 0;

            return this.Salary.CompareTo(other.Salary);
        }
    }
}
