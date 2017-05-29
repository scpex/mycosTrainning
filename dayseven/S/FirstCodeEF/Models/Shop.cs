using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCodeEF.Models
{
    public class Shop
    {
        public int ID { get; set; }
        public string ShopName { get; set; }
        public string ShopAddress { get; set; }


        public virtual ICollection<ShopCoupon> ShopCoupon { get; set; }
    }
}
