using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcTicariOtomasyon.Models.Classes;

namespace MvcTicariOtomasyon.Controllers
{
    public class ProductController : Controller
    {
        private Context context = new Context();
        // GET: Product
        public ActionResult Index()
        {

            var products = context.Products.Where(x => x.ProductState == true).ToList();

            return View(products);
        }
        [HttpGet]
        public ActionResult NewProduct()
        {
            
            List<SelectListItem> result1 = (from x in context.Categories.ToList()
                    select new SelectListItem()
                    {
                        Text = x.CategoryName,
                        Value = x.CategoryId.ToString()
                    }).ToList();
                ViewBag.rslt1 = result1;

                return View();

           
        }

        public ActionResult NewProduct(Product product)
        {
            if (!ModelState.IsValid)
            {
                return View("NewProduct");
            }

            context.Products.Add(product);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteProduct(int id)
        {
            var result = context.Products.Find(id);
            result.ProductState = false;
            context.SaveChanges();
            return RedirectToAction("Index");

        }

        public ActionResult GetProduct(int id)
        {

            List<SelectListItem> result1 = (from x in context.Categories.ToList()
                select new SelectListItem()
                {
                    Text = x.CategoryName,
                    Value = x.CategoryId.ToString()
                }).ToList();
            ViewBag.rslt1 = result1;

            var resultProduct = context.Products.Find(id);
            return View("GetProduct",resultProduct);


        }

        public ActionResult UpdateProduct(Product p)
        {
            var product = context.Products.Find(p.ProductId);
            product.ProductPurchasePrice = p.ProductPurchasePrice;
            product.ProductSalePrice = p.ProductSalePrice;
            product.ProductName = p.ProductName;
            product.ProductBrand = p.ProductBrand;
            product.ProductState = p.ProductState;
            product.CategoryId = p.CategoryId;
            product.ProductStock = p.ProductStock;
            product.ProductImage = p.ProductImage;
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult ListProducts()
        {
            var results = context.Products.ToList();
            return View(results);
        }
    }
}