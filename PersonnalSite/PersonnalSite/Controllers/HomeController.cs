using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Validation.Web.Models;

namespace PersonnalSite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult PriorExp()
        {
            return View("PriorExp");
        }

        // GET: User/Login
        // Return the empty login view
        [HttpGet]
        public ActionResult Login()
        {
            return View("Login");
        }
        // POST: User/Login  
        // Validate the model and redirect to login (if successful) or return the 
        // login view (if validation fails)
        [HttpPost]
        public ActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                return View("Confirmation", model);
            }

            return RedirectToAction("Login", "Home");
        }
        // GET: User/Confirmation
        // Return the confirmation view
        [HttpGet]
        public ActionResult Confirmation()
        {
            return View("Confirmation");
        }
    }
    //[HttpGet]
    //public ActionResult Review() { return View(); }

    //[HttpPost]
    //public ActonResult Review(Review rev) { if (){return View()} return View();}

    //[HttpGet]
    //public ActionResult SignUp(){ return View(); }

    //[HttpPost]
    //public ActionResult SignUp(NewsLetter letter) {if (){return View()} return View();}
}
