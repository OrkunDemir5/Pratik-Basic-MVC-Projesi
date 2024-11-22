using Microsoft.AspNetCore.Mvc;
using Pratik_Basic_MVC_Projesi.Models;

namespace Pratik_Basic_MVC_Projesi.Controllers
{
    public class CustomerOrdersController : Controller
    {
        public IActionResult Index()
        {
            // Örnek müşteri oluşturuluyor
            var customer = new Customer
            {
                Id = 1,
                FirstName = "Orkun",
                LastName = "Demir",
                Email = "orkun.d1999@gmail.com"
            };

            // Örnek siparişler oluşturuluyor
            var orders = new List<Order>
        {
            new Order { Id = 1, ProductName = "Laptop", Price = 1200.50m, Quantity = 1 },
            new Order { Id = 2, ProductName = "Mouse", Price = 25.75m, Quantity = 2 },
            new Order { Id = 3, ProductName = "Keyboard", Price = 45.00m, Quantity = 1 }
        };

            // ViewModel oluşturuluyor
            var viewModel = new CustomerOrderViewModel
            {
                Customer = customer,
                Orders = orders
            };

            // ViewModel view'a iletiliyor
            return View(viewModel);
        }
    }
}
