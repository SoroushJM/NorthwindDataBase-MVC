using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NorthwindDataBase_MVC.Models.Entity;

public partial class Shipper
{
    [Key]
    public int ShipperId { get; set; }

    public string? ShipperName { get; set; }

    public string? Phone { get; set; }

    public ICollection<Order> Orders { get; set; } = new List<Order>();
}
