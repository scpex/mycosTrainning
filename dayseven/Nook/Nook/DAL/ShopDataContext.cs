using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nook.Model;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Nook.DAL
{
   
    public class ShopDataContext : DbContext
    {
        public ShopDataContext() : base("ShopDataContext")
        {

        }
        public DbSet<Shop> Shops { set; get; }
        public DbSet<ShopBranch> Branchs { set; get; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
   
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
