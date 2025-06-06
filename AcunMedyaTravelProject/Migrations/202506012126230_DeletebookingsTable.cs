namespace AcunMedyaTravelProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeletebookingsTable : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Bookings");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Bookings",
                c => new
                    {
                        BookingID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        ImageUrl = c.String(),
                    })
                .PrimaryKey(t => t.BookingID);
            
        }
    }
}
