using Microsoft.DotNet.Scaffolding.Shared.Messaging;
using NorthwindDataBase_MVC.Data;
using NorthwindDataBase_MVC.Models.Entity;
using System.Diagnostics;

namespace NorthwindDataBase_MVC.Models
{
    public class CustomerRepository
    {
        private readonly DataContext _context;

        public CustomerRepository(DataContext context)
        {
            _context = context;
        }

        public bool SaveChanges()
        {
            return  _context.SaveChanges() >= 0;
        }
    }
}
