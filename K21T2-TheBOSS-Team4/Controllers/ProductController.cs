using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using K21T2_TheBOSS_Team4.Models;

namespace K21T2_TheBOSS_Team4.Controllers
{
    public class ProductController : Controller
    { 
        DemoPPCRentalEntities01 model = new DemoPPCRentalEntities01();
        public ActionResult Detail(int id)
        {
            var product = model.PROPERTies.FirstOrDefault(x => x.ID == id);
            return View(product);
        }
    }
}