namespace AgaHotelMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeEnum : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Rooms", "BedTypeId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Rooms", "BedTypeId", c => c.Int(nullable: false));
        }
    }
}
