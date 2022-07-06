namespace FinalProReRe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addTicketTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tickets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ApplicationUserId = c.String(maxLength: 128),
                        Date = c.DateTime(nullable: false),
                        Resolved = c.Boolean(nullable: false),
                        Instructions = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUserId)
                .Index(t => t.ApplicationUserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tickets", "ApplicationUserId", "dbo.AspNetUsers");
            DropIndex("dbo.Tickets", new[] { "ApplicationUserId" });
            DropTable("dbo.Tickets");
        }
    }
}
