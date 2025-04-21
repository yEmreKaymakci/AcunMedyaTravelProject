namespace AcunMedyaTravelProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migthree : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Testimonials", "Location", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Testimonials", "Location");
        }
    }
}
