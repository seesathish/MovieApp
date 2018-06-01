namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenametoReleaseDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "ReleaseDate", c => c.DateTime());
            Sql("UPDATE Movies Set ReleaseDate = ReleasedDate");
            DropColumn("dbo.Movies", "ReleasedDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "ReleasedDate", c => c.DateTime());
            DropColumn("dbo.Movies", "ReleaseDate");
        }
    }
}
