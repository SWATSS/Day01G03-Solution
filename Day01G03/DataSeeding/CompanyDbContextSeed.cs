using Day01G03.Contexts;
using Day01G03.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Day01G03.DataSeeding
{
    internal class CompanyDbContextSeed
    {
        public static bool DataSeeding(CompanyDbContext context)
        {
            try
            {
                if (!context.Employees.Any())
                {

                    var EmployeesData = File.ReadAllText("files\\employees.json");
                    var Employees = JsonSerializer.Deserialize<List<Employee>>(EmployeesData);
                    if (Employees?.Count > 0)
                    {
                        context.AddRange(Employees);
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
