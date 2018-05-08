using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Mvc.Models;

namespace Nop.Web.Areas.Merchant.Models.Common
{
    public partial class UrlRecordModel : BaseNopEntityModel
    {
        [NopResourceDisplayName("Merchant.System.SeNames.Name")]
        public string Name { get; set; }

        [NopResourceDisplayName("Merchant.System.SeNames.EntityId")]
        public int EntityId { get; set; }

        [NopResourceDisplayName("Merchant.System.SeNames.EntityName")]
        public string EntityName { get; set; }

        [NopResourceDisplayName("Merchant.System.SeNames.IsActive")]
        public bool IsActive { get; set; }

        [NopResourceDisplayName("Merchant.System.SeNames.Language")]
        public string Language { get; set; }

        [NopResourceDisplayName("Merchant.System.SeNames.Details")]
        public string DetailsUrl { get; set; }
    }
}