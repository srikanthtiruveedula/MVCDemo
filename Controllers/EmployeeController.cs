using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDemo.Models;

namespace MVCDemo.Controllers
{
    public class EmployeeController : Controller
    {
        //
        // GET: /Employee/

        public ActionResult GetDetails()
        {
            ViewData["emp"] = new Employee()
            {
                Id=583,
                Name="Srikanth",
                City = "Mangalagiri"
            };
            ViewBag.Emp = new Employee()
            {
                Id=582,
                Name = "Srikanth",
                City = "Mangalagiri"

            };
            Employee emp = new Employee()
            {
                Id = 584,
                Name = "Sivaram",
                City = "Nambur"
            };
            return View(emp);
        }

    }
}
