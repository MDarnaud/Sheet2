using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sheet2.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult LoanIndex()
        {
            return View();
        }



         

        public ActionResult GradesIndex()
        {
            return View();
        }
    }
}