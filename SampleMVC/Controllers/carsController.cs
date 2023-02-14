using SampleMVC.DataComponent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleMVC.Controllers
{
    public class carsController : Controller
    {
        // GET: cars
        public ActionResult Index()
        {
            var repo = new carInfoRepo();
            var model = repo.GetAllCars();
            return View(model);
        }

        public ActionResult Edit(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                ViewBag.Message = "car id is not set,please visit index page";
                return View();

            }
            var selectedId = int.Parse(id);
            var repo = new carInfoRepo();
            var model = repo.FindCar(selectedId);
            if (model == null)
            {
                ViewBag.message = "car info not avaailble with us";
                return View();
            }
            return View(model);

        }


        [HttpPost]
        public ActionResult Edit(CarInfo updatedata)
        {
            var repo = new carInfoRepo();
            repo.UpdateCar(updatedata);
            return RedirectToAction("Index");
        }

        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(CarInfo postdata)
        {
            var repo = new carInfoRepo();
            repo.AddNewCar(postdata);
            return RedirectToAction("Index");
        }

    }
}