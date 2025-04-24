namespace AcunMedyaTravelProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class guide : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Guides", "ImageUrl", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Guides", "ImageUrl", c => c.Int(nullable: false));
        }
    }
}
