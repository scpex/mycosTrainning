using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Nook.Model;

namespace Nook
{
    class Program
    {
        public class ShopContext : DbContext
        {

            public DbSet<Shop> Shops { set; get; }
            public DbSet<ShopBranch> Branchs { set; get; }
        }
        static void Main(string[] args)
        {
            //using (var db = new ShopContext())
            //{
            //    // Create and save a new Blog              
            //    var name = "eiei";

            //    var shop = new Shop { ShopName = name };                
            //    db.Shops.Add(shop);
            //    db.SaveChanges();

            //    // Display all Blogs from the database 
            //    var query = from b in db.Shops
            //                orderby b.ShopName
            //                select b;

            //    Console.WriteLine("All blogs in the database:");
            //    foreach (var item in query)
            //    {
            //        Console.WriteLine(item.ShopName);
            //    }

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            //}
        }
    }
}
