using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using ShopEntityFramework.Models;

namespace ShopEntityFramework.DAL
{
    public class ShopDataContext : DbContext
    {
        public ShopDataContext() : base("ShopDataContext")
        {
        }

        public DbSet<ShopModel> Shop { get; set; }
        public DbSet<ShopBranchModel> ShopBranch { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}