using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Mvc.Models;

namespace Nop.Web.Areas.Merchant.Models.Catalog
{
    public partial class LowStockProductModel : BaseNopEntityModel
    {
        [NopResourceDisplayName("Merchant.Catalog.Products.Fields.Name")]
        public string Name { get; set; }

        public string Attributes { get; set; }

        [NopResourceDisplayName("Merchant.Catalog.Products.Fields.ManageInventoryMethod")]
        public string ManageInventoryMethod { get; set; }

        [NopResourceDisplayName("Merchant.Catalog.Products.Fields.StockQuantity")]
        public int StockQuantity { get; set; }

        [NopResourceDisplayName("Merchant.Catalog.Products.Fields.Published")]
        public bool Published { get; set; }
    }
}