using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace stdblog.Controllers
{
    public class sidebarController : Controller
    {
        // GET: sidebar
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Sidebar()
        {
            return PartialView("sidebarmain");
        }
        public ActionResult Partial()
        {
            return PartialView();
        }
    }
}