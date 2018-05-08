using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Mvc.Models;

namespace Nop.Web.Areas.Merchant.Models.Catalog
{
    public partial class CopyProductModel : BaseNopEntityModel
    {

        [NopResourceDisplayName("Merchant.Catalog.Products.Copy.Name")]
        public string Name { get; set; }

        [NopResourceDisplayName("Merchant.Catalog.Products.Copy.CopyImages")]
        public bool CopyImages { get; set; }

        [NopResourceDisplayName("Merchant.Catalog.Products.Copy.Published")]
        public bool Published { get; set; }
    }
}