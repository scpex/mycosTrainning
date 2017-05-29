namespace ShopEntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitializeShop : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ShopModel",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ShopName = c.String(),
                        ShopAddress = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.ShopBranchModel",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ShopId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ShopModel", t => t.ShopId, cascadeDelete: true)
                .Index(t => t.ShopId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ShopBranchModel", "ShopId", "dbo.ShopModel");
            DropIndex("dbo.ShopBranchModel", new[] { "ShopId" });
            DropTable("dbo.ShopBranchModel");
            DropTable("dbo.ShopModel");
        }
    }
}
