namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'6ad238e2-da5c-4cd7-9f9d-9c20f2dfc31f', N'admin@vidly.com', 0, N'AFMmNIOuB/YHilH2rZGCY5/JSwWI5K10HSSuCFO2iVHKiX0Toq0HD+Et+tD6glbi9g==', N'a2aaef3e-dd83-4cde-a114-0a7b7eb3ecfd', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')");
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'6edea93b-b3e0-432a-aa6b-719c874ce46f', N'guest@vidly.com', 0, N'ANxxKBetGi4zrHM3UiGwnix5eHH+iGW4/LzP0NpP6OxZrRpjHvbmoHbAryytwjcyiw==', N'e360c3dd-ed0d-4409-b48f-d5a28e54abcd', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')");

            Sql(@"INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'36b215e0-2b8a-4281-a417-83e1646a09fb', N'CanManageMovies')");

            Sql(@"INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'6ad238e2-da5c-4cd7-9f9d-9c20f2dfc31f', N'36b215e0-2b8a-4281-a417-83e1646a09fb')");
        }
        
        public override void Down()
        {
        }
    }
}
