using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShopAoThung.Models;
namespace ShopAoThung.Controllers
{
    public class ProductCategoryController : Controller
    {
        BookstoreDbContext db = new BookstoreDbContext();
        // GET: ProductCategory
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Category(string slug)
        {
            ViewBag.slug = slug;
            ViewBag.category = db.Categorys.Where(m => m.status == 1).ToList();
            var list = db.Categorys.Where(m => m.slug == slug).First();
            return View(list);
        }
        public ActionResult Subcategory(int catid)
        {
            var list = db.Products.Where(m => m.catid == catid).Where(x => x.status == 1);
                 return View(list.ToList());


        }

    }
}