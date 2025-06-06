using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaTravelProject.Context;
using AcunMedyaTravelProject.Entities;

namespace AcunMedyaTravelProject.Controllers
{
    [Authorize]
    public class BookingController : Controller
    {
        AcunmedyaDbContext db = new AcunmedyaDbContext();
        // GET: Booking
        public ActionResult Index()
        {
            var values = db.Bookings.ToList();
            return View(values);
        }

        public ActionResult DeleteBooking(int id)
        {
            var value = db.Bookings.Find(id);
            db.Bookings.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult AddBooking()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddBooking(Booking model)
        {
            db.Bookings.Add(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateBooking(int id)
        {
            var value = db.Bookings.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateBooking(Booking model)
        {
            var value = db.Bookings.Find(model.BookingID);
            value.Title = model.Title;
            value.Description = model.Description;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}