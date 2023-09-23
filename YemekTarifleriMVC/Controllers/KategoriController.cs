using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YemekTarifleriMVC.Models;

namespace YemekTarifleriMVC.Controllers
{
    [Authorize]
    public class KategoriController : Controller
    {
        TarifDbContext db = new TarifDbContext();
        public ActionResult Index()
        {
            var degerler = db.Kategoriler.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult yenikategori()
        {
            return View();
        }
        [HttpPost]
        public ActionResult yenikategori(Kategoriler p1)
        {
            if (ModelState.IsValid)
            {
            db.Kategoriler.Add(p1);
            db.SaveChanges();
            return RedirectToAction("Index");
            }
            return View("yenikategori");
        }
        public ActionResult sil(int id)
        {
            var ktgrsil = db.Kategoriler.Find(id);
            db.Kategoriler.Remove(ktgrsil);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult guncelle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult guncelle(Kategoriler p1)
        {
            var ktg = db.Kategoriler.Find(p1.Id);
            ktg.Ad = p1.Ad;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}