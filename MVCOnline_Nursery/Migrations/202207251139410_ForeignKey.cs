namespace MVCOnline_Nursery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ForeignKey : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.ProductDemoes", "CategoryId");
            AddForeignKey("dbo.ProductDemoes", "CategoryId", "dbo.CategoriesDemoes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductDemoes", "CategoryId", "dbo.CategoriesDemoes");
            DropIndex("dbo.ProductDemoes", new[] { "CategoryId" });
        }
    }
}
