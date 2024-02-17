using Dumpify;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using TPHInEFCore.Persistence.Configuration;
using TPHInEFCore.Persistence.Context;
using TPHInEFCore.Persistence.Entities;

var optionsBuilder = new DbContextOptionsBuilder<TphEfCoreDbContext>();
var host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((context, services) =>
    {
        optionsBuilder.UseSqlServer(context.Configuration.GetConnectionString("DefaultConnection"));
        PersistenceConfiguration.Configure(services, context.Configuration);
    })
    .Build();


using (var dbContext = new TphEfCoreDbContext(optionsBuilder.Options))
{
    //dbContext.developers.Add(
    // new Developer
    // {
    //     FullName = "Developer #1",
    //     HireDate = DateTime.UtcNow,
    //     ProgrammingLanguage = "C#"
    // });

    //dbContext.Managers.Add(
    // new Manager
    // {
    //     FullName = "Manager #1",
    //     HireDate = DateTime.UtcNow,
    //     Department = "HR"
    // });

    //dbContext.TechnicalLeads.Add(
    // new TechnicalLead
    // {
    //     FullName = "Technical Lead #1",
    //     HireDate = DateTime.UtcNow,
    //     ProgrammingLanguage = "C#",
    //     TeamName = "Team #1"
    // });

    //dbContext.Employees.Add(
    // new Employee
    // {
    //     FullName = "Employee #1",
    //     HireDate = DateTime.UtcNow
    // });

    dbContext.SaveChanges();

    dbContext.developers.Dump();
    dbContext.Managers.Dump();
    dbContext.TechnicalLeads.Dump();
    dbContext.Employees.Dump();
}

host.Run();
