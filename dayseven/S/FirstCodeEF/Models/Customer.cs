using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCodeEF.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ShopCouponId { get; set; }
        
        public virtual ShopCoupon ShopCoupon { get; set; }
    }
}
