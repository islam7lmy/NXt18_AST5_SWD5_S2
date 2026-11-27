using EFCore.Configurations;
using EFCore.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Contexts
{
    internal class CompanyDbContext : DbContext
    {
        ///OnConfiguring => configurtation of database server
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Your_Connection_String_Here");
            //optionsBuilder.UseSqlServer("Data source = ISLAM7LMYLAPVM\\ISLAM7LMY;Intial Catalog = NXT18.EFMyCompany;Integrated Security = True; Encrypt = false; Trust Server Certificate = True");
            //optionsBuilder.UseSqlServer("Data source = ISLAM7LMYLAPVM\\ISLAM7LMY;Intial Catalog = NXT18.EFMyCompany;User Id = sa; Password = 1234567; Encrypt = false; Trust Server Certificate = True");
            optionsBuilder
                .UseLazyLoadingProxies(true)
                .UseSqlServer("Data Source=ISLAM7LMYLAPVM\\ISLAM7LMY;Initial Catalog=NXT18.EFMyCompany;Integrated Security=True;Encrypt=False;Trust Server Certificate=True");
        }

        ///OnModelCreating => Models of database [tables]
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VIEW_EmployeeDepartment>()
                .ToView("EmployeeDepartmentView")
                .HasNoKey();

            // when inhert from dbcontext contain dbsets as scurity modual has 7 dbsets
            // inhert IdentityDbContext
            //base.OnModelCreating(modelBuilder);

            #region 3. Fluent API
            #region Ways To Access Property
            //modelBuilder.Entity<Employee>()
            //    .Property("FirstName")
            //    .HasDefaultValue("No Name");

            //modelBuilder.Entity<Employee>()
            //    .Property(nameof(Employee.FirstName))
            //    .HasDefaultValue("No Name");

            //modelBuilder.Entity<Employee>()
            //    .Property(e => e.FirstName)
            //    .HasDefaultValue("No Name");
            #endregion
            #region Shadow Property
            //modelBuilder.Entity<Employee>()
            //    .Property<string>("Address")
            //    .HasColumnType("nvarchar(100)");
            #endregion
            #region Mapping To Class
            //modelBuilder.Entity<Department>()
            //    .ToTable("DepartmentInfo", "dbo")
            //    .HasKey(d => d.DeptId);

            //modelBuilder.Entity<Department>()
            //    .Property(d => d.DeptId)
            //    .UseIdentityColumn(10, 10);

            //modelBuilder.Entity<Department>()
            //    .Property(d => d.Name)
            //    .HasColumnName("DepartmentName")
            //    .HasColumnType("nvarchar(50)")
            //    .IsRequired();

            //modelBuilder.Entity<Department>()
            //    .Property(d => d.CreationDate)
            //    .HasColumnType("date")
            //    .HasComputedColumnSql("GETDATE()");

            //efcore 3.1 new feature
            //modelBuilder.Entity<Department>(d =>
            //{
            //    d.ToTable("DepartmentInfo", "dbo")
            //     .HasKey(d => d.DeptId);

            //    d.Property(d => d.DeptId)
            //     .UseIdentityColumn(10, 10);

            //    d.Property(d => d.Name)
            //     .HasColumnName("DepartmentName")
            //     .HasColumnType("nvarchar(50)")
            //     .IsRequired();

            //    d.Property(d => d.CreationDate)
            //     .HasColumnType("date")
            //     .HasComputedColumnSql("GETDATE()");
            //});
            #endregion
            #endregion

            #region 4. ConfigurationClass Per Entity => Organized 3rd way
            //modelBuilder.ApplyConfiguration<Department>(new DepartmentConfigurations());
            //modelBuilder.ApplyConfiguration<Employee>(new EmployeeConfigurations());

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            #endregion
        }


        #region DbSet
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        public DbSet<VIEW_EmployeeDepartment> EmployeeDepartmentView { get; set; }
        #endregion
    }
}
