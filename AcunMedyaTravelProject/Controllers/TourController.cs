using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaTravelProject.Context;
using AcunMedyaTravelProject.Entities;

namespace AcunMedyaTravelProject.Controllers
{
    public class TourController : Controller
    {
        // GET: Tour
        AcunmedyaDbContext db = new AcunmedyaDbContext();
        public ActionResult Index()
        {
            var values = db.Tours.ToList();
            return View();
        }
        public ActionResult DeleteGuides(int id)
        {
            var values = db.Tours.Find(id);
            db.Tours.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult CreateTours()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateTours(Tour tour)
        {
            db.Tours.Add(tour);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Tours(int id)
        {
            var values = db.Tours.Find(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult UpdateTours(Tour model)
        {
            var values = db.Tours.Find(model.TourID);
            values.Title = model.Title;
            values.Description1 = model.Description1;
            values.Description2 = model.Description2;
            values.ImageUrl = model.ImageUrl;
            values.Icon1 = model.Icon1;
            values.Icon2 = model.Icon2;
            values.Icon3 = model.Icon3;
            values.Like = model.Like;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}