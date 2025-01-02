using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Assessment_1.Models;
using System.Data;
using System.Data.Entity;


namespace Assessment_1.Controllers
{
    public class CodeController : Controller
    {

        private NorthwindEntities db = new NorthwindEntities();

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CustomersResidingInGermany()
        {
            var customer1 = db.Customers.Where(G => G.Country == "Germany").ToList();
            return View(customer1);
        }
        public ActionResult CustomerDetails()
        {
            var customer2 = db.Orders.Where(o => o.OrderID == 10248).Select(o => o.Customer).FirstOrDefault();
            return View(customer2);
        }
    }
}