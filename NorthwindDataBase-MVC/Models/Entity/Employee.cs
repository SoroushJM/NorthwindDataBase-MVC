using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NorthwindDataBase_MVC.Models.Entity;

public partial class Employee
{
    [Key]
    public int EmployeeId { get; set; }

    public string? LastName { get; set; }

    public string? FirstName { get; set; }

    public DateTime? BirthDate { get; set; }

    public string? Photo { get; set; }

    public string? Notes { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
