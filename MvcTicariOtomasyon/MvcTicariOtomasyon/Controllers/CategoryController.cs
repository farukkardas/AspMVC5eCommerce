using System.Linq;
using System.Web.Mvc;
using System.Web.Services.Description;
using MvcTicariOtomasyon.Models.Classes;
namespace MvcTicariOtomasyon.Controllers
{
    public class CategoryController : Controller
    {

        Context c = new Context();
        // GET: Category
        public ActionResult Index()
        {
            var degerler = c.Categories.ToList();

            return View(degerler);
        }
        [HttpGet]
        public ActionResult CategoryAdd()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CategoryAdd(Category kCategory)
        {
            if (!ModelState.IsValid)
            {
                return View("CategoryAdd");
            }

            c.Categories.Add(kCategory);
            c.SaveChanges();
            return RedirectToAction("Index"); 
        }

        public ActionResult CategoryDelete(int id)
        {
            var kategori = c.Categories.Find(id);
            c.Categories.Remove(kategori);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult GetCategory(int id)
        {
            var kategori = c.Categories.Find(id);
            return View("GetCategory", kategori);
        }

        public ActionResult UpdateCategory(Category k)
        {
            if (!ModelState.IsValid)
            {
                return View("GetCategory");
            }
            var kategori = c.Categories.Find(k.CategoryId);
            kategori.CategoryName = k.CategoryName;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}