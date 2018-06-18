using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Payment_MVC.Models;

namespace Payment_MVC.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        public ActionResult Greeting()
        {
            var kek = new Order()
            {
                OrderId = 2,
                DoB = "1980-02-23",
                Total = 55
            };

            return View(kek);
        }
    }
}