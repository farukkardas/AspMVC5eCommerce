using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcTicariOtomasyon.Models.Classes;
using System.Web.Mvc;


namespace MvcTicariOtomasyon.Controllers
{
    public class EmployeeController : Controller
    {
        private Context context = new Context();
        // GET: Employee
        public ActionResult Index()
        {
            var result = context.Employees.ToList();
            return View(result);
        }

        [HttpGet]
        public ActionResult EmployeeAdd()
        {
            List<SelectListItem> result1 = (from x in context.Departments.ToList()
                select new SelectListItem()
                {
                    Text = x.DepartmentName,
                    Value = x.DepartmentId.ToString()
                }).ToList();
            ViewBag.rslt1 = result1;

            return View();
        }

        [HttpPost]
        public ActionResult EmployeeAdd(Employee employee)
        {


            context.Employees.Add(employee);
            context.SaveChanges();
            return RedirectToAction("Index");

        }

        public ActionResult GetEmployee(int id)
        {
            List<SelectListItem> result1 = (from x in context.Departments.ToList()
                select new SelectListItem()
                {
                    Text = x.DepartmentName,
                    Value = x.DepartmentId.ToString()
                }).ToList();
            ViewBag.rslt1 = result1;

            var employee = context.Employees.Find(id);
            return View("GetEmployee",employee);
        }

        public ActionResult UpdateEmployee(Employee employee)
        {
            var emp = context.Employees.Find(employee.EmployeeId);
            emp.EmployeeName = employee.EmployeeName;
            emp.EmployeeLastName = employee.EmployeeLastName;
            emp.EmployeeImage = employee.EmployeeImage;
            emp.Departmentid = employee.Departmentid;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}