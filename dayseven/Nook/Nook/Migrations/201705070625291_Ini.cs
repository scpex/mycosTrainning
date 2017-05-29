namespace Nook.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Ini : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ShopBranch",
                c => new
                    {
                        ShopBranchId = c.Int(nullable: false, identity: true),
                        BranchName = c.String(),
                        ShopID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ShopBranchId)
                .ForeignKey("dbo.Shop", t => t.ShopID, cascadeDelete: true)
                .Index(t => t.ShopID);
            
            CreateTable(
                "dbo.Shop",
                c => new
                    {
                        ShopID = c.Int(nullable: false, identity: true),
                        ShopName = c.String(),
                    })
                .PrimaryKey(t => t.ShopID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ShopBranch", "ShopID", "dbo.Shop");
            DropIndex("dbo.ShopBranch", new[] { "ShopID" });
            DropTable("dbo.Shop");
            DropTable("dbo.ShopBranch");
        }
    }
}
