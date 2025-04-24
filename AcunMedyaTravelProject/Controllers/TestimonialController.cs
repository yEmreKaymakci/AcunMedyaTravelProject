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
    public class TestimonialController : Controller
    {
        // GET: Testimonial
        AcunmedyaDbContext db = new AcunmedyaDbContext();
        public ActionResult Index()
        {
            var values = db.Testimonials.ToList();
            return View(values);
        }
        public ActionResult DeleteTestimonials(int id)
        {
            var values = db.Testimonials.Find(id);
            db.Testimonials.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult CreateTestimonials()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateTestimonials(Testimonial testimonial)
        {
            db.Testimonials.Add(testimonial);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Testimonials(int id)
        {
            var values = db.Testimonials.Find(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult UpdateTestimonials(Testimonial model)
        {
            var values = db.Testimonials.Find(model.TestimonialID);
            values.Name = model.Name;
            values.SurName = model.SurName;
            values.ImgUrl = model.ImgUrl;
            values.Description = model.Description;
            values.Location = model.Location;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}