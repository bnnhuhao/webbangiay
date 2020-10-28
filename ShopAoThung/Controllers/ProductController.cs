using ShopAoThung.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopAoThung.Controllers
{
    public class ProductController : Controller
    {
        private BookstoreDbContext db = new BookstoreDbContext();
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult _aoThungNam()
        {
            var list = db.Products.Where(m => m.status == 1 && m.catid == 10).Take(4).ToList();
            return View("_product", list);
        }
        public ActionResult _aoThungNu()
        {
            var list = db.Products.Where(m => m.status == 1 && m.catid == 4).Take(4).ToList();
            return View("_aonu",list);
        }
        public ActionResult _phuKien()
        {
            var list = db.Products.Where(m => m.status == 1 && m.catid ==16).Take(4).ToList();
            return View("_phukien", list);
        }
        public ActionResult _SanphamBanchay()
        {
            var list = db.Products.Where(m => m.status == 1).OrderByDescending(m=>m.sold).Take(4).ToList();
            return View("_banchay", list);
        }
    }
}