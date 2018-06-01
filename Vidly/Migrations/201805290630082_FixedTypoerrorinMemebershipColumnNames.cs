namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixedTypoerrorinMemebershipColumnNames : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTypes", "SignUpFee", c => c.Short(nullable: false));
            AddColumn("dbo.MembershipTypes", "DiscountRate", c => c.Byte(nullable: false));
            DropColumn("dbo.MembershipTypes", "SignUpFree");
            DropColumn("dbo.MembershipTypes", "DicountRate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MembershipTypes", "DicountRate", c => c.Byte(nullable: false));
            AddColumn("dbo.MembershipTypes", "SignUpFree", c => c.Short(nullable: false));
            DropColumn("dbo.MembershipTypes", "DiscountRate");
            DropColumn("dbo.MembershipTypes", "SignUpFee");
        }
    }
}
