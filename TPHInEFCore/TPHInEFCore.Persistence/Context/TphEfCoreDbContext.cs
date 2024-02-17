using Microsoft.EntityFrameworkCore;
using TPHInEFCore.Persistence.Entities;

namespace TPHInEFCore.Persistence.Context;
public class TphEfCoreDbContext(DbContextOptions<TphEfCoreDbContext> options) : DbContext(options)
{
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Developer> developers { get; set; }
    public DbSet<TechnicalLead> TechnicalLeads { get; set; }
    public DbSet<Manager> Managers { get; set; }
}
