using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01G03.Inheritance_Models
{
    internal class PartTimeEmployee : Employee
    {
        public int CountOfHours { get; set; }
        public double HourRate { get; set; }
    }
}
