namespace FirstCodeEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCustomer : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customer",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ShopCouponId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ShopCoupon", t => t.ShopCouponId, cascadeDelete: true)
                .Index(t => t.ShopCouponId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customer", "ShopCouponId", "dbo.ShopCoupon");
            DropIndex("dbo.Customer", new[] { "ShopCouponId" });
            DropTable("dbo.Customer");
        }
    }
}
