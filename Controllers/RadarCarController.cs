using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class RadarCarController : Controller
    {
        // GET: RadarCar
        public ActionResult RadarCarData()
        {
            string[] scopeLabels = { "新潮", "價格", "維修", "性能", "油耗", "配備" };
            int[] suvScores = { 90, 70, 80, 88, 50, 65 };
            int[] sedanScores = { 64, 82, 85, 76, 93, 58 };

            ViewBag.ScopeLabels = scopeLabels;
            ViewBag.SuvScores = suvScores;
            ViewBag.SedanScores = sedanScores;


            return View();
        }
    }
}
