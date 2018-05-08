using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Mvc.Models;

namespace Nop.Web.Areas.Merchant.Models.ExternalAuthentication
{
    public partial class AuthenticationMethodModel : BaseNopModel
    {
        [NopResourceDisplayName("Merchant.Configuration.ExternalAuthenticationMethods.Fields.FriendlyName")]
        public string FriendlyName { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.ExternalAuthenticationMethods.Fields.SystemName")]
        public string SystemName { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.ExternalAuthenticationMethods.Fields.DisplayOrder")]
        public int DisplayOrder { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.ExternalAuthenticationMethods.Fields.IsActive")]
        public bool IsActive { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.ExternalAuthenticationMethods.Configure")]
        public string ConfigurationUrl { get; set; }
    }
}