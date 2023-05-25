using HtmlHelpersExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HtmlHelpersExample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        // GET: Home
        htmlhelpersdatabaseEntities2 db = new htmlhelpersdatabaseEntities2();

        [HttpPost]
        public ActionResult InsertEmp(Employee emp)
        {
            if (ModelState.IsValid == true)
            {
                db.Employees.Add(emp);
               
                return Content("Successfully Inserted");
            }
            else
            {
                return View("Index");
            }
        }
    }
}