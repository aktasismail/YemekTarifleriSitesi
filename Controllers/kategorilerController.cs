using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ismailaktas.Models.entity;

namespace ismailaktas.Controllers
{
    public class kategorilerController : Controller
    {
        // GET: kategoriler
        ismailak1_Entities4 db = new ismailak1_Entities4();
        public ActionResult Index()
        {
            var degerler = db.Tablo_Kategoriler.ToList();
            return View(degerler);
        }

        
        //[HttpGet]
        //public ActionResult yenikategori()
        //{
        //    return View();
        //}
        //[HttpPost]
        //public ActionResult yenikategori(Tbl_kategoriler p1)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return View("yenikategori");
        //    }
        //    db.Tbl_kategoriler.Add(p1);
        //    db.SaveChanges();
        //    return View();
        //}
        //public ActionResult sil(int id)
        //{
        //    var ktgrsil = db.Tbl_kategoriler.Find(id);
        //    db.Tbl_kategoriler.Remove(ktgrsil);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}
        //public ActionResult kategoriguncelle (int id)
        //{
        //    var ktgr = db.Tbl_kategoriler.Find(id);
        //    return View("kategoriguncelle",ktgr);
        //}
        //public ActionResult guncelle (Tbl_kategoriler p1)
        //{
        //    var ktg = db.Tbl_kategoriler.Find(p1.kategoriid);
        //    ktg.kategoriad = p1.kategoriad;
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}
    }
}