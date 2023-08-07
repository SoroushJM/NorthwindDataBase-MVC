using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using NorthwindDataBase_MVC.Models.Entity;

namespace NorthwindDataBase_MVC.Data;

public partial class FileContext : DbContext
{
    public FileContext()
    {
    }

    public FileContext(DbContextOptions<FileContext> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite("DataSource=file.sqlite3 ");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    public DbSet<Category> Categories { get; set; } = null!;
    public DbSet<Customer> Customers { get; set; } = null!;
    public DbSet<Employee> Employees { get; set; } = null!;
    public DbSet<Order> Orders { get; set; } = null!;
    public DbSet<OrderDetail> OrderDetails { get; set; } = null!;
    public DbSet<Product> Products { get; set; } = null!;
    public DbSet<Shipper> Shippers { get; set; } = null!;
}
