namespace FredCars.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateManufacturer : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Manufacturers (Name) VALUES ('Toyota')");
            Sql("INSERT INTO Manufacturers (Name) VALUES ('Benz')");
            Sql("INSERT INTO Manufacturers (Name) VALUES ('Nissan')");
            Sql("INSERT INTO Manufacturers (Name) VALUES ('Lexus')");
        }
        
        public override void Down()
        {
        }
    }
}
