namespace FinalProReRe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedDB : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO TICKETS (DATE, RESOLVED, INSTRUCTIONS, APPLICATIONUSERID) VALUES ('2013-08-30 19:05:00', 'false', 'Printer says network error', '0c09731f-69a5-412a-b6ed-d5058b7833da')");
            Sql(@"INSERT INTO TICKETS (DATE, RESOLVED, INSTRUCTIONS, APPLICATIONUSERID) VALUES ('2012-08-30 19:05:00', 'true', 'MONITOR blinks error', '1b0b16ff-a049-482b-80e1-1264e8784a9d')");
            Sql(@"INSERT INTO TICKETS (DATE, RESOLVED, INSTRUCTIONS, APPLICATIONUSERID) VALUES ('2011-08-30 19:05:00', 'false', 'IT room says network error', '5865dcf0-fe63-4154-b38d-d8397d57ebcc')");
        }
        
        public override void Down()
        {
        }
    }
}
