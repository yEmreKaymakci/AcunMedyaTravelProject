using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using System.Web.Services.Description;
using AcunMedyaTravelProject.Context;
using AcunMedyaTravelProject.Entities;

namespace AcunMedyaTravelProject.Controllers
{
    [Authorize]
    public class ServiceController : Controller
    {
        // GET: Services
        AcunmedyaDbContext db = new AcunmedyaDbContext();
        public ActionResult Index()
        {
            var values = db.Services.ToList();
            return View(values);
        }
        public ActionResult DeleteServices(int id)
        {
            var values = db.Services.Find(id);
            db.Services.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult CreateServices()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateServices(Services service)
        {
            db.Services.Add(service);
            db.SaveChanges();
            return RedirectToAction("Index");
        }


        public ActionResult UpdateServices(int id)
        {
            var values = db.Services.Find(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult UpdateServices(Services model)
        {
            var values = db.Services.Find(model.ServicesID);
            values.Title = model.Title;
            values.Description = model.Description;
            values.ImageUrl = model.ImageUrl;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return View();
        }
        public ActionResult SearchServices(string searchText)
        {
            var result = string.IsNullOrEmpty(searchText) ? new List<Services>() : db.Services.Where(x => x.Title.Contains(searchText) || x.Description.Contains(searchText)).ToList();
            return View(result);
        }
    }
}