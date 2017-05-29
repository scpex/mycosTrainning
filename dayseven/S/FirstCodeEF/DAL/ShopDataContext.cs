using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using FirstCodeEF.Models;

namespace FirstCodeEF.DAL
{
    public class ShopDataContext : DbContext
    {
        public ShopDataContext() : base("ShopDataContext")
        {
        }

        public DbSet<Shop> Shop { get; set; }
        public DbSet<ShopCoupon> ShopCoupon { get; set; }
        public DbSet<Customer> Customer { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}