using System.ComponentModel.DataAnnotations;

namespace FluentValidationDemo.Models;

public class Person
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Email { get; set; }
}
