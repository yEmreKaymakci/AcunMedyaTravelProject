using System;
using System.Collections.Generic;
using System.Linq; 
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using AcunMedyaTravelProject.Context;
using AcunMedyaTravelProject.Entities;

namespace AcunMedyaTravelProject.Controllers
{
    [Authorize]
    public class DestinationController : Controller
    {
        // GET: Destination
        AcunmedyaDbContext db = new AcunmedyaDbContext();
        public ActionResult Index()
        {
            var values = db.Destinations.ToList();
            return View(values);
        }


        public ActionResult DeleteDestinations(int id)
        {
            var values = db.Destinations.Find(id);
            db.Destinations.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult CreateDestinations()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateDestinations(Destination destination)
        {
            db.Destinations.Add(destination);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult UpdateDestinations(int id)
        {
            var values = db.Destinations.Find(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult UpdateDestinations(Destination model)
        {
            var values = db.Destinations.Find(model.DestinationID);
            values.ImageUrl = model.ImageUrl;
            values.Title = model.Title;
            values.Description1 = model.Description1;
            values.Description2 = model.Description2;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
     
    }
}