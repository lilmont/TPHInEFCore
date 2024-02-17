namespace TPHInEFCore.Persistence.Entities;
public abstract class Employee
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public DateTime HireDate { get; set; }
}
