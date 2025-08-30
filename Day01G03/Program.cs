using Day01G03.Contexts;
using Day01G03.DataSeeding;
using Day01G03.Models;
using Microsoft.EntityFrameworkCore;

namespace Day01G03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region DbContext
            //CompanyDbContext context = new CompanyDbContext();
            //try
            //{
            //    // Some Code
            //}
            //finally
            //{
            //    context.Dispose();
            //}

            //using(CompanyDbContext context = new CompanyDbContext())
            //{
            //    // Some Code
            //} 

            //using CompanyDbContext context = new CompanyDbContext();
            #endregion

            #region Migrations
            //using CompanyDbContext context = new CompanyDbContext();

            //context.Database.EnsureDeleted();
            //context.Database.EnsureCreated();

            //var Result = context.Employees.Where(E => E.Name == "Hamada").FirstOrDefault();
            // select top(1) * from Employees as e where e.EmpName = N"Hamada"

            //Console.WriteLine(Result);

            //context.Database.Migrate(); 
            #endregion

            #region CRUD Operations
            //using CompanyDbContext context = new CompanyDbContext();

            #region Add
            //Employee emp01 = new Employee()
            //{
            //    //Id = 1,
            //    Name = "Omar",
            //    Age = 24,
            //    Salary = 3000
            //};
            //Employee emp02 = new Employee()
            //{
            //    //Id = 2,
            //    Name = "Mohamed",
            //    Age = 20,
            //    Salary = 5000
            //};

            //Console.WriteLine($"Employee 01: {context.Entry(emp01).State}");
            //Console.WriteLine($"Employee 02: {context.Entry(emp02).State}");

            //context.Employees.Add(emp01);
            //context.Employees.Add(emp02);
            ////context.Add(emp01);
            ////context.Set<Employee>().Add(emp01);

            //Console.WriteLine($"Employee 01: {context.Entry(emp01).State}");
            //Console.WriteLine($"Employee 02: {context.Entry(emp02).State}");

            //Console.WriteLine(context.SaveChanges());

            //Console.WriteLine($"Employee 01: {context.Entry(emp01).State}");
            //Console.WriteLine($"Employee 02: {context.Entry(emp02).State}"); 
            #endregion

            #region Select
            //context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.TrackAll;
            //context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;

            //var Result = (from E in context.Employees
            //             where E.Id == 1
            //             select E).AsTracking().FirstOrDefault();

            //Console.WriteLine($"Employee 01: {context.Entry(Result).State}");
            //Console.WriteLine($"Employee : {Result.Name}"); 
            #endregion

            #region Update
            //var Result = (from E in context.Employees
            //              where E.Id == 1
            //              select E).FirstOrDefault();

            //if(Result != null)
            //{
            //    Console.WriteLine($"Employee 01: {context.Entry(Result).State}");

            //    Result.Salary = 4_000;

            //    Console.WriteLine($"Employee 01: {context.Entry(Result).State}");

            //    context.SaveChanges();

            //    Console.WriteLine($"Employee 01: {context.Entry(Result).State}");
            //} 
            #endregion

            #region Delete
            //var Result = (from E in context.Employees
            //              where E.Id == 1
            //              select E).FirstOrDefault();

            //if(Result != null)
            //{
            //    Console.WriteLine($"Employee 01: {context.Entry(Result).State}");

            //    context.Employees.Remove(Result);
            //    //context.Remove(Result);
            //    //context.Set<Employee>().Remove(Result);

            //    Console.WriteLine($"Employee 01: {context.Entry(Result).State}");

            //    Console.WriteLine(context.SaveChanges());

            //    Console.WriteLine($"Employee 01: {context.Entry(Result).State}");
            //} 
            #endregion
            #endregion

            using CompanyDbContext context = new CompanyDbContext();
            //Department Dept01 = new Department()
            //{
            //    Code = 101,
            //    DateOfCreation = new DateOnly(2025, 05, 23),
            //    DepartmentName = "HR"
            //};
            //context.Set<Department>().Add(Dept01);
            //context.SaveChanges();

            //List<Department> departments = new List<Department>()
            //{
            //    new Department() {Code = 102, DateOfCreation = new DateOnly(2021, 05, 06), DepartmentName = "Sales"},
            //    new Department() {Code = 103, DateOfCreation = new DateOnly(2023, 12, 3), DepartmentName = "Software"},
            //    new Department() {Code = 104, DateOfCreation = new DateOnly(2024, 5, 1), DepartmentName = "Marketing"}
            //};
            //context.Set<Department>().AddRange(departments);
            //context.SaveChanges();

            CompanyDbContextSeed.DataSeeding(context);
            #region Eagr

            //var Emp01 = context.Employees.Include(E => E.EmpDempartment)
            //                               .ThenInclude(D => D.Manager)
            //                               .FirstOrDefault(E => E.Id == 3);

            //if (Emp01 != null)
            //{
            //    Console.WriteLine($"Employee Name: {Emp01.Name}");
            //    Console.WriteLine($"Department Id: {Emp01.DepartmentId}");
            //    Console.WriteLine($"Department Name: {Emp01.EmpDempartment.DepartmentName}");
            //    Console.WriteLine($"Manager Id: {Emp01.EmpDempartment.MngId}");
            //    Console.WriteLine($"Manager Name: {Emp01.EmpDempartment.Manager.Name}");
            //} 
            #endregion

            #region Explicit
            #region Example
            //var Emp01 = context.Employees.FirstOrDefault(E => E.Id == 1);

            //if (Emp01 is not null)
            //{

            //    Console.WriteLine($"Employee Name: {Emp01.Name}");
            //    Console.WriteLine($"Department Id: {Emp01.DepartmentId}");

            //    context.Entry(Emp01).Reference(E => E.EmpDempartment).Load();
            //    Console.WriteLine($"Department Name: {Emp01.EmpDempartment.DepartmentName}");
            //} 
            #endregion
            #region Example
            //var Dept = context.Set<Department>().FirstOrDefault(D => D.DeptId == 3);

            //if (Dept != null)
            //{
            //    Console.WriteLine($"Department Name:{Dept.DepartmentName}");
            //    context.Entry(Dept).Collection(D => D.Employees).Load();
            //    foreach (var emp in Dept.Employees)
            //    {

            //        Console.WriteLine($"----------------------{emp.Name}");
            //    }
            //} 
            #endregion 
            #endregion




        }
    }
}
