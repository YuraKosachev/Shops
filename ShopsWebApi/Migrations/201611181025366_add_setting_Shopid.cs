namespace ShopsWebApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_setting_Shopid : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Products", "Shop_ShopId", "dbo.Shops");
            DropIndex("dbo.Products", new[] { "Shop_ShopId" });
            RenameColumn(table: "dbo.Products", name: "Shop_ShopId", newName: "ShopId");
            AlterColumn("dbo.Products", "ShopId", c => c.Int(nullable: false));
            CreateIndex("dbo.Products", "ShopId");
            AddForeignKey("dbo.Products", "ShopId", "dbo.Shops", "ShopId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "ShopId", "dbo.Shops");
            DropIndex("dbo.Products", new[] { "ShopId" });
            AlterColumn("dbo.Products", "ShopId", c => c.Int());
            RenameColumn(table: "dbo.Products", name: "ShopId", newName: "Shop_ShopId");
            CreateIndex("dbo.Products", "Shop_ShopId");
            AddForeignKey("dbo.Products", "Shop_ShopId", "dbo.Shops", "ShopId");
        }
    }
}
