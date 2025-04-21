namespace AcunMedyaTravelProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_first1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Testimonials", "ImgUrl", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Testimonials", "ImgUrl", c => c.Int(nullable: false));
        }
    }
}
