namespace FirstCodeEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitializeShop : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Shop",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ShopName = c.String(),
                        ShopAddress = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.ShopCoupon",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ShopId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Shop", t => t.ShopId, cascadeDelete: true)
                .Index(t => t.ShopId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ShopCoupon", "ShopId", "dbo.Shop");
            DropIndex("dbo.ShopCoupon", new[] { "ShopId" });
            DropTable("dbo.ShopCoupon");
            DropTable("dbo.Shop");
        }
    }
}
