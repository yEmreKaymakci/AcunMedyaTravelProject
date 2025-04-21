using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaTravelProject.Context;
using AcunMedyaTravelProject.Entities;

namespace AcunMedyaTravelProject.Controllers
{
    public class GuideController : Controller
    {
        // GET: Guide
        AcunmedyaDbContext db = new AcunmedyaDbContext();
        public ActionResult Index()
        {
            var values = db.Guides.ToList();
            return View();
        }
        public ActionResult DeleteGuides(int id)
        {
            var values = db.Guides.Find(id);
            db.Guides.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult CreateGuides()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateGuides(Guide guide)
        {
            db.Guides.Add(guide);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Guides(int id)
        {
            var values = db.Guides.Find(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult UpdateGuides(Guide model)
        {
            var values = db.Guides.Find(model.GuideID);
            values.Title = model.Title;
            values.ImageUrl = model.ImageUrl;
            values.Description1 = model.Description1;
            values.Description2 = model.Description2;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}