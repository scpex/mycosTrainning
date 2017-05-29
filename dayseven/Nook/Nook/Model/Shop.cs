using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nook.Model;

namespace Nook.Model
{
    public class Shop
    {
        public int ShopID { set; get; }
        public string ShopName { set; get; }

        public virtual List<ShopBranch> Branchs { set; get; }
    }
}
