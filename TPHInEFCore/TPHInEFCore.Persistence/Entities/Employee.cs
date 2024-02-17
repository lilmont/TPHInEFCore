namespace TPHInEFCore.Persistence.Entities;
public class Employee
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public DateTime HireDate { get; set; }

    // custom discriminator
    //public ulong EmployeePosition { get; set; }
}
