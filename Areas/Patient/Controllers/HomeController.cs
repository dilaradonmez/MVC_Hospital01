using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Hospital.Areas.Patient.Controllers
{
    [Authorize(Roles = "patient,manager,doctor")]
    public class HomeController : Controller
    {

        // GET: Patient/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}