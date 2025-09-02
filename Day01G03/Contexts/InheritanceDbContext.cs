using Day01G03.Inheritance_Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01G03.Contexts
{
    internal class InheritanceDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = .; DataBase = InheritanceG01; Trusted_Connection = True; TrustServerCertificate = True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region TPH
            //modelBuilder.Entity<FullTimeEmployee>()
            //            .HasBaseType<Employee>();

            //modelBuilder.Entity<PartTimeEmployee>()
            //            .HasBaseType<Employee>(); 

            //modelBuilder.Entity<Employee>()
            //            .HasDiscriminator<string>("EmployeeType")
            //            .HasValue<FullTimeEmployee>("FTE")
            //            .HasValue<PartTimeEmployee>("PTE");
            #endregion

            modelBuilder.Entity<FullTimeEmployee>().ToTable("FullTimeEmployee");
            modelBuilder.Entity<PartTimeEmployee>().ToTable("PartTimeEmployee");
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<FullTimeEmployee> FullTimeEmployees { get; set; }
        public DbSet<PartTimeEmployee> PartTimeEmployees { get; set; }
        #region TPC
        //public DbSet<FullTimeEmployee> FullTimeEmployees { get; set; }
        //public DbSet<PartTimeEmployee> PartTimeEmployees { get; set; } 
        #endregion
    }
}
