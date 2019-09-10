using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sheet2.Controllers
{
    public class GradesController : Controller
    {
        [HttpGet]
        public ActionResult GradesIndex()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GradesIndex(FormCollection data)
        {
            string grade1String = data["grade1"];
            string grade2String = data["grade2"];
            string grade3String = data["grade3"];

            Double grade1 = Convert.ToDouble(grade1String);
            Double grade2 = Convert.ToDouble(grade2String);
            Double grade3 = Convert.ToDouble(grade3String);

            String averageLetter = "null";
            Double average = (grade1 + grade2 + grade3) / 3;
            if (average >= 90)
            {
                averageLetter = "A";
            }
            else if (average >= 80 && average < 90)
            {
                averageLetter = "B";
            }
            else if (average >= 70 && average < 80)
            {
                averageLetter = "C";
            }
            else if (average >= 60 && average < 70)
            {
                averageLetter = "D";
            }
            else if (average < 60)
            {
                averageLetter = "E";
            }

            ViewBag.Grade = averageLetter;

            return View();

        }


    }
}