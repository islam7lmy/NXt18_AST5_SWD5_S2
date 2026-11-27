using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region to make file visable in spciefic Assembly
using System.Runtime.CompilerServices;
[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2")]
#endregion
namespace EFCore.Entities
{
    #region Properties Mapping
    /// Ef Core Suppotes 4 ways for mapping
    /// 1. by Convention (Default)
    /// 2. Data Annotations [set of attributes used for valdation]
    /// 3. Fluent API (set of methods to do congfigurations)
    /// 4. ConfigurationClass Per Entity => Organized 3rd way 



    #region 1. By Convention (Default)
    //internal class Employee
    //{
    //    public int EmployeeId { get; set; } // primary key by Convention => identity(1,1) , not allow null
    //    public string FirstName { get; set; } // nvarchar(max) => not allow null
    //    public double? Salary { get; set; } // float => allow null in db
    //    public int Age { get; set; } // int => don't allow null
    //}
    #endregion

    #region 2. Data Annotations
    //[Table("EmployeesInfo" , Schema = "dbo")]
    //internal class Employee
    //{
    //    [Key]
    //    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    //    public int UniqueKey { get; set; } // primary key by Convention => identity(1,1) , not allow null

    //    [Required]
    //    [Column(TypeName = "varchar")]
    //    [MaxLength(100)]
    //    public string? FirstName { get; set; } // nvarchar(max) => not allow null

    //    [DataType(DataType.Currency)]
    //    public double? Salary { get; set; } // float => allow null in db


    //    public int Age { get; set; } // int => don't allow null

    //    [NotMapped]
    //    public int Test { get; set; }
    //}
    #endregion

    #region 3. Fluent API
    //internal class Employee
    //{
    //    public int EmployeeId { get; set; }
    //    public string FirstName { get; set; }
    //    public double? Salary { get; set; }
    //    public int Age { get; set; }
    //}
    #endregion
    #endregion

    #region RealtionShipMapping
    ///Fk + Navigational Property

    internal class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public double Salary { get; set; }
        public int? Age { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public double NetSalary { get => Salary * .9; }

        //FK => ClassName + PK
        //[ForeignKey(nameof(Department))]
        public int? DepartmentDeptId { get; set; }

        //navigational property
        //[InverseProperty(nameof(Department.Employees))]
        public virtual Department? Department { get; set; }

        //navigational property
        //[InverseProperty(nameof(Department.Manager))]
        //public Department DepartmentToManage { get; set; }
    }
    #endregion
}
