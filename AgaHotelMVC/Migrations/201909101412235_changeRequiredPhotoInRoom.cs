namespace AgaHotelMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeRequiredPhotoInRoom : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Rooms", "Photo", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Rooms", "Photo", c => c.String(nullable: false));
        }
    }
}
