using FluentValidation.Attributes;
using Nop.Web.Areas.Merchant.Validators.Directory;
using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Mvc.Models;

namespace Nop.Web.Areas.Merchant.Models.Directory
{
    [Validator(typeof(MeasureWeightValidator))]
    public partial class MeasureWeightModel : BaseNopEntityModel
    {
        [NopResourceDisplayName("Merchant.Configuration.Shipping.Measures.Weights.Fields.Name")]
        public string Name { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Shipping.Measures.Weights.Fields.SystemKeyword")]
        public string SystemKeyword { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Shipping.Measures.Weights.Fields.Ratio")]
        public decimal Ratio { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Shipping.Measures.Weights.Fields.DisplayOrder")]
        public int DisplayOrder { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Shipping.Measures.Weights.Fields.IsPrimaryWeight")]
        public bool IsPrimaryWeight { get; set; }
    }
}