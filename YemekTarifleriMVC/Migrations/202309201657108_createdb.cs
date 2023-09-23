namespace YemekTarifleriMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createdb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kategoriler",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ad = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Tarifler",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Baslik = c.String(),
                        Malzemeler = c.String(),
                        Detaylar = c.String(),
                        Gorsel = c.String(),
                        Sure = c.String(),
                        KategoriId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Kategoriler", t => t.KategoriId, cascadeDelete: true)
                .Index(t => t.KategoriId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tarifler", "KategoriId", "dbo.Kategoriler");
            DropIndex("dbo.Tarifler", new[] { "KategoriId" });
            DropTable("dbo.Tarifler");
            DropTable("dbo.Kategoriler");
        }
    }
}
