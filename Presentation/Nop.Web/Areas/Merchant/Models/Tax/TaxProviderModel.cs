using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Mvc.Models;

namespace Nop.Web.Areas.Merchant.Models.Tax
{
    public partial class TaxProviderModel : BaseNopModel
    {
        [NopResourceDisplayName("Merchant.Configuration.Tax.Providers.Fields.FriendlyName")]
        public string FriendlyName { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Tax.Providers.Fields.SystemName")]
        public string SystemName { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Tax.Providers.Fields.IsPrimaryTaxProvider")]
        public bool IsPrimaryTaxProvider { get; set; }
        
        [NopResourceDisplayName("Merchant.Configuration.Tax.Providers.Configure")]
        public string ConfigurationUrl { get; set; }
    }
}