using stdblog.Models;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Web.Security;
using System.Linq;

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

            if (ModelState.IsValid)
            {
                var login = new Login();
                var dbase = new tblStudent();
                //login.Username = model.loginvm.Username;
                //login.Password = model.loginvm.Password;
                using (studentDBase studentDBase = new studentDBase())
                {
                    if (studentDBase.tblStudents.Any(x => x.User__Name == model.loginvm.Username) && studentDBase.tblStudents.Any(x => x.Password == model.loginvm.Password))
                    {
                        return RedirectToAction("Home");
                    }
                    else  ModelState.AddModelError("","Incorrect Username or Password ");
                    return View(model);
                }
               
            }
            else return View(model);

         }
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        [Route("Account/Register")]
        public ActionResult Register(LoginRegisterVM model, string sReturnURL)
        {
            //flags that you are using Register Action
            model.IsActionRegister();

            if (ModelState.IsValid)
            {

                var tblStud = new tblStudent();
                //RegisterVM registerVM = new RegisterVM();
                using (studentDBase studentDBase = new studentDBase())
                {
                    if (studentDBase.tblStudents.Any(x => x.User__Name == model.registervm.Username))
                    {

                     ModelState.AddModelError("", " Username already exists! ");
                        return View(model);
                    }
                    tblStud.Country = model.registervm.Country;
                    tblStud.Email = model.registervm.Email;
                    tblStud.First_Name = model.registervm.Name;
                    tblStud.Last_Name = model.registervm.Surname;
                    tblStud.Password = model.registervm.Password;
                    tblStud.User__Name = model.registervm.Username;

                    studentDBase.tblStudents.Add(tblStud);
                    studentDBase.SaveChanges();
                    return RedirectToAction("Home");
                    
                  
                  

                }
            }
                 else return View(model);
        }

        public ActionResult BlogAction()
        {
            return View();
        }

    }





}






