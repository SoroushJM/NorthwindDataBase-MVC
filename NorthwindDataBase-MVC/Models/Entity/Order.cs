using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NorthwindDataBase_MVC.Models.Entity;

public partial class Order
{
    [Key]
    public int OrderId { get; set; }

    public Customer Customer { get; set; }

    public Employee Employee { get; set; }

    public DateTime? OrderDate { get; set; }

    public Shipper Shipper { get; set; }

    public ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

}
