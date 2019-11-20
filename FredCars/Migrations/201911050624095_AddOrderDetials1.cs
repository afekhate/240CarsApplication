namespace FredCars.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddOrderDetials1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Line1 = c.String(nullable: false),
                        Line2 = c.String(),
                        City = c.String(nullable: false),
                        state = c.String(nullable: false),
                        Zip = c.String(),
                        Country = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.OrderId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Orders");
        }
    }
}
