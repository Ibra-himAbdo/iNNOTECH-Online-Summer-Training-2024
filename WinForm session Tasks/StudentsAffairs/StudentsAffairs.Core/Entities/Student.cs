namespace StudentsAffairs.Core.Entities;

public class Student : BaseEntity
{
    public string? Name { get; set; }
    public string? Email { get; set; }
    public int Age { get; set; }
    public string? Mobile { get; set; }
}
