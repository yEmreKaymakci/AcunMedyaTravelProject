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
    public class PartnerController : Controller
    {
        // GET: Partner
        AcunmedyaDbContext db = new AcunmedyaDbContext();
        public ActionResult Index()
        {
            var values = db.Partners.ToList();
            return View(values);
        }
        public ActionResult DeletePartners(int id)
        {
            var values = db.Partners.Find(id);
            db.Partners.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult CreatePartners()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreatePartners(Partner partner)
        {
            db.Partners.Add(partner);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Partners(int id)
        {
            var values = db.Partners.Find(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult UpdatePartners(Partner model)
        {
            var values = db.Partners.Find(model.PartnerID);
            values.ImageUrl = model.ImageUrl;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
