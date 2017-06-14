using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace MVCDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult  Index(string id)
        {
            ViewData["countries"] = new List<string>(){
                "INDIA",
                "USA",
                "UK"

            };
            string CustomerName = "Srikanth Tiruveedula";
            ViewData["CustName"] = CustomerName;
            return View();
       }
    }
}
