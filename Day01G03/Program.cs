using Day01G03.Contexts;
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
        }
    }
}
