using System.Web.Mvc;

namespace stdblog.Controllers
{
    public class SidebarController : Controller
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