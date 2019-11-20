namespace FredCars.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRatingCarModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cars", "Rating", c => c.Int(nullable: false));
            AddColumn("dbo.Cars", "Carmodel", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cars", "Carmodel");
            DropColumn("dbo.Cars", "Rating");
        }
    }
}
