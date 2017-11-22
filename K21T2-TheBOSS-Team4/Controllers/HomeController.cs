using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using K21T2_TheBOSS_Team4.Models;

namespace K21T2_TheBOSS_Team4.Controllers
{
    public class HomeController : Controller
    {
        DemoPPCRentalEntities01 db = new DemoPPCRentalEntities01();
        public ActionResult Index()
        {
            var p = db.PROPERTies.ToList().OrderByDescending(x => x.ID);
            return View(p);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpGet]
        public ActionResult Search(string text)
        {
            var p = db.PROPERTies.ToList().Where(x => x.PropertyName.ToUpper().Contains(text.ToUpper())  || x.Price.ToString().ToUpper().Contains(text.ToUpper()));
            return View(p);
        }
    }
}