using Microsoft.AspNetCore.Mvc;
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

        public IActionResult Index()
        {
            return View( repository.Customers );
        }
    }
}
