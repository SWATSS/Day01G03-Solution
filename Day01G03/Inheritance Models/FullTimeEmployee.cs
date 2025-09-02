using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01G03.Inheritance_Models
{
    internal class FullTimeEmployee : Employee
    {
        public decimal Salary { get; set; }
        public DateOnly StartDate { get; set; }
    }
}
