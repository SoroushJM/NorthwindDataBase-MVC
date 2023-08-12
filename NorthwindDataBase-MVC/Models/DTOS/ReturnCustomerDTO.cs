using System.ComponentModel.DataAnnotations;

namespace NorthwindDataBase_MVC.Models.DTOS
{
    public class ReturnCustomerDTO : BaseDTO
    {
        [Required]
        [MaxLength(50)]
        public string? FirstName { get; set; }
        [MaxLength(50)]
        public string? LastName { get; set; }
        [MaxLength(50)]
        public string? Address { get; set; }
    }
}
