using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ismailaktas.Models.entity;

namespace ismailaktas.Controllers
{
    public class yemekController : Controller
    {
        // GET: urunler
        ismailak1_Entities4 db = new ismailak1_Entities4();
        public ActionResult Index()
        {
            var degerler = db.Tablo_Yemek.ToList();
            return View(degerler);
        }
        public ActionResult Oku(int id)
        {
            var degerler1 = db.Tablo_Yemek.Find(id);
            return View(db.Tablo_Yemek.Where(p => p.yemekid == id).FirstOrDefault());
        }
        public ActionResult Listele(int id)
        {
 
            var degerler1 = db.Tablo_Yemek.Where(p => p.kategoriid == id).ToList();
            return View(degerler1);
        }
        public ActionResult basla()
        {
            var degerler = db.Tablo_Kategoriler.ToList();
            return View(degerler);
        }
        //[HttpGet]
        // public ActionResult yeniurun()
        // {
        //     List<SelectListItem> degerler = (from i in db.Tablo_Kategoriler.ToList()
        //                                      select new SelectListItem
        //                                      {
        //                                          Text=i.kategoriad,
        //                                          Value=i.kategoriid.ToString()
        //                                      }
        //                                      ).ToList();
        //     ViewBag.DGR = degerler;
        //     return View();
        // }
        // [HttpPost]
        // public ActionResult yeniurun(Tablo_Yemek p1)
        // {
        //     var ktgrlr = db.Tbl_kategoriler.Where(m => m.kategoriid == p1.Tbl_kategoriler.kategoriid).FirstOrDefault();
        //     p1.Tbl_kategoriler = ktgrlr;
        //     db.Tablo_Yemek.Add(p1);
        //     db.SaveChanges();
        //     return RedirectToAction("urunview");
        // }
        //public ActionResult sil (int id)
        // {
        //     var urunsil = db.Tablo_Yemek.Find(id);
        //     db.Tablo_Yemek.Remove(urunsil);
        //     db.SaveChanges();
        //     return RedirectToAction("urunview");
        // }
        // public ActionResult urungetir (int id)
        // {
        //     var urun = db.Tablo_Yemek.Find(id);
        //     return View("urungetir", urun);
        // }
        // public ActionResult guncelle (Tablo_Yemek p)
        // {
        //     var urunler = db.Tablo_Yemek.Find(p.urunid);
        //     urunler.urunad = p.urunad;
        //     urunler.marka = p.marka;
        //     urunler.fiyat = p.fiyat;
        //     urunler.stok = p.stok;
        //     urunler.urunkategori = p.urunkategori;
        //     db.SaveChanges();
        //     return RedirectToAction("urunview");

        // }
    }
}