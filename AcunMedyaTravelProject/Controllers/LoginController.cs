using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using AcunMedyaTravelProject.Context;
using AcunMedyaTravelProject.Entities;

namespace AcunMedyaTravelProject.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {

        AcunmedyaDbContext db = new AcunmedyaDbContext();
        public ActionResult Index()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return View();
        }
        [HttpPost]
        public ActionResult Index(Admin model)
        {
            //Girilen kullanıcı adı veri tabanındaki veriyle eşleşen sütunu getir.  
            var values = db.Admins.FirstOrDefault(x => x.UserName == model.UserName && x.Password == model.Password);

            if (values == null)
            {
                //sayfaya hata mesajı göster
                ModelState.AddModelError(string.Empty, "Kullanıcı adı ve şifre hatalı");
                return View(model);
            }
            FormsAuthentication.SetAuthCookie(model.UserName, false);

            //Geçici veri, viewbag mantığı gibi düşünebilirsin.
            Session["currentUser"] = model.UserName;

            return RedirectToAction("Index", "Service");
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return View();
        }
    }
}