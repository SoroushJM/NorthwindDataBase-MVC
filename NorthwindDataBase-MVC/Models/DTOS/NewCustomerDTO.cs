using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NorthwindDataBase_MVC.Models.DTOS
{
    public class NewCustomerDTO : BaseDTO
    {

        public string Email { get; set; } = null!;

        public string Password { get; set; } =null!;

        [MaxLength(50)]
        public string? FirstName { get; set; }

        [MaxLength(50)]
        public string? LastName { get; set; }

        [MaxLength(50)]
        public string? Address { get; set; }
    }
}
