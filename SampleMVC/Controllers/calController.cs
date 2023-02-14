using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleMVC.Controllers
{
    public class calController : Controller
    {
        // GET: cal
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string firstval,string secondval,string operand)
        {
            string message = string.Empty;
            double v1 = double.Parse(firstval);
            double v2 = double.Parse(secondval);
            switch (operand)
            {
                case "Add": message = (v1 + v2).ToString(); break;
                case "substract": message = (v1 - v2).ToString(); break;
                case "multiplay": message = (v1 * v2).ToString(); break;
                case "Devide": message = (v1 / v2).ToString(); break;

            }

            ViewBag.message = $"the Result is { message}";
            return View();
        }
    }
}