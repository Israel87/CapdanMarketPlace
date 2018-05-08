using System.Collections.Generic;
using FluentValidation.Attributes;
using Nop.Web.Areas.Merchant.Validators.Shipping;
using Nop.Web.Framework.Localization;
using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Mvc.Models;

namespace Nop.Web.Areas.Merchant.Models.Shipping
{
    [Validator(typeof(ShippingMethodValidator))]
    public partial class ShippingMethodModel : BaseNopEntityModel, ILocalizedModel<ShippingMethodLocalizedModel>
    {
        public ShippingMethodModel()
        {
            Locales = new List<ShippingMethodLocalizedModel>();
        }

        [NopResourceDisplayName("Merchant.Configuration.Shipping.Methods.Fields.Name")]
        public string Name { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Shipping.Methods.Fields.Description")]
        public string Description { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Shipping.Methods.Fields.DisplayOrder")]
        public int DisplayOrder { get; set; }

        public IList<ShippingMethodLocalizedModel> Locales { get; set; }
    }

    public partial class ShippingMethodLocalizedModel : ILocalizedModelLocal
    {
        public int LanguageId { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Shipping.Methods.Fields.Name")]
        public string Name { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Shipping.Methods.Fields.Description")]
        public string Description { get; set; }
    }
}