namespace DataAccesLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        AdminID = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 20),
                        Mail = c.String(),
                        Password = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.AdminID);
            
            CreateTable(
                "dbo.Carts",
                c => new
                    {
                        ProductID = c.Int(nullable: false, identity: true),
                        Image = c.String(),
                        ProductName = c.String(maxLength: 25),
                        ProductPrice = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProductID);
            
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        ContactID = c.Int(nullable: false, identity: true),
                        ConatactName = c.String(maxLength: 10),
                        ConatactSurname = c.String(maxLength: 13),
                        ConatactMail = c.String(maxLength: 50),
                        Message = c.String(maxLength: 300),
                        Address = c.String(maxLength: 100),
                        MyMail = c.String(maxLength: 50),
                        Phone = c.String(maxLength: 300),
                    })
                .PrimaryKey(t => t.ContactID);
            
            CreateTable(
                "dbo.MailSubscribes",
                c => new
                    {
                        MailID = c.Int(nullable: false, identity: true),
                        Mail = c.String(maxLength: 50),
                        NameID = c.Int(nullable: false),
                        Name = c.String(maxLength: 15),
                    })
                .PrimaryKey(t => t.MailID);
            
            CreateTable(
                "dbo.OurTeams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Image = c.String(),
                        Title = c.String(),
                        Job = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Shops",
                c => new
                    {
                        ProductID = c.Int(nullable: false, identity: true),
                        ProductName = c.String(maxLength: 50),
                        ProductImage = c.String(),
                        ProductStatus = c.Boolean(nullable: false),
                        ProductPrice = c.String(),
                    })
                .PrimaryKey(t => t.ProductID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 12),
                        UserName = c.String(maxLength: 10),
                        Mail = c.String(maxLength: 50),
                        Password = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
            DropTable("dbo.Shops");
            DropTable("dbo.OurTeams");
            DropTable("dbo.MailSubscribes");
            DropTable("dbo.Contacts");
            DropTable("dbo.Carts");
            DropTable("dbo.Admins");
        }
    }
}
