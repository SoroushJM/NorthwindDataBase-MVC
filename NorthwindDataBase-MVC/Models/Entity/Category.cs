using System;
using System.Collections.Generic;

namespace NorthwindDataBase_MVC.Models.Entity;

public partial class Category
{

    public int CategoryId { get; set; }

    public string? CategoryName { get; set; }

    public string? Description { get; set; }

    public ICollection<Product> Products { get; set; } = new List<Product>();
}
