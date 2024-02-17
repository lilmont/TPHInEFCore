using Microsoft.EntityFrameworkCore;
using TPHInEFCore.Persistence.Entities;

namespace TPHInEFCore.Persistence.Context;
public class TphEfCoreDbContext(DbContextOptions<TphEfCoreDbContext> options) : DbContext(options)
{
    /// <summary>
    /// First approach to utilize TPH strategy in .Net Core
    /// </summary>
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Developer> developers { get; set; }
    public DbSet<TechnicalLead> TechnicalLeads { get; set; }
    public DbSet<Manager> Managers { get; set; }


    /// <summary>
    /// Second approach to utilize TPH strategy in .Net Core
    /// </summary>
    //public DbSet<Employee> Employees { get; set; }
    //protected override void OnModelCreating(ModelBuilder modelBuilder)
    //{
    //    modelBuilder.Entity<Developer>();
    //    modelBuilder.Entity<TechnicalLead>();
    //    modelBuilder.Entity<Manager>();
    //}

    /// <summary>
    /// Setting custom discriminator
    /// </summary>
    //protected override void OnModelCreating(ModelBuilder modelBuilder)
    //{
    //    modelBuilder.Entity<Employee>()
    //        .HasDiscriminator<ulong>(p=>p.EmployeePosition)
    //        .HasValue<Developer>(1)
    //        .HasValue<TechnicalLead>(2)
    //        .HasValue<Manager>(3);
    //}
}
