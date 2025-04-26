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
    public class SliderController : Controller
    {
        // GET: Slider
        AcunmedyaDbContext db = new AcunmedyaDbContext();
        public ActionResult Index()
        {
            var values = db.Sliders.ToList();
            return View(values);
        }
        public ActionResult DeleteSliders(int id)
        {
            var values = db.Sliders.Find(id);
            db.Sliders.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult CreateSliders()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateSliders(Slider slider)
        {
            db.Sliders.Add(slider);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult UpdateSliders(int id)
        {
            var values = db.Sliders.Find(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult UpdateSliders(Slider model)
        {
            var values = db.Sliders.Find(model.SliderID);
            values.Title = model.Title;
            values.Description1 = model.Description1;
            values.Description2 = model.Description2;
            values.ImageUrl = model.ImageUrl;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}