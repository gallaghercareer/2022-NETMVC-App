namespace FinalProReRe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeCommentTickets : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Comments", "Ticket_Id", "dbo.Tickets");
            DropIndex("dbo.Comments", new[] { "Ticket_Id" });
            AddColumn("dbo.Tickets", "Comment", c => c.String());
            DropTable("dbo.Comments");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        textBox = c.String(),
                        Ticket_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            DropColumn("dbo.Tickets", "Comment");
            CreateIndex("dbo.Comments", "Ticket_Id");
            AddForeignKey("dbo.Comments", "Ticket_Id", "dbo.Tickets", "Id");
        }
    }
}
