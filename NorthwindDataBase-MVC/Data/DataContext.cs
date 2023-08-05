using Microsoft.EntityFrameworkCore;
using NorthwindDataBase_MVC.Models.Entity;

namespace NorthwindDataBase_MVC.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) :base(options)
        {
            
        }
        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<Customer> Customers  {get;set;} = null!;
        public DbSet<Employee> Employees  {get;set;} = null!;
        public DbSet<Order> Orders  {get;set;} = null!;
        public DbSet<OrderDetail> OrderDetails  {get;set;} = null!;
        public DbSet<Product> Products {get;set;} = null!;
        public DbSet<Shipper> Shippers  {get;set;} = null!;
    }
}
