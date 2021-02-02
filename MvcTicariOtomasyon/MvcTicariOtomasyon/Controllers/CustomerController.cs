using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcTicariOtomasyon.Models.Classes;

namespace MvcTicariOtomasyon.Controllers
{
    public class CustomerController : Controller
    {
        
        // GET: Customer

        private Context context = new Context();
        public ActionResult Index()
        {
            var result = context.Customers.Where(x => x.Durum == true).ToList();
            return View(result);
        }

        public ActionResult CustomerDelete(int id)
        {
            var result = context.Customers.Find(id);
            result.Durum = false;
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult CustomerAdd()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CustomerAdd(Customer customer)
        {
            customer.Durum = true;
            context.Customers.Add(customer);
            context.SaveChanges();
            return RedirectToAction("Index");

        }

        public ActionResult GetCustomer(int id)
        {
            var customer = context.Customers.Find(id);
            return View("GetCustomer", customer);

        }

        public ActionResult CustomerUpdate(Customer customer)
        {
            if (!ModelState.IsValid)
            {
                return View("GetCustomer");
            }
            
            
            
            
            
            var result = context.Customers.Find(customer.CustomerId);
            result.CustomerName = customer.CustomerName;
            result.CustomerLastName = customer.CustomerLastName;
            result.CustomerCity = customer.CustomerCity;
            result.CustomerMail = customer.CustomerMail;
            context.SaveChanges();
            return RedirectToAction("Index");


        }
    }
}