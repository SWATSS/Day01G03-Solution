
using DataBaseFirst.Models.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
namespace DataBaseFirst.Models;

public partial class Company_SDContext : DbContext
{
    public Company_SDContext()
    {
    }

    public Company_SDContext(DbContextOptions<Company_SDContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<Dependent> Dependents { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Project> Projects { get; set; }

    public virtual DbSet<WorksFor> WorksFors { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=Company_SD;Integrated Security=True;Trust Server Certificate=True;Command Timeout=300");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new Configurations.DepartmentConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.DependentConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.EmployeeConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.ProjectConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.WorksForConfiguration());

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
