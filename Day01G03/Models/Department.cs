using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01G03.Models
{
    // Model
    internal class Department
    {
        public int DeptId { get; set; }
        public int? Code { get; set; }
        public string DepartmentName { get; set; } = null!;
        public DateOnly DateOfCreation { get; set; }

        [ForeignKey(nameof(Manager))]
        public int? MngId { get; set; }
        // Navigational Property [One]
        // EF Core : Department Must Be managed by One Employee [Total]
        [InverseProperty(nameof(Employee.ManagedDepartment))]
        public Employee? Manager { get; set; } = null!;
    }
}
