namespace AcunMedyaTravelProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Testimonials",
                c => new
                    {
                        TestimonialID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        SurName = c.String(),
                        ImgUrl = c.Int(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.TestimonialID);
            
            AddColumn("dbo.Categories", "test", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Categories", "test");
            DropTable("dbo.Testimonials");
        }
    }
}
