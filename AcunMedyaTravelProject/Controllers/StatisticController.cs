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
    public class StatisticController : Controller
    {
        // GET: Statistic
        AcunmedyaDbContext db = new AcunmedyaDbContext();
        public ActionResult Index()
        {




            ViewBag.AdminCount = db.Admins.Count();
            ViewBag.ServicesCount = db.Services.Count();
            ViewBag.TestimonialCount = db.Testimonials.Count();
            ViewBag.DestinationCount = db.Destinations.Count();
            ViewBag.CategoryCount = db.Categories.Count();

            ViewBag.LastTestimonial = db.Testimonials.OrderByDescending(t => t.TestimonialID).Select(t => t.Name).FirstOrDefault();
            ViewBag.LastDestinations = db.Destinations.OrderByDescending(d => d.DestinationID).Select(d => d.Title).Take(3).ToList();
            ViewBag.FirstDestinations = db.Destinations.OrderBy(d => d.DestinationID).Select(d => d.Title).Take(3).ToList();
            ViewBag.LastCategory = db.Categories.OrderByDescending(t => t.CategoryID).Select(t => t.CategoryName).FirstOrDefault();
            ViewBag.LastServices = db.Services.OrderByDescending(t => t.ServicesID).Select(t => t.Title).FirstOrDefault();


            //ViewBag.ActiveDestinationsCount = db.Destinations.Where(d => d.Status == true).Count(); // Status alanınız varsa
            ViewBag.TotalVisits = 15420; // Sabit değer veya gerçek veri
            ViewBag.MonthlyGrowth = 12.5; // Yüzde artış
            ViewBag.PopularDestination = db.Destinations.OrderByDescending(d => d.DestinationID).Select(d => d.Title).FirstOrDefault();
            return View();


        }
    }
}