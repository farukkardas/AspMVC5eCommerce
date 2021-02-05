using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcTicariOtomasyon.Models.Classes;

namespace MvcTicariOtomasyon.Controllers
{
    public class SaleController : Controller
    {
        private Context context = new Context();
        // GET: Sale
        public ActionResult Index()
        {
            var results = context.SaleMovements.ToList();
            return View(results);
        }

        [HttpGet]
        public ActionResult NewSale()
        {
            List<SelectListItem> degerList = (from x in context.Products.ToList()
                select new SelectListItem
                {
                    Text = x.ProductName,
                    Value = x.ProductId.ToString()
                }).ToList();
            ViewBag.dgr1 = degerList;

            List<SelectListItem> degerList2 = (from x in context.Customers.ToList()
                select new SelectListItem
                {
                    Text = x.CustomerName + " " + x.CustomerLastName,
                    Value = x.CustomerId.ToString()
                }).ToList();

            ViewBag.dgr2 = degerList2;
           
            List<SelectListItem> degerList3 = (from x in context.Employees.ToList()
                select new SelectListItem
                {
                    Text = x.EmployeeName + " " + x.EmployeeLastName,
                    Value = x.EmployeeId.ToString()
                }).ToList();

            ViewBag.dgr3 = degerList3;




            return View();
        }

        [HttpPost]
        public ActionResult NewSale(SaleMovement sale)
        {
            sale.SaleMovementDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            context.SaleMovements.Add(sale);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult GetSale(int id)
        {
            List<SelectListItem> degerList = (from x in context.Products.ToList()
                select new SelectListItem
                {
                    Text = x.ProductName,
                    Value = x.ProductId.ToString()
                }).ToList();
            ViewBag.dgr1 = degerList;

            List<SelectListItem> degerList2 = (from x in context.Customers.ToList()
                select new SelectListItem
                {
                    Text = x.CustomerName + " " + x.CustomerLastName,
                    Value = x.CustomerId.ToString()
                }).ToList();

            ViewBag.dgr2 = degerList2;

            List<SelectListItem> degerList3 = (from x in context.Employees.ToList()
                select new SelectListItem
                {
                    Text = x.EmployeeName + " " + x.EmployeeLastName,
                    Value = x.EmployeeId.ToString()
                }).ToList();

            ViewBag.dgr3 = degerList3;
            var result = context.SaleMovements.Find(id);
            return View("GetSale", result);
            
        }

        public ActionResult UpdateSale(SaleMovement saleMovement)
        {
            var result = context.SaleMovements.Find(saleMovement.SaleMovementId);
            result.Customerid = saleMovement.Customerid;
            result.Productid = saleMovement.Productid;
            result.Employeeid = saleMovement.Employeeid;
            result.SaleMovementPrice = saleMovement.SaleMovementPrice;
            result.SaleMovementTotalPrice = saleMovement.SaleMovementTotalPrice;
            result.SaleMovementUnit = saleMovement.SaleMovementUnit;
            result.SaleMovementDate = saleMovement.SaleMovementDate;
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult PrintSale(int id)
        {
            var results = context.SaleMovements.Where(x => x.SaleMovementId == id).ToList();
            return View(results);
        }
    }

    
}