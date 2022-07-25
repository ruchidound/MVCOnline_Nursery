namespace MVCOnline_Nursery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CategoryModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CategoriesDemoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.ProductDemoes", "SKU_NO", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.ProductDemoes", new[] { "SKU_NO" });
            DropTable("dbo.CategoriesDemoes");
        }
    }
}
