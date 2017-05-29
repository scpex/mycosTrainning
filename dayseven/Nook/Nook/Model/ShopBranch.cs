using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nook.Model;

namespace Nook.Model
{
    public class ShopBranch
    {
        public int ShopBranchId { set; get; }
        public string BranchName { set; get; }

        public int ShopID { set; get; }
        public virtual Shop Shop { set; get; }

    }
}
