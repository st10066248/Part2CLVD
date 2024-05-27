using Microsoft.AspNetCore.Mvc;
using Part2CLVD.Services;
using Part2CLVD.Models;

namespace Part2CLVD.Controllers
{
    public class OrdersController : Controller
    {
        private readonly ApplicationDbContext context2;

        public OrdersController(ApplicationDbContext context2) 
        {
            this.context2 = context2;
        }   
        public IActionResult Index()
        {
            var orders = context2.Orders.ToList();
            return View(orders);
        }
    }
}
