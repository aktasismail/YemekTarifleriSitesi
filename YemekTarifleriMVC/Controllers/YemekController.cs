using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YemekTarifleriMVC.Models;

namespace YemekTarifleriMVC.Controllers
{
    [Authorize]
    public class YemekController : Controller
    {
        TarifDbContext db = new TarifDbContext();
        public ActionResult Yemekler()
        {
            var degerler = db.Tarifler.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult YeniTarif()
        {
            List<SelectListItem> degerler = (from i in db.Kategoriler.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = i.Ad,
                                                 Value = i.Id.ToString()
                                             }
                                             ).ToList();
            ViewBag.DGR = degerler;
            return View();
        }
        [HttpPost]
        public ActionResult YeniTarif(Tarifler p1)
        {
            var ktgrlr = db.Kategoriler.Where(m => m.Id == p1.Kategoriler.Id).FirstOrDefault();
            p1.Kategoriler = ktgrlr;
            db.Tarifler.Add(p1);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Sil(int id)
        {
            var tarifsil = db.Tarifler.Find(id);
            db.Tarifler.Remove(tarifsil);
            db.SaveChanges();
            return RedirectToAction("Yemekler");
        }
        public ActionResult Guncelle(int? id)
        {
            var urun = db.Tarifler.Find(id);
            List<SelectListItem> degerler = (from i in db.Kategoriler.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = i.Ad,
                                                 Value = i.Id.ToString()
                                             }
                                             ).ToList();
            ViewBag.dgr = degerler;
            return View("Guncelle", urun);
        }
        [HttpPost]
        public ActionResult Guncelle(Tarifler p)
        {
            if (ModelState.IsValid)
            {
                var urunler = db.Tarifler.Find(p.Id);
                urunler.Baslik = p.Baslik;
                urunler.Malzemeler = p.Malzemeler;
                urunler.Detaylar = p.Detaylar;
                urunler.Sure = p.Sure;
                urunler.KategoriId = p.Kategoriler.Id;
                db.SaveChanges();
                return RedirectToAction("Yemekler");
            }
            return RedirectToAction("Index");
        }
    }
}