namespace FinalProReRe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatecomments : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Comments", name: "ApplicaitonUserId", newName: "ApplicationUserId");
            RenameIndex(table: "dbo.Comments", name: "IX_ApplicaitonUserId", newName: "IX_ApplicationUserId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Comments", name: "IX_ApplicationUserId", newName: "IX_ApplicaitonUserId");
            RenameColumn(table: "dbo.Comments", name: "ApplicationUserId", newName: "ApplicaitonUserId");
        }
    }
}
