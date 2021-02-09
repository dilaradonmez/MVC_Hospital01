using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Hospital.Areas.Doctor.Controllers
{
    [Authorize(Roles = "doctor,manager")]
    public class HomeController : Controller
    {

        // GET: Doctor/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}