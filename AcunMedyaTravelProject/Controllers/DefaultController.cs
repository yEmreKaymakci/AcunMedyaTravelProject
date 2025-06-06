using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaTravelProject.Context;
using AcunMedyaTravelProject.Entities;

namespace AcunMedyaTravelProject.Controllers
{
    public class DefaultController : Controller
    {
        AcunmedyaDbContext context = new AcunmedyaDbContext();
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialHead()
        {
            return PartialView();
        }
        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }

        public PartialViewResult PartialScript()
        {
            return PartialView();
        }

        public PartialViewResult PartialSlider()
        {
            var values = context.Sliders.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialService()
        {
            var values = context.Services.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialDestinations()
        {
            var values = context.Destinations.ToList();
            return PartialView(values);
        }
        [HttpGet]
        public PartialViewResult PartialBooking()
        {
            var values = context.Bookings.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialBooking2()
        {
            var values = context.Bookings2.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialTestimonial()
        {
            var values = context.Testimonials.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialSponsor()
        {
            var values = context.Partners.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialFooter()
        {
            return PartialView();
        }

        public PartialViewResult PartialCopyright()
        {
            return PartialView();
        }
        public PartialViewResult PartialContact()
        {
            return PartialView();
        }

        public JsonResult SubmitContactForm(Mail model)
        {
            //category değil mesajlar ablosu olacak
            if (ModelState.IsValid)
            {
                context.Mails.Add(model);
                context.SaveChanges();
                return Json(new {success = true, message= "Tebrikler, Abone oldunuz"});
            }
            else
            {
                return Json(new { success = false, message = "Hata, Abone olamadınız" });
            }
        }
    }
}