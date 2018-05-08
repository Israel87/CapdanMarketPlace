using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Mvc.Models;

namespace Nop.Web.Areas.Merchant.Models.Vendors
{
    public partial class VendorListModel : BaseNopModel
    {
        [NopResourceDisplayName("Merchant.Vendors.List.SearchName")]
        public string SearchName { get; set; }
    }
}