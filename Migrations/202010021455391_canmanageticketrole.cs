namespace FinalProReRe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class canmanageticketrole : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'12e9505f-0e6e-404d-8bb8-03d22a747560', N'employee@hiring.com', 0, N'AF3o8Iz7wV8tfCvhr8wvR/zhZoegS4E+h/qHM7K+df3imOWZhc3CkGD7I9PfeEtdRQ==', N'be8924b7-5d02-43a8-a3a0-31072ba9fbd3', NULL, 0, 0, NULL, 1, 0, N'employee@hiring.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'73863be7-dd57-470d-ae38-4d7019b63c03', N'admin@hiring.com', 0, N'AHlq9xdojOLAiHRCrWn/EUQpzMD5DKs6nUfLzbkx6PLI/FzD/7qaLovDyoJ/rB3E2g==', N'9e47677a-d28b-4fb8-a9e4-2773dc597446', NULL, 0, 0, NULL, 1, 0, N'admin@hiring.com')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'73a8a0e5-a4ba-4f6c-9bbe-03821f1fe2ac', N'CanManageTickets')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'a1e5100e-4e44-47b4-9b8d-ecfe1c3f2ded', N'CanViewTicketsOnly')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'73863be7-dd57-470d-ae38-4d7019b63c03', N'73a8a0e5-a4ba-4f6c-9bbe-03821f1fe2ac')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'12e9505f-0e6e-404d-8bb8-03d22a747560', N'a1e5100e-4e44-47b4-9b8d-ecfe1c3f2ded')



          

        ");
        }

        public override void Down()
        {
        }
    }
}
