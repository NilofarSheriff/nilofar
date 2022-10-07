using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using october4_aspmvc.Models;


namespace october4_aspmvc.Controllers
{
    public class CustomerController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AddCustomer()
        {
            return View();
        }
        public ActionResult DeleteCustomer()
        {
            return View();
        }
    }
}
