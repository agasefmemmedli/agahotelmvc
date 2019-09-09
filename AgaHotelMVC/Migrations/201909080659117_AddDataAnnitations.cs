namespace AgaHotelMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDataAnnitations : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Tocken", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "Fullname", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Customers", "PhoneNumber", c => c.String(nullable: false, maxLength: 12));
            AlterColumn("dbo.Customers", "PersonIdentification", c => c.String(nullable: false, maxLength: 11));
            AlterColumn("dbo.Customers", "Email", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Rooms", "Desc", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Rooms", "Photo", c => c.String(nullable: false));
            AlterColumn("dbo.Products", "Name", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.ProductCategories", "Name", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Users", "FullName", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Users", "Email", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Users", "Password", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Roles", "Name", c => c.String(nullable: false, maxLength: 30));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Roles", "Name", c => c.String());
            AlterColumn("dbo.Users", "Password", c => c.String());
            AlterColumn("dbo.Users", "Email", c => c.String());
            AlterColumn("dbo.Users", "FullName", c => c.String());
            AlterColumn("dbo.ProductCategories", "Name", c => c.String());
            AlterColumn("dbo.Products", "Name", c => c.String());
            AlterColumn("dbo.Rooms", "Photo", c => c.String());
            AlterColumn("dbo.Rooms", "Desc", c => c.String());
            AlterColumn("dbo.Customers", "Email", c => c.String());
            AlterColumn("dbo.Customers", "PersonIdentification", c => c.String());
            AlterColumn("dbo.Customers", "PhoneNumber", c => c.String());
            AlterColumn("dbo.Customers", "Fullname", c => c.String());
            DropColumn("dbo.Users", "Tocken");
        }
    }
}
