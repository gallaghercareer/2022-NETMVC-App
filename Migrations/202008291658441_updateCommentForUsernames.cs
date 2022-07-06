namespace FinalProReRe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateCommentForUsernames : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Comments", "ApplicaitonUserId", c => c.String(maxLength: 128));
            CreateIndex("dbo.Comments", "ApplicaitonUserId");
            AddForeignKey("dbo.Comments", "ApplicaitonUserId", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Comments", "ApplicaitonUserId", "dbo.AspNetUsers");
            DropIndex("dbo.Comments", new[] { "ApplicaitonUserId" });
            DropColumn("dbo.Comments", "ApplicaitonUserId");
        }
    }
}
