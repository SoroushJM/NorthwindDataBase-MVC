using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NorthwindDataBase_MVC.Models.Entity;

public partial class Product
{
    [Key]
    public int ProductId { get; set; }
    [Required]
    public string ProductName { get; set; } = null!;

    public Shipper Shipper { get; set; } = null!;

    public int? CategoryId { get; set; }

    public string? Unit { get; set; }

    public decimal? Price { get; set; }

    public virtual Category? Category { get; set; }

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

}
