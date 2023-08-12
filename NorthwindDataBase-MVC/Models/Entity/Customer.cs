using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NorthwindDataBase_MVC.Models.Entity;

public partial class Customer
{
    [Key]
    public int CustomerId { get; set; }

    [EmailAddress]
    [Required(ErrorMessage = "Email required")]
    public string Email { get; set; } = null!;

    [PasswordPropertyText]
    [Required(ErrorMessage = "password is required")]
    public string Password { get; set; } = string.Empty!;

    [Required]
    [MaxLength(50)]
    public string? FirstName { get; set; }

    [MaxLength(50)]
    public string? LastName { get; set; }

    [MaxLength(50)]
    public string? Address { get; set; }

    public ICollection<Order> Orders { get; set; } = new List<Order>();
}
