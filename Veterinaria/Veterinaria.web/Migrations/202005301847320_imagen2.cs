namespace Veterinaria.web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class imagen2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Pets", "ImgUrl", c => c.Binary());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Pets", "ImgUrl", c => c.Byte(nullable: false));
        }
    }
}
