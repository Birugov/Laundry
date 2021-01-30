using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Laundry.Models;

namespace Laundry.Controllers
{
    public class HomeController : Controller
    {
        private readonly OrderContext orderContext;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, OrderContext context)
        {
            _logger = logger;
            this.orderContext = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public ActionResult  GetOrder( string Name, string Surname, string Number, string Date, string Time )
        {
            FirstMachineOrder firstMachineOrder = new FirstMachineOrder() {
            clientName=Name,
            clientSurname=Surname,
            clientNumber=Number,
            date=Date,
            time=Time,
            machineNumber=1
            };
            orderContext.firstMachineOrders.Add(firstMachineOrder);
            orderContext.SaveChanges();

            return View("Index");
        }
    }
}
