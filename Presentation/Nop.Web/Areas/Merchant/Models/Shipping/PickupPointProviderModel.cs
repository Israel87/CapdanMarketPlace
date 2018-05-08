using Microsoft.AspNetCore.Routing;
using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Mvc.Models;

namespace Nop.Web.Areas.Merchant.Models.Shipping
{
    public partial class PickupPointProviderModel : BaseNopModel
    {
        [NopResourceDisplayName("Merchant.Configuration.Shipping.PickupPointProviders.Fields.FriendlyName")]
        public string FriendlyName { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Shipping.PickupPointProviders.Fields.SystemName")]
        public string SystemName { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Shipping.PickupPointProviders.Fields.DisplayOrder")]
        public int DisplayOrder { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Shipping.PickupPointProviders.Fields.IsActive")]
        public bool IsActive { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Shipping.PickupPointProviders.Fields.Logo")]
        public string LogoUrl { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Shipping.PickupPointProviders.Configure")]
        public string ConfigurationUrl { get; set; }

        public string ConfigurationActionName { get; set; }
        public string ConfigurationControllerName { get; set; }
        public RouteValueDictionary ConfigurationRouteValues { get; set; }
    }
}