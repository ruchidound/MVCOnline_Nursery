namespace MVCOnline_Nursery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProductDemoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SKU_NO = c.Int(nullable: false),
                        Name = c.String(),
                        Description = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IsAvailable = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false, defaultValueSql: "Getdate()"),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ProductDemoes");
        }
    }
}
