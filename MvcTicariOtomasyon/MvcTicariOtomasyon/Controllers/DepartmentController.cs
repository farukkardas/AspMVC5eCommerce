using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcTicariOtomasyon.Models.Classes;
namespace MvcTicariOtomasyon.Controllers
{
    public class DepartmentController : Controller
    {
        private Context context = new Context();
        // GET: Department
        public ActionResult Index()
        {
            var results = context.Departments.Where(x => x.State == true).ToList();
            return View(results);
        }

        [HttpGet]
        public ActionResult AddDepartment()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddDepartment(Department department)
        {
            department.State = true;
            context.Departments.Add(department);
            context.SaveChanges();
            return RedirectToAction("Index");

        }

        public ActionResult DeleteDepartment(int id)
        {
            var delete = context.Departments.Find(id);
            delete.State = false;
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult GetDepartment(int id)
        {
            var dpt = context.Departments.Find(id);
            return View("GetDepartment", dpt);

        }

        public ActionResult UpdateDepartment(Department p)
        {
            var dept = context.Departments.Find(p.DepartmentId);
            dept.DepartmentName = p.DepartmentName;
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult InfoDepartment(int id)
        {
            var results = context.Employees.Where(x => x.Departmentid == id).ToList();
            var getdpt = context.Departments.Where(d => d.DepartmentId == id).Select(y => y.DepartmentName).FirstOrDefault();
            ViewBag.dpt = getdpt;

            return View(results);


        }

        public ActionResult DepartmentEmployeeResult(int id)
        {
            var resultsx = context.SaleMovements.Where(z => z.Employeeid== id).ToList();    
            var per = context.Employees.Where(x => x.EmployeeId == id).Select(y => y.EmployeeName + " " + y.EmployeeLastName).FirstOrDefault();

            ViewBag.dp = per;
            return View(resultsx);
        }
    }
}