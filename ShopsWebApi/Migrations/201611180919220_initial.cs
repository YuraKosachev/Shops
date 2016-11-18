namespace ShopsWebApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        ProductName = c.String(),
                        ProductDescription = c.String(),
                        Shop_ShopId = c.Int(),
                    })
                .PrimaryKey(t => t.ProductId)
                .ForeignKey("dbo.Shops", t => t.Shop_ShopId)
                .Index(t => t.Shop_ShopId);
            
            CreateTable(
                "dbo.Shops",
                c => new
                    {
                        ShopId = c.Int(nullable: false, identity: true),
                        ShopName = c.String(),
                        ShopAddress = c.String(),
                        ShopOpeningTime = c.Time(nullable: false, precision: 7),
                        ShopClosingTime = c.Time(nullable: false, precision: 7),
                    })
                .PrimaryKey(t => t.ShopId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "Shop_ShopId", "dbo.Shops");
            DropIndex("dbo.Products", new[] { "Shop_ShopId" });
            DropTable("dbo.Shops");
            DropTable("dbo.Products");
        }
    }
}
