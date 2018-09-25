using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RadioCabs.Areas.Admin.Controllers
{
    public class AuthController : Controller
    {
        // GET: Admin/Home
        [Authorize(Roles ="admin")]
        public ActionResult Index()
        {
            return View();
        }
    }
}