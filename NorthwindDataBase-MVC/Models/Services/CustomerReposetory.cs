
using Microsoft.DotNet.Scaffolding.Shared.Messaging;
using NorthwindDataBase_MVC.Data;
using NorthwindDataBase_MVC.Models.Entity;
using System.Diagnostics;

namespace NorthwindDataBase_MVC.Models.Services
{
    public class CustomerRepository
    {
        private readonly FileContext _context;

        public CustomerRepository(FileContext context)
        {
            _context = context;
        }

        public void CreateCustomer(Customer customer)
        {
            _context.Customers.Add(customer);
        }

        public Customer GetCustomerById(int id)
        {
            return _context.Customers.Where(c => c.CustomerId == id).FirstOrDefault();
        }

        public bool SaveChanges()
        {
            return _context.SaveChanges() >= 0;
        }
    }
}
