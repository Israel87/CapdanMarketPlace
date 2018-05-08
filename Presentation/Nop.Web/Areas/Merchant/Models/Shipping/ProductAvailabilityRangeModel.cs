using System.Collections.Generic;
using FluentValidation.Attributes;
using Nop.Web.Areas.Merchant.Validators.Shipping;
using Nop.Web.Framework.Localization;
using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Mvc.Models;

namespace Nop.Web.Areas.Merchant.Models.Shipping
{
    [Validator(typeof(ProductAvailabilityRangeValidator))]
    public partial class ProductAvailabilityRangeModel : BaseNopEntityModel, ILocalizedModel<ProductAvailabilityRangeLocalizedModel>
    {
        public ProductAvailabilityRangeModel()
        {
            Locales = new List<ProductAvailabilityRangeLocalizedModel>();
        }

        [NopResourceDisplayName("Merchant.Configuration.Shipping.ProductAvailabilityRanges.Fields.Name")]
        public string Name { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Shipping.ProductAvailabilityRanges.Fields.DisplayOrder")]
        public int DisplayOrder { get; set; }

        public IList<ProductAvailabilityRangeLocalizedModel> Locales { get; set; }
    }

    public partial class ProductAvailabilityRangeLocalizedModel : ILocalizedModelLocal
    {
        public int LanguageId { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Shipping.ProductAvailabilityRanges.Fields.Name")]
        public string Name { get; set; }
    }
}