using System.ComponentModel.DataAnnotations;

namespace YemekTarifleriMVC.Models
{
    public class Kategoriler
    {
        [Key]
        public int Id { get; set; }
        public string Ad { get; set; }
    }
}