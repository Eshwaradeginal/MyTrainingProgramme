
using Employee.DataComponent;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;


namespace EmployeeManagement.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee.

        private readonly IDataClasses data = new EmployeeDataComponent();
        public ActionResult Index()
        {
            return PartialView();
        }

        public ActionResult Adding()
        {
            fillDepts();
            return PartialView(new MVCEmployee());
        }

        private void fillDepts()
        {
            List<MVCDepartment> dept = data.GetAllDepts();
            var list = new List<SelectListItem>();
            foreach (var item in dept)
            {
                list.Add(new SelectListItem { Text = item.DeptName, Value = item.DeptId.ToString() });
            }
            ViewData["DeptList"] = list;
        }

        //Adding Post
        [HttpPost]
        public ActionResult Adding(MVCEmployee emp)
        {
            data.AddNewEmployee(emp);
            return RedirectToAction("Index");
        }
        //remove get 
        public ActionResult Removing(int id)
        {
            data.DeleteEmployee(id);
            return RedirectToAction("Index");
        }
        //update get
        //public tlEmployee FindEmp(int id) => data.tlEmployee.FirstOrDefault((c) => c.EntryId == id);
        [HttpGet]
        public ActionResult Edit(int id)
        {
            fillDepts();
            var found = data.GetAllEmployees().FirstOrDefault((e) => e.Empid == id);
            return PartialView(found);
        }
        //update post
        [HttpPost]
        public ActionResult Edit(MVCEmployee emp)
        {

            data.UpdateEmployee(emp);
            return RedirectToAction("Index");
        }
        public ActionResult GetAllEmp()
        {
            var model = data.GetAllEmployees();
            return PartialView(model);
        }

        public ActionResult GetAllDept()
        {
            var model = data.GetAllDepts();
            return PartialView(model);
        }
    }
}