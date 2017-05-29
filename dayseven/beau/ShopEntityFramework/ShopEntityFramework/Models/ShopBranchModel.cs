using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopEntityFramework.Models
{
    public class ShopBranchModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ShopId { get; set; }

        public virtual ShopModel Shop { get; set; }
    }
}