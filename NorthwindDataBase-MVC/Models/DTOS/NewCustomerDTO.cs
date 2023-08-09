using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NorthwindDataBase_MVC.Models.DTOS
{
    public class NewCustomerDTO
    {
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
    }
}
