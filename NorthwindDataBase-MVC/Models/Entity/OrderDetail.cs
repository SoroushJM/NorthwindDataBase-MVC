using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NorthwindDataBase_MVC.Models.Entity;

public partial class OrderDetail
{
    [Key]
    public int OrderDetailId { get; set; }

    public int? OrderId { get; set; }

    public int? ProductId { get; set; }

    public int? Quantity { get; set; }

    public virtual Order? Order { get; set; }

    public virtual Product? Product { get; set; }
}
