namespace AcunMedyaTravelProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class category : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Categories", "test");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Categories", "test", c => c.String());
        }
    }
}
