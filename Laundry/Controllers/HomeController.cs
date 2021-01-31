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
        public ActionResult GetOrder(
            string Name,
            string Surname,
            string Number,
            string Date,
            string Time)
        {
            
            var remoteIP = Request.HttpContext.Connection.RemoteIpAddress.ToString();
             
            FirstMachineOrder firstMachineOrder = new FirstMachineOrder() {
            clientName=Name,
            clientSurname=Surname,
            clientNumber=Number,
            date=Date,
            time=Time,
            machineNumber=1,
            ipAddress=remoteIP.ToString()
            };
            var orders = orderContext.firstMachineOrders;
            foreach ( var elem in orders)
            {
                if (firstMachineOrder.ipAddress==elem.ipAddress && firstMachineOrder.date == elem.date && firstMachineOrder.date != null)
                {
                    return View("ErrorHandler");
                }             
            }
            orderContext.firstMachineOrders.Add(firstMachineOrder);
            orderContext.SaveChanges();
            return View("Index");


        }

        [HttpPost]
        public ActionResult GetSecondOrder(
           string Name,
           string Surname,
           string Number,
           string Date,
           string Time)
        {

            var remoteIP = Request.HttpContext.Connection.RemoteIpAddress.ToString();

            SecondMachineOrder secondMachineOrder = new SecondMachineOrder()
            {
                clientName = Name,
                clientSurname = Surname,
                clientNumber = Number,
                date = Date,
                time = Time,
                machineNumber = 2,
                ipAddress = remoteIP.ToString()
            };
            var orders = orderContext.secondMachineOrders;
            foreach (var elem in orders)
            {
                if (secondMachineOrder.ipAddress == elem.ipAddress && secondMachineOrder.date == elem.date && secondMachineOrder.date!=null)
                {
                    return View("ErrorHandler");
                }
            }
            orderContext.secondMachineOrders.Add(secondMachineOrder);
            orderContext.SaveChanges();
            return View("Index");


        }

        [HttpGet]
        public ActionResult PassData()
        {
            var order = orderContext.firstMachineOrders;
            
            ViewBag.Message = order;
            return View("test");
        }

        [HttpGet]
        public ActionResult SecondPassData()
        {
            var secondorder = orderContext.secondMachineOrders;

            ViewBag.Message = secondorder;
            return View("test");
        }
    }
}
