using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaTravelProject.Context;
using AcunMedyaTravelProject.Entities;

namespace AcunMedyaTravelProject.Controllers
{
    public class MailController : Controller
    {
        AcunmedyaDbContext context = new AcunmedyaDbContext();
        // GET: Mail
        public ActionResult Index()
        {
            var values = context.Mails.ToList();
            return View(values);
        }

        public ActionResult DeleteMail(int id)
        {
            var value = context.Mails.Find(id);
            context.Mails.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult SearchMail(string searchText)
        {
            var result = string.IsNullOrEmpty(searchText) ? new List<Mail>() : context.Mails.Where(x => x.MailName.Contains(searchText)).ToList();
            return View(result);
        }
    }
}