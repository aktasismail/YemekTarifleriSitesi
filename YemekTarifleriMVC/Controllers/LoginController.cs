using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using YemekTarifleriMVC.Models;

namespace YemekTarifleriMVC.Controllers
{
    public class LoginController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Admin p)
        {
            TarifDbContext db = new TarifDbContext();
            var bilgiler = db.Admin.FirstOrDefault(x => x.KullaniciAdi == p.KullaniciAdi &&
            x.Sifre == p.Sifre);
            if (bilgiler != null)
            {
                FormsAuthentication.SetAuthCookie(bilgiler.KullaniciAdi, false);
                Session["KullaniciAdi"] = bilgiler.KullaniciAdi;
                return RedirectToAction("Index", "Kategori");
            }
            else
            {
                return RedirectToAction("Index");
            }
            
        }
        public ActionResult CikisYap()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("Index", "Home");
        }
    }
    
}