namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovies : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, DateAdded, ReleasedDate, GenreId) VALUES ('Iruttu Araiyil Murattu Kuthu', '2018-01-11 00:00:00.000', '2018-06-11 00:00:00.000', 1)");
            Sql("INSERT INTO Movies (Name, DateAdded, ReleasedDate, GenreId) VALUES ('Nadigaiyar Thilagam', '2018-02-11 00:00:00.000', '2018-06-11 00:00:00.000', 1)");
            Sql("INSERT INTO Movies (Name, DateAdded, ReleasedDate, GenreId) VALUES ('Bhaskar Oru Rascal', '2018-03-11 00:00:00.000', '2018-06-11 00:00:00.000', 1)");
            Sql("INSERT INTO Movies (Name, DateAdded, ReleasedDate, GenreId) VALUES ('Irumbu Thirai', '2018-04-11 00:00:00.000', '2018-06-11 00:00:00.000', 1)");
            Sql("INSERT INTO Movies (Name, DateAdded, ReleasedDate, GenreId) VALUES ('Kaala', '2018-05-11 00:00:00.000', '2018-06-11 00:00:00.000', 1)");
        }
        
        public override void Down()
        {
        }
    }
}
