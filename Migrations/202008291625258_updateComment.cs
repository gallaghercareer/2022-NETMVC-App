namespace FinalProReRe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateComment : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Comments", "Ticket_Id", "dbo.Tickets");
            DropIndex("dbo.Comments", new[] { "Ticket_Id" });
            RenameColumn(table: "dbo.Comments", name: "Ticket_Id", newName: "TicketId");
            AlterColumn("dbo.Comments", "TicketId", c => c.Int(nullable: false));
            CreateIndex("dbo.Comments", "TicketId");
            AddForeignKey("dbo.Comments", "TicketId", "dbo.Tickets", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Comments", "TicketId", "dbo.Tickets");
            DropIndex("dbo.Comments", new[] { "TicketId" });
            AlterColumn("dbo.Comments", "TicketId", c => c.Int());
            RenameColumn(table: "dbo.Comments", name: "TicketId", newName: "Ticket_Id");
            CreateIndex("dbo.Comments", "Ticket_Id");
            AddForeignKey("dbo.Comments", "Ticket_Id", "dbo.Tickets", "Id");
        }
    }
}
