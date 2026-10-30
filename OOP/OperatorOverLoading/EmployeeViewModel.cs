using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.OperatorOverLoading
{
    class Address
    {
        public string AddressDetails { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }

    class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateOnly BirthDate { get; set; }
        public decimal Salary { get; set; }
        public Address Address { get; set; }
        public decimal Detuctions { get { return Salary * .2m; } }
    }

    internal class EmployeeViewModel
    {
        public string FullName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public decimal NetSalary { get; set; }

        public EmployeeViewModel()
        {

        }

        public EmployeeViewModel(Employee emp)
        {
            FullName = $"{emp.FirstName} {emp.LastName}";
            Age = DateTime.Now.Year - emp.BirthDate.Year;
            Address = $"{emp.Address.AddressDetails}, {emp.Address.City}, {emp.Address.Country}";
            NetSalary = emp.Salary - emp.Detuctions;
        }

        public override string ToString()
        {
            return $"Name : {FullName}\tAge : {Age}\tAddress : {Address}\tNetSalary : {NetSalary}";
        }

        //public static implicit operator EmployeeViewModel(Employee emp)
        //{
        //    return new EmployeeViewModel(emp);
        //}

        public static explicit operator EmployeeViewModel(Employee emp)
        {
            return new EmployeeViewModel(emp);
        }
    }

    static class EmployeeExtintions
    {
        public static EmployeeViewModel ToEmployeeViewModel(this Employee emp)
        {
            return new EmployeeViewModel(emp);
        }
    }

    static class Extintions
    {
        public static int Add(this int a, int b)
        {
            return a + b;
        }
    }
}
