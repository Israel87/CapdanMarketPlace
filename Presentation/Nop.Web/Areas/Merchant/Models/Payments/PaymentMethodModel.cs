using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Mvc.Models;

namespace Nop.Web.Areas.Merchant.Models.Payments
{
    public partial class PaymentMethodModel : BaseNopModel
    {
        [NopResourceDisplayName("Merchant.Configuration.Payment.Methods.Fields.FriendlyName")]
        public string FriendlyName { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Payment.Methods.Fields.SystemName")]
        public string SystemName { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Payment.Methods.Fields.DisplayOrder")]
        public int DisplayOrder { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Payment.Methods.Fields.IsActive")]
        public bool IsActive { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Payment.Methods.Configure")]
        public string ConfigurationUrl { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Payment.Methods.Fields.Logo")]
        public string LogoUrl { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Payment.Methods.Fields.SupportCapture")]
        public bool SupportCapture { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Payment.Methods.Fields.SupportPartiallyRefund")]
        public bool SupportPartiallyRefund { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Payment.Methods.Fields.SupportRefund")]
        public bool SupportRefund { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Payment.Methods.Fields.SupportVoid")]
        public bool SupportVoid { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Payment.Methods.Fields.RecurringPaymentType")]
        public string RecurringPaymentType { get; set; }
    }
}