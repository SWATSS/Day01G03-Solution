using Day01G03.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01G03.Configuration_Classes
{
    internal class DepartmentConfigurations : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.ToTable("Departments", "dbo");

            builder.HasKey(D => D.DeptId);

            builder.Property<string>(D => D.DepartmentName)
                    .HasColumnType("varchar")
                    .HasMaxLength(50)
                    .HasColumnName("Name")
                    .IsRequired();

            builder.Property(D => D.DateOfCreation);
                    //.HasDefaultValue(DateTime.Now);


            builder.HasOne(D => D.Manager)
                   .WithOne(E => E.ManagedDepartment)
                   .HasForeignKey<Department>(D => D.MngId)
                   .OnDelete(DeleteBehavior.NoAction)
                   .IsRequired(false);
        }
    }
}
