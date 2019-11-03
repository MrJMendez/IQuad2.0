namespace IQuad2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsersAndRoles : DbMigration
    {
        public override void Up()
        {
            Sql(@" 
INSERT INTO [dbo].[AspNetUsers] ([Id], [Fname], [Lname], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [Initial], [Age], [Street], [District], [Parish], [UserTypeId]) VALUES (N'162b98e3-2ba3-4c9a-a5f2-0f24ac5f7bbf', N'Andrew', N'Bowen', N'Andrew@gmail.com', 0, N'AENHWqn55Y06h8x0918UIybgfvL0hhZF1xyDhyScAAQBo4sVfOQdZoW2DDUIvC2ZKA==', N'c0dd4757-5eda-4851-95de-3deb6e118796', N'876-234-5666', 0, 0, NULL, 1, 0, N'Andrew@gmail.com', N'K', 30, N'Dominica02', N'Vinyard Town', N'Kingston', N'Doctor')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Fname], [Lname], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [Initial], [Age], [Street], [District], [Parish], [UserTypeId]) VALUES (N'19f895c8-381e-4d11-ac4a-b442de893eb4', N'Janiel', N'Lawrence', N'janiel@gmail.com', 0, N'ANxD6NYZ5omZeXNw088mL8rIfVmqOP5+BdWEY0IdrMIvTe4I4c6PZViuIpyQIWaTWg==', N'91f90186-ea41-441c-9d9d-a21573dac0f4', N'876-123-4567', 0, 0, NULL, 1, 0, N'janiel@gmail.com', N'A', 21, N'Lane01', N'Aberdeen', N'St.Elizabeth', N'Patient')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Fname], [Lname], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [Initial], [Age], [Street], [District], [Parish], [UserTypeId]) VALUES (N'3aab3fea-408f-4769-852c-1f81399450dc', N'Tika', N'Atkinson', N'tika@gmail.com', 0, N'ANoZgBonbOJb7uJj+NW+Fb+d/7pbgAm7hlJlb83yY9KpG9wPVgN9atZsRNstLiZlbw==', N'9d48d039-122f-442f-9ea5-086b35a03f66', N'876-234-9987', 0, 0, NULL, 1, 0, N'tika@gmail.com', N'T', 23, N'Lane02', N'Appleton', N'St.Elizabeth', N'Receptionist')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Fname], [Lname], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [Initial], [Age], [Street], [District], [Parish], [UserTypeId]) VALUES (N'5362a2fc-3279-4768-ba5d-752113281164', N'Aqil', N'Redi', N'areid@gmail.com', 0, N'APAQFxaP6IS1G6rCNj4KTtT3n7hTzK/mkX2RLDJth3C7cNji2PAjvVFCJspVW3XpLg==', N'fccbc519-8a78-4aef-b82d-87ef8618974c', N'876-123-4456', 0, 0, NULL, 1, 0, N'areid@gmail.com', N'S', 22, N'Courtney Ave', N'Vinyard Town', N'Kingston', N'Patient')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Fname], [Lname], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [Initial], [Age], [Street], [District], [Parish], [UserTypeId]) VALUES (N'602eeaf8-f0a8-4ba0-a6fc-ba98592ffeac', N'james', N'Brown', N'jamesbrown@gmail.com', 0, N'AEpd/ilJU1Dy2wvFZFdVLh5Z5kn8QlW09S242ZaBbCwsqfG8N3weSFjsy2azMKM3vA==', N'7f00c2a5-7474-41f7-a792-ead470a71d11', N'876-262-2221', 0, 0, NULL, 1, 0, N'jamesbrown@gmail.com', N'B', 23, N'awsv', N'asdv', N'asdv', N'Doctor')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Fname], [Lname], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [Initial], [Age], [Street], [District], [Parish], [UserTypeId]) VALUES (N'd41f247f-0270-45bc-9708-7eec6116b2c1', N'Johnoy', N'Mendez', N'Admin@gmail.com', 0, N'ADgvjIDqf5DrQ+ZKuPTtOTGCERCTb0lI8e9/JdT/m+aacmUBng2racJDTq6zKs6TCQ==', N'34510157-5048-4282-9fcf-f54458f2963b', N'876-318-6436', 0, 0, NULL, 0, 0, N'Admin@gmail.com', N'A', 23, N'070 Street', N'Waltham', N'Manchester', N'Admin')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Fname], [Lname], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [Initial], [Age], [Street], [District], [Parish], [UserTypeId]) VALUES (N'fd515e01-c244-44af-8986-fa08a6dedb74', N'Mikhail', N'Campbell', N'mikhail@gmail.com', 0, N'AFgFt0jcuWHvFN0laNdvs/WH8VJHI4zD4dg2SyCyvNq6XGu0v0zTAjy3ekCSC065/w==', N'20c94a56-c835-4a79-bfd4-662656eacdaf', N'876-112-3345', 0, 0, NULL, 1, 0, N'mikhail@gmail.com', N'R', 21, N'WhiteLane', N'Spalding', N'Manchester', N'Patient')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'ae5afff8-d97d-45c2-93ef-2966047f8fa4', N'Admin')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'028b3ac2-cdc7-42f8-913e-21851807d2e4', N'Doctor')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'429f5d1b-e612-4461-8888-84249f524cc0', N'Patient')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'a8c2591c-4c77-427a-9c4b-eb1d2c7c194f', N'Receptionist')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'162b98e3-2ba3-4c9a-a5f2-0f24ac5f7bbf', N'028b3ac2-cdc7-42f8-913e-21851807d2e4')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'602eeaf8-f0a8-4ba0-a6fc-ba98592ffeac', N'028b3ac2-cdc7-42f8-913e-21851807d2e4')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'19f895c8-381e-4d11-ac4a-b442de893eb4', N'429f5d1b-e612-4461-8888-84249f524cc0')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'5362a2fc-3279-4768-ba5d-752113281164', N'429f5d1b-e612-4461-8888-84249f524cc0')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'fd515e01-c244-44af-8986-fa08a6dedb74', N'429f5d1b-e612-4461-8888-84249f524cc0')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'3aab3fea-408f-4769-852c-1f81399450dc', N'a8c2591c-4c77-427a-9c4b-eb1d2c7c194f')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'd41f247f-0270-45bc-9708-7eec6116b2c1', N'ae5afff8-d97d-45c2-93ef-2966047f8fa4')



");
        }
        
        public override void Down()
        {
        }
    }
}