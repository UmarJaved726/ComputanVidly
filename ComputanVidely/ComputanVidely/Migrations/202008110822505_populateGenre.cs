namespace ComputanVidely.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateGenre : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres(Name)values('Comedy')");
            Sql("INSERT INTO Genres(Name)values('Action')");
            Sql("INSERT INTO Genres(Name)values('Family')");
            Sql("INSERT INTO Genres(Name)values('Romance')");
        }
        
        public override void Down()
        {
        }
    }
}
