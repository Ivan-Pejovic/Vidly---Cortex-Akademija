using Microsoft.AspNetCore.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        public IActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }
            if (String.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "Name";
            }

            var customers = new List<Customer>();
            customers.Add(new Customer(1, "Ivan", "Pejovic"));
            customers.Add(new Customer(2, "Marko", "Markovic"));
            customers.Add(new Customer(2, "Petar", "Petrovic"));

            var viewModel = new CustomersIndexViewModel
            {
                CustomerList = customers
            };

            return View(viewModel);
        }

        public IActionResult Customer(int id)
        {
            var customers = new List<Customer>();
            customers.Add(new Customer(1, "Ivan", "Pejovic"));
            customers.Add(new Customer(2, "Marko", "Markovic"));
            customers.Add(new Customer(2, "Petar", "Petrovic"));

            var customer = new Customer();

            foreach(var item in customers)
            {
                if(item.Id == id)
                {
                    customer = item;
                    break;
                }
            }

            return View(customer);
        }
    }
}
