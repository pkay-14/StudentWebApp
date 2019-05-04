using System.Web.Mvc;
using stdblog.Models;

namespace stdblog.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        public ActionResult showblog()
        {


           Blog blog = new Blog();
            
            
            return View(blog);
        }

        public ActionResult about()
        {


            Blog blog = new Blog();
          

                return View(blog);
            }
        public ActionResult Home()
        {


            Blog blog = new Blog();


            return View(blog);
        }
        public ActionResult Contact()
        {


            Blog blog = new Blog();


            return View(blog);
        }
    }
}