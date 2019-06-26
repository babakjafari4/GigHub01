namespace GigHub01.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenresTable : DbMigration
    {
        public override void Up()
        {
            Sql("Insert Into dbo.Genres (Id, Name) VALUES(1, 'JAZZ')");
            Sql("Insert Into dbo.Genres (Id, Name) VALUES(2, 'Blues')");
            Sql("Insert Into dbo.Genres (Id, Name) VALUES(3, 'Rock')");
            Sql("Insert Into dbo.Genres (Id, Name) VALUES(4, 'Country')");
            Sql("Insert Into dbo.Genres (Id, Name) VALUES(5, 'Folk')");
        }
        
        public override void Down()
        {
            Sql("Delete dbo.Genres Where Id in (1,2,3,4,5)");
        }
    }
}
