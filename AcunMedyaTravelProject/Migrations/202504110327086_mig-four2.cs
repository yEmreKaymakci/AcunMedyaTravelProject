namespace AcunMedyaTravelProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migfour2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Sliders", "Description1", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Sliders", "Description1", c => c.String());
        }
    }
}
