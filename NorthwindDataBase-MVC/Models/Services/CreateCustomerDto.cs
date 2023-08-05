using System.ComponentModel.DataAnnotations;

namespace NorthwindDataBase_MVC.Models.Services
{
    public class CreateCustomerDto
    {

        [Required]
        [MaxLength(50)]
        public string? FirstName { get; set; }
        [MaxLength(50)]
        public string? LastName { get; set; }
        [MaxLength(50)]
        public string? Address { get; set; }
        [MaxLength(50)]
        public string? City { get; set; }
        [MaxLength(50)]
        public string? PostalCode { get; set; }
        [MaxLength(50)]
        public string? Country { get; set; }
    }
}
