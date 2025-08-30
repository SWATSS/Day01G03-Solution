using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01G03.Models
{
    [PrimaryKey(nameof(StdId), nameof(CrsId))]
    internal class StudentCourse
    {
        public int StdId { get; set; }
        public int CrsId { get; set; }
        public Student Student { get; set; }
        public Course Course { get; set; }
    }
}
