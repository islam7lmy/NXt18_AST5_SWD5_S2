using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Entities
{
    #region Properties Mapping
    /// Ef Core Suppotes 4 ways for mapping
    /// 1. by Convention (Default)
    /// 2. Data Annotations [set of attributes used for valdation]
    /// 3. Fluent API (set of methods to do congfigurations)
    /// 4. ConfigurationClass Per Entity => Organized 3rd way 
    #endregion


    #region 1. By Convention (Default)
    internal class Employee
    {
        public int EmployeeId { get; set; } // primary key by Convention => identity(1,1) , not allow null
        public string FirstName { get; set; } // nvarchar(max) => not allow null
        public double? Salary { get; set; } // float => allow null in db
        public int Age { get; set; } // int => don't allow null
    }
    #endregion
}
