using FluentValidation.Attributes;
using Nop.Web.Areas.Merchant.Validators.Tax;
using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Mvc.Models;

namespace Nop.Web.Areas.Merchant.Models.Tax
{
    [Validator(typeof(TaxCategoryValidator))]
    public partial class TaxCategoryModel : BaseNopEntityModel
    {
        [NopResourceDisplayName("Merchant.Configuration.Tax.Categories.Fields.Name")]
        public string Name { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.Tax.Categories.Fields.DisplayOrder")]
        public int DisplayOrder { get; set; }
    }
}