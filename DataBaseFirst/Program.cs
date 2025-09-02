using DataBaseFirst.Models;
using Microsoft.EntityFrameworkCore;

namespace DataBaseFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using Company_SDContext context = new Company_SDContext();
            //var Result = context.Employees.SingleOrDefault();
            //Console.WriteLine(Result);


            #region DQL
            //var Result = context.Employees.FromSqlRaw(@"select * from Employees
            //                                                               Where Fname != null  ");
            //Console.WriteLine(Result);
            //var fname = "Ahmed";
            //Result = context.Employees.FromSqlInterpolated(@$"select * from Employees
            //                                                               Where Fname != {fname}"); 
            #endregion

            #region DML {Update}
            //var Result = context.Database.ExecuteSqlRaw(@"Update Employees
            //                                                      set Ssn = 66688855");
            //Console.WriteLine(Result);

            //var ssn = 1168895;
            //Result = context.Database.ExecuteSqlInterpolated(@$"Update Employees
            //                                                      set Ssn = {ssn}");
            //Console.WriteLine(Result); 
            #endregion
        }
    }
}
