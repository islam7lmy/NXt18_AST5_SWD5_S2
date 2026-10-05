using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal struct Employee
    {
        public int Id;
        //encapsulation : seprate the data defintion (attributes) from it's usage (GetterSetter or Property)
        #region Name [Getter Setter Method]
        string Name; // => max length 20  
        ///getter & setter Methods
        public string GetName()
        {
            return Name ?? "N/A";
        }

        public void SetName(string name)
        {
            Name = name.Length <= 20 ? name : name.Substring(0, 20);
        }
        #endregion

        #region Salary [Full Property]
        //attribute + property
        //decimal Salary; // => min 2000 
        //public decimal SalaryProperty
        //{
        //    get { return Salary < 2000 ? 2000 : Salary; }
        //    set { Salary = value < 2000 ? 2000 : value; }
        //}

        //public decimal getsalary()
        //{
        //    return Salary < 2000 ? 2000 : Salary;
        //}

        //public void setsalary(decimal value)
        //{
        //    Salary = value < 2000 ? 2000 : value;
        //}

        decimal salary;
        public decimal Salary
        {
            get { return salary < 2000 ? 2000 : salary; }
            set { salary = value < 2000 ? 2000 : value; }
        }


        // propfull + tab + tab
        //private double _test;

        //public double Test
        //{
        //    get { return _test; }
        //    set { _test = value; }
        //}

        #endregion

        #region Age [Automatic Property]
        //backing field + property
        //public int Age;

        /// clr Will Generate Backing Field [Hidden Private Attribute]
        public int Age
        {
            get;
            private set;
        }
        #endregion

        #region Deductions [automatic property has only get]
        //public decimal Deductions()
        //{
        //    return Salary * .2m;
        //}
        public decimal Deductions
        {
            get { return Salary * .2m; }
        } 
        #endregion

        public Employee(int _age)
        {
            Age = _age;
        }
    }
}
