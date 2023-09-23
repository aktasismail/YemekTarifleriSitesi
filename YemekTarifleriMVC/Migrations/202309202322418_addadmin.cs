namespace YemekTarifleriMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addadmin : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admin",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        KullaniciAdi = c.String(),
                        Sifre = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Admin");
        }
    }
}
