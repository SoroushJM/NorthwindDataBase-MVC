using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using NorthwindDataBase_MVC.Models.Entity;

namespace NorthwindDataBase_MVC.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customer { get;set;}
        public DbSet<Employee> Employee { get;set;}
        public DbSet<Order> Order { get;set; }
        public DbSet<OrderDetail> OrderDetail { get;set; }
        public DbSet<Product> Product { get;set; }
        public DbSet<Shipper> Shipper { get;set; }


    }
}
