namespace FinalProReRe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class upde : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Tickets", "Instructions", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Tickets", "Instructions", c => c.String());
        }
    }
}
