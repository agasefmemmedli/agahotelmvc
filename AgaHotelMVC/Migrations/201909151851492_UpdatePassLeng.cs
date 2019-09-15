namespace AgaHotelMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatePassLeng : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "Password", c => c.String(nullable: false, maxLength: 80));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "Password", c => c.String(nullable: false, maxLength: 30));
        }
    }
}
