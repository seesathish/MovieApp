namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateBirthDate : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE dbo.Customers Set BirthDate = '1975-10-11 00:00:00.000' where Id =1");
            Sql("UPDATE dbo.Customers Set BirthDate = '2012-09-17 00:00:00.000' where Id =2");
            Sql("UPDATE dbo.Customers Set BirthDate = '1978-04-01 00:00:00.000' where Id =3");
        }
        
        public override void Down()
        {
        }
    }
}
