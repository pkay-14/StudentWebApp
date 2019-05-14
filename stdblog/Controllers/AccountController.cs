using stdblog.Models;
using System.Web.Mvc;



namespace stdblog.Controllers
{
    public class AccountController : Controller
    {
        
        public ActionResult Home()
        {
            return View();
        }

        public ActionResult LoginRegister(LoginRegisterVM model, string sReturnURL)
        {
            //flags that you are using Login Action

            //model.IsActionLogin();
            //process your login logic here
            return View(model);

        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        [Route("Account/Login")]
        public ActionResult Login(LoginRegisterVM model, string sReturnURL)
        {
            //flags that you are using Login Action

            model.IsActionLogin();
            //process your login logic here
            if (ModelState.IsValid)
            {
               
                return View("Home");
            }
            else return View(model);

         }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        [Route("Account/Register")]
        public ActionResult Register(LoginRegisterVM model, string sReturnURL)
        {
            //flags that you are using Login Action

            model.IsActionRegister();
            //process your login logic here
            if (ModelState.IsValid)
            {
                return View("Home");

            }
           else return View(model);

        }

       

    }





}






