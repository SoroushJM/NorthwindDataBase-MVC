using Microsoft.AspNetCore.Mvc;
using NorthwindDataBase_MVC.Models;

namespace NorthwindDataBase_MVC.Controllers
{
    public class GetAllUsers : Controller
    {
        CustomerRepository _customerRepository;
        public GetAllUsers(CustomerRepository customerRepository) {
            _customerRepository = customerRepository;
        }
        public IActionResult Index()
        {
            ViewBag.allusers = _customerRepository.GetAll();
            return View(_customerRepository);
        }
    }
}
