using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace NorthwindDataBase_MVC.Services
{
    public class customerCreationDto
    {
        [Key]
        public int CustomerId { get; set; }
        [Required]
        [MaxLength(50)]
        public string? CustomerName { get; set; }

        public string? ContactName { get; set; }
    }
}
