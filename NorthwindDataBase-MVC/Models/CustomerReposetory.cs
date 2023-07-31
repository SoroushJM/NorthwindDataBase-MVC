using Microsoft.DotNet.Scaffolding.Shared.Messaging;
using NorthwindDataBase_MVC.Data;
using NorthwindDataBase_MVC.Models.Entity;
using System.Diagnostics;

namespace NorthwindDataBase_MVC.Models
{
    public class CustomerRepository
    {
        private readonly NorthwindContext _context;

        public CustomerRepository(NorthwindContext context)
        {
            _context = context;
        }

        public IEnumerable<Customer> GetAll()
        {
            return _context.Customers;
        }

        public Customer GetCustomer(int id)
        {
            return _context.Customers.SingleOrDefault(c => c.CustomerId == id);
        }

        public void AddCustomer(Customer customer)
        {
            _context.Customers.Add(customer);
        }

        public bool SaveChanges()
        {
            return  _context.SaveChanges() >= 0;
        }
    }
}
