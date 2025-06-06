namespace AcunMedyaTravelProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class book : DbMigration
    {
        public override void Up()
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
            
            CreateTable(
                "dbo.Booking2",
                c => new
                    {
                        Booking2ID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Date = c.String(),
                        Description = c.String(),
                        ImageUrl = c.String(),
                    })
                .PrimaryKey(t => t.Booking2ID);
            
            CreateTable(
                "dbo.Mails",
                c => new
                    {
                        MailID = c.Int(nullable: false, identity: true),
                        MailName = c.String(),
                    })
                .PrimaryKey(t => t.MailID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Mails");
            DropTable("dbo.Booking2");
            DropTable("dbo.Bookings");
        }
    }
}
