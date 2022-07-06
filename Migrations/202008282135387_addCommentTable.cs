namespace FinalProReRe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addCommentTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        textBox = c.String(),
                        Ticket_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Tickets", t => t.Ticket_Id)
                .Index(t => t.Ticket_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Comments", "Ticket_Id", "dbo.Tickets");
            DropIndex("dbo.Comments", new[] { "Ticket_Id" });
            DropTable("dbo.Comments");
        }
    }
}
