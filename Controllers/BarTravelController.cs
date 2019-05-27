using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class BarTravelController : Controller
    {
        // GET: BarTravel
        public ActionResult BarTravel()
        {
            return View();
        }

        // GET: BarTravel
        public ActionResult BarTravelData()
        {
            string[] countries = { "法國", "美國", "中國", "澳洲", "德國", "俄羅斯" };
            int[] votes = { 8, 22, 13, 15, 17, 21 };

            ViewBag.Countries = countries;
            ViewBag.Votes = votes;

            return View();
        }
    }
}
