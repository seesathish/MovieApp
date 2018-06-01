namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDataAnnotationsToMembershipNameandUpdateExistingData : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE dbo.MembershipTypes Set Name = 'Pay As You Go' where Id =1");
            Sql("UPDATE dbo.MembershipTypes Set Name = 'Monthly' where Id =2");
            Sql("UPDATE dbo.MembershipTypes Set Name = 'Quarterly' where Id =3");
            Sql("UPDATE dbo.MembershipTypes Set Name = 'Annualy' where Id =4");

            AlterColumn("dbo.MembershipTypes", "Name", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MembershipTypes", "Name", c => c.String());
        }
    }
}
