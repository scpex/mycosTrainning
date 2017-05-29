using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopEntityFramework.Models
{
    public class ShopModel
    {
        public int ID { get; set; }
        public string ShopName { get; set; }
        public string ShopAddress { get; set; }


        public virtual ICollection<ShopBranchModel> ShopBranch { get; set; }
    }
}