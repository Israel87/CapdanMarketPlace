using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nop.Web.Models.Customer
{
    public class MerchantProducts
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string FullDescription { get; set; }
        public string DisplayOrder { get; set; }
        public string SKU { get; set; }
        public string StockQuantity { get; set; }

    }
}
