using System;

namespace MVC.Models
{
    public class Employee
    {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public Dept? Department { get; set; }
    public string PhotoPath { get; set; }
    }
}
