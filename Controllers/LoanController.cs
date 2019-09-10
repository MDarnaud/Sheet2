using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sheet2.Controllers
{
    public class LoanController : Controller
    {
        [HttpGet]
        public ActionResult LoanIndex()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LoanIndex(Double investment, Double interest_rate, int years)
        {
            interest_rate /= 100;
            Double Money = investment;

            for(int i = 0; i < years; i++) {
                Money += (Money*interest_rate);
            }
            ViewBag.Money = Money;

            return View();
        }
    }
}