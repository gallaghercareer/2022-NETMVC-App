namespace FinalProReRe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class jquery : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Tickets", "Comment");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tickets", "Comment", c => c.String());
        }
    }
}
