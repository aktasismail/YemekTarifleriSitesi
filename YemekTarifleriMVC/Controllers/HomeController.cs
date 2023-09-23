using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YemekTarifleriMVC.Models;

namespace YemekTarifleriMVC.Controllers
{
    public class HomeController : Controller
    {
        TarifDbContext db = new TarifDbContext();
        public ActionResult Index()
        {
            var degerler = db.Tarifler.ToList();
            return View(degerler);
        }
        public ActionResult Detay(int id)
        {
            var degerler1 = db.Tarifler.Find(id);
            return View(db.Tarifler.Where(p => p.Id == id).FirstOrDefault());
        }
        public ActionResult Listele(int id)
        {

            var degerler1 = db.Tarifler.Where(p => p.KategoriId == id).ToList();
            return View(degerler1);
        }
        public PartialViewResult KategoriListePV()
        {
            return PartialView(db.Kategoriler.ToList());
        }
    }
}