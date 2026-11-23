using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Entities
{
    internal class Department
    {
        public int DeptId { get; set; }
        public string? Name { get; set; }
        public int Code { get; set; }
        public DateOnly CreationDate { get; set; }

        //navigational property
        //[InverseProperty(nameof(Employee.Department))]
        //public ICollection<Employee> Employees { get; set; }


        //fk
        //[ForeignKey(nameof(Manager))]
        public int ManagerId { get; set; }
        //navigational property
        //[InverseProperty(nameof(Employee.DepartmentToManage))]
        //public Employee Manager { get; set; }
    }
}
