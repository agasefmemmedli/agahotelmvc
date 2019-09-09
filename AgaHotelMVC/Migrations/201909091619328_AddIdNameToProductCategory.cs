namespace AgaHotelMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIdNameToProductCategory : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ProductCategories", "IdName", c => c.String(nullable: false, maxLength: 30));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ProductCategories", "IdName");
        }
    }
}
