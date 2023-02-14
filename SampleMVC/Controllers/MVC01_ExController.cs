using SampleMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleMVC.Controllers
{
    public class MVC01_ExController : Controller
    {
        // GET: MVC01_Ex
        //public ActionResult Index()
        //{
        //    return View();
        //}

        public string helloworld() => "hello from eshwar";
        public void  MathFunction(string v1,string v2)
        {
            double val1 = double.Parse(v1);
            double val2 = double.Parse(v2);
            Add(val1,val2);
        }

        private void Add(double v1,double v2)
        {
            string res= $"after add {v1 + v2}";
            
        }

        public ViewResult DisplayStudent()
        {
            var _student = new Student
            {
                stuId = 101,
                stuName = "Eshwar",
                stuAddress="davangere",
                stuStudying="Engineering",
                stuImage="~/Images/appu.jfif",
            };
            return View(_student);
        }
    }
}