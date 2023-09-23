using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace YemekTarifleriMVC.Models
{
    public class TarifDbContext:DbContext
    {
        public TarifDbContext()
        
           : base("name=TarifConnection")
        { 
           
        }
        public DbSet<Kategoriler> Kategoriler { get; set; }
        public DbSet<Tarifler> Tarifler { get; set; }
        public DbSet<Admin> Admin { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
        
    }
}