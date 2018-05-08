using FluentValidation.Attributes;
using Nop.Web.Areas.Merchant.Validators.Directory;
using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Mvc.Models;

namespace Nop.Web.Areas.Merchant.Models.Directory
{
    [Validator(typeof(MeasureDimensionValidator))]
    public partial class MeasureDimensionModel : BaseNopEntityModel
    {
        [NopResourceDisplayName("Merchant.Configuration.Shipping.Measures.Dimensions.Fields.Name")]
        public string Name { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Shipping.Measures.Dimensions.Fields.SystemKeyword")]
        public string SystemKeyword { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Shipping.Measures.Dimensions.Fields.Ratio")]
        public decimal Ratio { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Shipping.Measures.Dimensions.Fields.DisplayOrder")]
        public int DisplayOrder { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Shipping.Measures.Dimensions.Fields.IsPrimaryDimension")]
        public bool IsPrimaryDimension { get; set; }
    }
}