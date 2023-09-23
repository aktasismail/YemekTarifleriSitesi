using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace YemekTarifleriMVC.Models
{
    public class Tarifler
    {
        [Key]
        public int Id { get; set; }
        public string Baslik { get; set; }
        public string Malzemeler { get; set; }
        public string Detaylar { get; set; }
        public string Gorsel { get; set; }
        public string Sure { get; set; }
        public int KategoriId { get; set; }
        [ForeignKey("KategoriId")]
        public Kategoriler Kategoriler { get; set; }
    }
}