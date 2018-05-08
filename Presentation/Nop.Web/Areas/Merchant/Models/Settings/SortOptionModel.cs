using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Mvc.Models;

namespace Nop.Web.Areas.Merchant.Models.Settings
{
    public partial class SortOptionModel : BaseNopEntityModel
    {
        [NopResourceDisplayName("Merchant.Configuration.Settings.Catalog.SortOptions.Name")]
        public string Name { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Settings.Catalog.SortOptions.IsActive")]
        public bool IsActive { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Settings.Catalog.SortOptions.DisplayOrder")]
        public int DisplayOrder { get; set; }
    }
}