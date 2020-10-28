using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShopAoThung.Models;
namespace ShopAoThung.Controllers
{
    public class HomeController : Controller
    {
        BookstoreDbContext db = new BookstoreDbContext();
        // GET: Home
        public ActionResult Index()
        {
            var list = db.Products.Where(m => m.status == 1).ToList();

            return View(list);
        }
    }
}