using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaTravelProject.Context;
using AcunMedyaTravelProject.Entities;

namespace AcunMedyaTravelProject.Controllers
{
    public class AdvertController : Controller
    {
        AcunmedyaDbContext context = new AcunmedyaDbContext();
        // GET: Advert
        public ActionResult Index()
        {
            var values = context.Bookings2.ToList();
            return View(values);
        }

        public ActionResult DeleteAdvert(int id)
        {
            var value = context.Bookings2.Find(id);
            context.Bookings2.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult AddAdvert()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddAdvert(Booking2 model)
        {
            context.Bookings2.Add(model);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateAdvert(int id)
        {
            var value = context.Bookings2.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateAdvert(Booking2 model)
        {
            var value = context.Bookings2.Find(model.Booking2ID);
            value.Title = model.Title;
            value.Date = model.Date;
            value.Description = model.Description;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}