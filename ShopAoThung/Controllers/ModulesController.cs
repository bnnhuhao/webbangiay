using ShopAoThung.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopAoThung.Controllers
{
    public class ModulesController : Controller
    {
        // GET: Modules

        private BookstoreDbContext db = new BookstoreDbContext();
        public ActionResult _header()
        {
            return View("_header");
        }
        public ActionResult _mainmenu()
        {
            var list = db.Menus.Where(m => m.parentid == 0 && m.status == 1)
             .Where(m => m.position == "mainmenu").ToList();
            return View("_mainmenu",list);
        }
        public ActionResult SubMainMenu(int parentid)
        {
            ViewBag.menuitem = db.Menus.Find(parentid);
            var list = db.Menus.Where(m => m.parentid == parentid && m.status == 1)
                .Where(m => m.position == "mainmenu");
            if (list.Count() != 0)
            {
                return View("_SubMainMenu2", list.ToList());
            }
            else
            {
                return View("_SubMainMenu1", list);
            }

        }
        public ActionResult _slider()
        {
            return View("_slider");
        }
        public ActionResult _footer()
        {
            return View("_footer");
        }
    }
}