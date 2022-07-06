namespace FinalProReRe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removeRow : DbMigration
    {
        public override void Up()
        {
            Sql("DELETE FROM Comments WHERE Id='2'; ");
        }
        
        public override void Down()
        {
        }
    }
}
