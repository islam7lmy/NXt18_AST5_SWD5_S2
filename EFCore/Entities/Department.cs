using System;
using System.Collections.Generic;
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
    internal class Department
    {
        public int DeptId { get; set; }
        public string? Name { get; set; }
        public int Code { get; set; }
        //public DateOnly CreationDate { get; set; }

        //navigational property
        //[InverseProperty(nameof(Employee.Department))]
        public virtual ICollection<Employee> Employees { get; set; }


        //fk
        //[ForeignKey(nameof(Manager))]
        public int? ManagerId { get; set; }
        //navigational property
        //[InverseProperty(nameof(Employee.DepartmentToManage))]
        //public Employee Manager { get; set; }

        //public Project Project { get; set; }
        //public ICollection<Service> Services { get; set; }
    }
    //class Service
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}

    //class Project
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }

    //    public ICollection<Product> Products { get; set; }
    //}

    //class Product
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}



}
