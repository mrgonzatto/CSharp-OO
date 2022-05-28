using Microsoft.AspNetCore.Mvc;
using System.Linq;
using UNOESC.BL.Interfaces;

namespace UNOESCWeb.Controllers
{
    public class CustomerController : Controller
    {

        private IUnoescRepository repository;

        public CustomerController(IUnoescRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View( repository.Customers );
        }

        [HttpPost]
        public IActionResult Delete(int CustomerId)
        {
            var c = repository.Customers
                    .Where( c => c.CustomerId == CustomerId ).FirstOrDefault();
            repository.DeleteCustomer(c);

            return View("Index", repository.Customers);
        }


    }
}
