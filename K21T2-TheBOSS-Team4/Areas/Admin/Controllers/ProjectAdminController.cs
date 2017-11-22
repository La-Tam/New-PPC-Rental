using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using K21T2_TheBOSS_Team4.Models;

namespace K21T2_TheBOSS_Team4.Areas.Admin.Controllers
{
    public class ProjectAdminController : Controller
    {
        DemoPPCRentalEntities01 db = new DemoPPCRentalEntities01();
        // GET: Admin/ProjectAdmin
        public ActionResult Index()
        {
            var project = db.PROPERTies.OrderByDescending(x => x.ID).ToList();
            return View(project);
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var project = db.PROPERTies.FirstOrDefault(x => x.ID == id);
            ViewBag.project_type = db.PROPERTY_TYPE.OrderByDescending(x => x.ID).ToList();
            ViewBag.streetid = db.STREETs.OrderByDescending(x => x.ID).ToList();
            ViewBag.districtid = db.DISTRICTs.OrderByDescending(x => x.ID).ToList();
            ViewBag.wardid = db.WARDs.OrderByDescending(x => x.ID).ToList();
            ViewBag.userid = db.USERs.OrderByDescending(x => x.ID).ToList();
            ViewBag.statusid = db.PROJECT_STATUS.OrderByDescending(x => x.ID).ToList();
            ViewBag.saleid = db.USERs.OrderByDescending(x => x.ID).ToList();
            return View(project);
        }
        [HttpPost]
        public ActionResult Edit(int id, PROPERTY p)
        {
            var project = db.PROPERTies.FirstOrDefault(x => x.ID == id);
            project.PropertyName = p.PropertyName;
            project.Price = p.Price;
            project.Avatar = p.Avatar;
            project.Updated_at = p.Updated_at;
            project.Sale_ID = p.Sale_ID;
            project.Status_ID = p.Status_ID;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.project_type = db.PROPERTY_TYPE.OrderByDescending(x => x.ID).ToList();
            ViewBag.streetid = db.STREETs.OrderByDescending(x => x.ID).ToList();
            ViewBag.districtid = db.DISTRICTs.OrderByDescending(x => x.ID).ToList();
            ViewBag.wardid = db.WARDs.OrderByDescending(x => x.ID).ToList();
            ViewBag.userid = db.USERs.OrderByDescending(x => x.ID).ToList();
            ViewBag.statusid = db.PROJECT_STATUS.OrderByDescending(x => x.ID).ToList();
            ViewBag.saleid = db.USERs.OrderByDescending(x => x.ID).ToList();
            return View();
        }
        [HttpPost]
        public ActionResult Create(PROPERTY p)
        {
            var project = new PROPERTY();
            project.PropertyName = p.PropertyName;
            project.Price = p.Price;
            project.Avatar = p.Avatar;
            project.PropertyType_ID = p.PropertyType_ID;
            project.Content = p.Content;
            project.Created_at = p.Created_at;
            project.Street_ID = p.Street_ID;
            project.Ward_ID = p.Ward_ID;
            project.District_ID = p.District_ID;
            project.UnitPrice = p.UnitPrice;
            project.Area = p.Area;
            project.BedRoom = p.BedRoom;
            project.BathRoom = p.BathRoom;
            project.PackingPlace = p.PackingPlace;
            project.UserID = p.UserID;  
            project.Sale_ID = p.Sale_ID;
            project.Create_post = p.Create_post;
            project.Status_ID = p.Status_ID;
            project.Note = p.Note;
            db.PROPERTies.Add(project);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            var project = db.PROPERTies.FirstOrDefault(x => x.ID == id);
            return View(project);
        }
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirm(int id)
        {
            var project = db.PROPERTies.FirstOrDefault(x => x.ID == id);
            db.PROPERTies.Remove(project);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Details(int id)
        {
            var project = db.PROPERTies.FirstOrDefault(x => x.ID == id);
            return View(project);
        }
    }
}