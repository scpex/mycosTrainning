using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCodeEF.Models
{
    public class ShopCoupon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ShopId { get; set; }

        public virtual Shop Shop { get; set; }
        public virtual ICollection<Customer> Customer { get; set; }
    }
}