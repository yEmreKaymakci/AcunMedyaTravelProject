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
    public class CategoryController : Controller
    {
        // GET: Categories
        AcunmedyaDbContext db = new AcunmedyaDbContext();
        public ActionResult Index()
        {
            var values = db.Categories.ToList();
            return View(values);
        }


        public ActionResult DeleteCategories(int id)
        {
            var values = db.Categories.Find(id);
            db.Categories.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult CreateCategories()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateCategories(Category category)
        {
            db.Categories.Add(category);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult UpdateCategories(int id)
        {
            var values = db.Categories.Find(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult UpdateCategories(Category model)
        {
            var values = db.Categories.Find(model.CategoryID);
            values.CategoryName = model.CategoryName;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}