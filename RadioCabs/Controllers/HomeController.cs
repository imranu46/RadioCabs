using RadioCabs.Models;
using RadioCabs.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace RadioCabs.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(HomeLogin homeLogin, string returnUrl)
        {

            if (ModelState.IsValid == false)
                return View(homeLogin);

            FormsAuthentication.SetAuthCookie(homeLogin.Username, true);
            if (!string.IsNullOrWhiteSpace(returnUrl))
                return Redirect(returnUrl);

            return RedirectToAction("Index");
            //return RedirectToRoute(new { area = "Admin", controller = "Panel", action = "Index" });
            
            //RadioCabsDBContext radioCabsDB = new RadioCabsDBContext();
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToRoute(new { action="Index", controller ="Home"});
        }

        public ActionResult Explore()
        {
            return View();
        }

        public ActionResult AddListing()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddListing(Listing form)
        {
            //if (ModelState.IsValid == false)
            //    return View(form);
            RadioCabsDBContext dBContext = new RadioCabsDBContext();
            dBContext.listings.Add(form);
            dBContext.SaveChanges();

            return RedirectToAction("Register");
            
            
        }

        

        public ActionResult AddDriver()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddDriver(Driver form)
        {
            //if (ModelState.IsValid == false)
            //    return View(form);
            RadioCabsDBContext dBContext = new RadioCabsDBContext();
            dBContext.drivers.Add(form);
            dBContext.SaveChanges();

            return View(form);
            //return RedirectToAction("Drivers");
        }

        public ActionResult NewAdvertise()
        {
            return View();
        }

        public ActionResult Services()
        {
            return View();
        }

        public ActionResult Feedback()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Feedback(Feedback form)
        {
            //if (ModelState.IsValid == false)
            //    return View(form);
            RadioCabsDBContext dBContext = new RadioCabsDBContext();
            dBContext.feedbacks.Add(form);
            dBContext.SaveChanges();

            return RedirectToAction("Thanks");
            //return RedirectToAction("Drivers");
        }

        public ActionResult Thanks()
        {
            return View();
        }

        public ActionResult MyProfile()
        {
            return View();
        }
    }
}